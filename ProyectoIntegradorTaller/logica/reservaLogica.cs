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
        public static void insertarReserva(int id_aula, string CBHora,string CBMateria,string CBPRofesor, string CBDia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var usuarioProfesor = db.usuario.FirstOrDefault(usuario => usuario.nombre == CBPRofesor);
                var materiaElegida = db.materias.FirstOrDefault(materia => materia.materia == CBMateria);
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == CBDia);
                var horarioElegido= db.horas.FirstOrDefault(horario => horario.horario == CBHora);
                reserva unaReserva = new reserva()
                {
                    id_hora = horarioElegido.id_hora,
                    id_usuario = usuarioProfesor.id_usuario,
                    id_materia = materiaElegida.id_materia,
                    id_dia = diaElegido.id_dias,
                    id_aula = id_aula
                   
                };
                db.SaveChanges();

            }
        }
        public static void mostrarReserva(string diaColumna,string Horario)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
/*
                var diaElegido = db.dias_semana.FirstOrDefault(dia => dia.dias == diaColumna);
                var horaElegido = db.horas.FirstOrDefault(hora => hora.horario == Horario);
                var query = from reserva in db.reserva
              /*              join dias_semana in db.dias_semana on  reserva.id_dia== dias_semana.id_
                            where dias_semana.dias==diaColumna && horas.horario == Horario


                dataGrid.DataSource = query.ToList();

                /*  reserva unaReserva = new reserva()
                  {
                      id_hora = horarioElegido.id_hora,
                      id_usuario = usuarioProfesor.id_usuario,
                      id_materia = materiaElegida.id_materia,
                      id_dia = diaElegido.id_dias,
                      id_aula = id_aula

                  };*/
                db.SaveChanges();

            }
        }

    }
}
