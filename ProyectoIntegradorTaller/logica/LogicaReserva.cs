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
    public class LogicaReserva
    {
        public static horas ObtenerHorarioPorID(int idHorario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var horario = db.horas.FirstOrDefault(h => h.id_hora == idHorario);
                return horario;
            }
        }

        public static dias_semana ObtenerDiaPorID(int idDia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var dia = db.dias_semana.FirstOrDefault(d => d.id_dias == idDia);
                return dia;
            }
        }


        //Retorna verdadero en caso de no haber encontrado reservas en en ese horario y dia
        public static reserva BuscarReserva(int idDia, int idHora, int idAula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var reserva1 = db.reserva.FirstOrDefault(
                    r => r.id_hora == idHora
                    && r.id_dia == idDia
                    && r.id_aula == idAula
                    && r.activo == "SI");

                return reserva1 ;

            }
        }
        public static void MostrarGrilla(int id_aula, DataGridView dataGrid)
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
                    var m = db.materias.FirstOrDefault(ma => ma.id_materia == res.id_materia);
                    var p = db.usuario.FirstOrDefault(pr => pr.id_usuario == res.id_usuario);
                    int dia = res.id_dia;
                    int horario = res.id_hora;


                    grillaHorarios[horario - 1, dia] = m.materia + "( " + p.nombre + " " + p.apellido+ " )";
                }
            }
            dataGrid.Rows.Clear();

            for (int i = 0; i < 6; i++)
            {

                dataGrid.Rows.Add(grillaHorarios[i, 0], grillaHorarios[i, 1], grillaHorarios[i, 2], grillaHorarios[i, 3], grillaHorarios[i, 4], grillaHorarios[i, 5], grillaHorarios[i, 6]);

            }


        }

        public static void EliminarReserva(int idReserva)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                if (reserva != null)
                {
                    // Elimina la reserva
                    db.reserva.Remove(reserva);
                    db.SaveChanges();
                }
                
            }
        }


        public static void ReservaActiva(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {

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
                box.DisplayMember = "materia";
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
                box.DisplayMember = "nombre";
                box.ValueMember = "id_usuario";
            }
        }
        public static void EditarReserva(int idReserva, int idHora, string CBMateria, string CBProfesor, int idDia, DateTime fechad, DateTime fechah, string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                // Obtener la reserva a editar
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                if (reserva != null)
                {
                    // Obtener los objetos asociados a los nombre
                    var materiaElegida = db.materias.FirstOrDefault(m => m.materia == CBMateria);
                    var usuarioProfesor = db.usuario.FirstOrDefault(u => u.nombre == CBProfesor);


                    // Actualizar los campos de la reserva con los nuevos valores
                    reserva.id_hora = idHora;
                    reserva.id_materia =materiaElegida.id_materia ;
                    reserva.id_usuario =usuarioProfesor.id_usuario;
                    reserva.id_dia = idDia;
                    reserva.activo = estado;
                    reserva.fecha_desde = fechad;
                    reserva.fecha_hasta = fechah;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }
                
            }
        }
        public static void DesactivarReserva(int idReserva)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var reserva = db.reserva.FirstOrDefault(r => r.id_reserva == idReserva);

                if (reserva != null)
                {
                    reserva.activo = "NO";  // Cambia el estado a "NO"

                    // Guarda los cambios en la base de datos
                    db.SaveChanges();
                }
                
            }
        }

        public static void InsertarReserva(int id_aula, string CBHora, string CBMateria, string CBPRofesor, string CBDia, DateTime fechad, DateTime fechah, string Estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == CBPRofesor);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido = db.horas.FirstOrDefault(horario => horario.horario == CBHora);

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
        
        public static void ListarReservas(DataGridView dataGrid, string estado)
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
        public static void ListarReservas(DataGridView dataGrid, string estado,int id)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo == estado && reserva.id_usuario== id
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
