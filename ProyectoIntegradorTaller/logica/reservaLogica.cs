using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class reservaLogica
    {

        public static void reservaActiva(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            // dataGrid.Rows[e.RowIndex].Cells["Desactivar"].Value = estado;
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                int idUsuario = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); // 

                reserva aulaDesactivar = db.reserva.FirstOrDefault(u => u.id_reserva == idUsuario);
                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activo = estado;
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
                box.DataSource = db.materias.ToList();
                box.DisplayMember = "materia"; // Specify the property to display in the ComboBox
                box.ValueMember = "id_materia";
            }
        }
        public static void CBPRofesorListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var usuario = db.usuario
                              .Where(u => u.id_tipoUsuario==3).ToList();
                box.DataSource = usuario;
                box.DisplayMember = "nombre"; // Specify the property to display in the ComboBox
                box.ValueMember = "id_usuario";
            }
        }
        public static void mostrarHorarios(DataGridView dataGrid)
        {
            using (classroom_managerEntities db= new classroom_managerEntities())
            {
                
                //for (int i = 0; i < 6; i ++)
                //{
                  //  var horas_ = db.horas.FirstOrDefault(id => id.id_hora == i);
                       
                    var query = from horas in db.horas
                               // where horas.id_hora == i
                                 select new 
                                 {
                                    Horario = horas.horario,
                       
                                  };

                   dataGrid.Rows.Add(query);
                //}
               
 //               dataGrid.DataSource = query.ToList();
            }

            
        }
        public static void insertarReserva(int id_aula, string CBHora,string CBMateria,string CBPRofesor, string CBDia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == CBPRofesor);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido= db.horas.FirstOrDefault(horario => horario.horario == CBHora);
                //MessageBox.Show(usuarioProfesor.id_usuario +" "+ materiaElegida.id_materia);
                reserva unaReserva = new reserva()
                {
                    id_hora = horarioElegido.id_hora,
                    id_usuario = usuarioProfesor.id_usuario,
                    id_materia = materiaElegida.id_materia,
                    id_dia = diaElegido.id_dias,
                    id_aula = id_aula
                   
                };
                db.reserva.Add(unaReserva);
                db.SaveChanges();

            }
        }
        public static void listarReservas(DataGridView dataGrid,string estado)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            where reserva.activo==estado
                            select new
                            {
                                ID=reserva.id_reserva,
                                Name = aula.nombre,
                                Hora= horas.horario,
                                usuario=usuario.nombre,
                                materia=materias.materia,
                                Estado=reserva.activo,
                                Dia = dias_semana.dias,

                            };
                dataGrid.DataSource = query.ToList();
            }
        }
        public static void mostrarReserva(DataGridView dataGrid)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                //   var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == diaColumna);
                //  var horaElegido = db.horas.FirstOrDefault(hora => hora.horario == Horario);
                var diaColumna=dataGrid.Columns["lunes"].Name;
                Dictionary<int, string> dict = new Dictionary<int, string>()
                {
                    {0,"Lunes"},
                    {4,"Jueves" }
                };
                var semana = from reserva in db.reserva join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                             select new { 
                                dias= (dict.ContainsKey(dias_semana.id_dias) ? dict[dias_semana.id_dias] : "Unknown")
                             };
                var query = from reserva in db.reserva
                            join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                            join horas in db.horas on reserva.id_hora equals horas.id_hora
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            
                            select new {

                                dias= materias.materia
                            };
                            


                dataGrid.DataSource = query.ToList();

                /*  reserva unaReserva = new reserva()
                  {
                      id_hora = horarioElegido.id_hora,
                      id_usuario = usuarioProfesor.id_usuario,
                      id_materia = materiaElegida.id_materia,
                      id_dia = diaElegido.id_dias,
                      id_aula = id_aula

                  };*/
               
            }
        }

    }
}
