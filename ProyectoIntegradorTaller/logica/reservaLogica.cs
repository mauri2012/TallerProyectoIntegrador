using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class reservaLogica
    {
        public static string GetUsuario(int id_usuario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var usuarioElejido = db.usuario.FirstOrDefault(u => u.id_usuario == id_usuario);
                return usuarioElejido.nombre;
            }
        }
        public static string GetMateria(int id_materia) { 
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var materiaElejida= db.materias.FirstOrDefault(m=> m.id_materia == id_materia);
                return materiaElejida.materia;
            }
        }
        public static reserva reservaVacia(string dia, string hora,int id_aula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities()) { 

                var horarioElejido = db.horas.FirstOrDefault(h =>h.horario ==hora);
                var diaElegida = db.dias_semana.FirstOrDefault(d => d.dias == dia);
   
            
               var reservas = db.reserva.FirstOrDefault(reserva => reserva.id_aula == id_aula && reserva.activo == "SI"  &&  reserva.id_dia== diaElegida.id_dias && reserva.id_hora==horarioElejido.id_hora);

               // MessageBox.Show(reservas.ToString());
                return reservas;

            }
        }
        public static void mostrarGrilla(int id_aula, DataGridView dataGrid)
        {
            List<reserva> reservas;

            string[,] grillaHorarios = new string[6, 7] {
            { "8:00-10:00", "" ,"","","","",""},
            { "10:00-12:00", "" ,"","","","",""},
            { "12:00-14:00", "" ,"","","","",""},
            { "14:00-16:00", "" ,"","","","",""},
            { "16:00-18:00", "" ,"","","","",""},
            { "18:00-20:00", "" ,"","","","",""}};


            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                reservas = db.reserva.Where(reserva => reserva.id_aula == id_aula && reserva.activo == "SI").ToList();
            

                foreach (var res in reservas)
                {
                    var m = db.materias.FirstOrDefault(ma=> ma.id_materia == res.id_materia);
                    var p = db.usuario.FirstOrDefault(pr=> pr.id_usuario==res.id_usuario);
                    int dia = res.id_dia;
                    int horario = res.id_hora;
                
                    
                    grillaHorarios[horario - 1, dia] = m.materia +"("+ p.nombre+" " + p.apellido +")";
                }
            }
            dataGrid.Rows.Clear();

            for (int i = 0; i < 6; i++)
            {

                dataGrid.Rows.Add(grillaHorarios[i, 0], grillaHorarios[i, 1], grillaHorarios[i, 2], grillaHorarios[i, 3], grillaHorarios[i, 4], grillaHorarios[i, 5], grillaHorarios[i, 6]);

            }


        }


        public static void reservaActiva(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            // dataGrid.Rows[e.RowIndex].Cells["Desactivar"].Value = estado;
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                int idUsuario = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); // 

                reserva reservaDesactivar = db.reserva.FirstOrDefault(u => u.id_reserva == idUsuario);
                if (reservaDesactivar != null)
                {
                    reservaDesactivar.activo = estado;
                    db.SaveChanges();

                }
            }
        }

        public static void CBHoraListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                box.DataSource = db.horas.ToList();
                box.DisplayMember = "horario"; // Specify the property to display in the ComboBox
                box.ValueMember = "id_hora";
            }
        }
        public static void CBMateriasListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                box.DataSource = db.materias.Where(m => m.activo == "SI").ToList();
                box.DisplayMember = "materia"; // Specify the property to display in the ComboBox
                box.ValueMember = "id_materia";
            }
        }
        public static void CBPRofesorListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var usuario = db.usuario
                              .Where(u => u.id_tipoUsuario == 4).ToList();
                box.DataSource = usuario;
                box.DisplayMember = "nombre"; // Specify the property to display in the ComboBox
                box.ValueMember = "id_usuario";
            }
        }
        
        public static void insertarReserva(int id_aula, string CBHora, string CBMateria, string CBPRofesor, string CBDia, DateTime fechad, DateTime fechah, string Estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == CBPRofesor);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido = db.horas.FirstOrDefault(horario => horario.horario == CBHora);
                //MessageBox.Show(usuarioProfesor.id_usuario +" "+ materiaElegida.id_materia);
                reserva unaReserva = new reserva()
                {
                    id_hora = horarioElegido.id_hora,
                    id_usuario = usuarioProfesor.id_usuario,
                    id_materia = materiaElegida.id_materia,
                    id_dia = diaElegido.id_dias,
                    id_aula = id_aula,
                    activo = Estado,
                    fecha_desde = fechad,
                    fecha_hasta = fechah,
                };
                db.reserva.Add(unaReserva);
                db.SaveChanges();

            }
        }
        public static void actualizarReserva(int id, string CBHora, string CBMateria, string CBPRofesor, string CBDia, DateTime fechad, DateTime fechah)
        {
            
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == CBPRofesor);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido = db.horas.FirstOrDefault(horario => horario.horario == CBHora);
            


                var entityToUpdate = db.reserva.Find(id);

                if (entityToUpdate != null)
                {
                    
                    entityToUpdate.id_usuario = usuarioProfesor.id_usuario;
                    entityToUpdate.id_materia = materiaElegida.id_materia;
                    entityToUpdate.id_dia = diaElegido.id_dias;
                    entityToUpdate.id_hora = horarioElegido.id_hora;
                    entityToUpdate.fecha_desde = fechad;
                    entityToUpdate.fecha_hasta = fechah;
                    
                    db.SaveChanges();

                }
            }
        }
        public static void listarReservas(DataGridView dataGrid, string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado
                            select new
                            {
                                ID = reserva.id_reserva,
                                Name = aula.nombre,
                                Hora = horas.horario,
                                usuario = usuario.nombre,
                                materia = materias.materia,
                                Estado = reserva.activo,
                                Dia = dias_semana.dias,

                            };
                dataGrid.DataSource = query.ToList();
            }
        }
        
        }

    }
