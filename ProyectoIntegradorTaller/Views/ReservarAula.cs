using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class ReservarAula : DraggablePanelUserControl
    {

        private int id_aula;
        public ReservarAula(int id,string hora, string dia)
        {
            InitializeComponent();
            CBHora.Texts = hora;
            CBDia.Texts = dia;
            id_aula = id;
            LogicaReserva.CBMateriasListar(CBMateria);
            fecha.Visible = false;
            BReservarAula.Visible = true;
            editar.Visible = false;
        }
        //editar aula
        public ReservarAula(int id, string hora, string dia,string materia,string profesor)
        {
            InitializeComponent();
            CBHora.Texts = hora;
            CBDia.Texts = dia;
            
            CBPRofesor.Texts=profesor;
            id_aula = id;
            LogicaReserva.CBMateriasListar(CBMateria);
            CBMateria.Texts = materia;
            fecha.Visible = false;
            editar.Visible=true;
            BReservarAula.Visible=false;
        }
        public ReservarAula()
        {
            InitializeComponent();
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            //discriminar a usuarios con if cuando se pueda
            this.Hide();
             VerReservas reservas = new VerReservas(id_aula);
            reservas.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) ||       string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {
               
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string estado;
                if(Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile ==3)
                {
                    estado = "SI";
                }
                else
                {
                    estado = "NO";
                }
                LogicaReserva.insertarReserva(id_aula,this.CBHora.Texts,this.CBMateria.Texts,this.CBPRofesor.Texts,this.CBDia.Texts,fecha_desde.Value.Date,fecha_hasta.Value.Date,estado);
                MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            LogicaReserva.CBMateriasListar(CBMateria);
            if (Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile==3)
            {
                LogicaReserva.CBPRofesorListar(CBPRofesor);
            }
            else
            {
                CBPRofesor.Texts = Session.SessionCacheData.Name;
            }
            
            List<rango> listaAlumnos = new List<rango>
            {
                new rango { Id = 1, Periodo = "Primer Cuatrimestre" },
                new rango { Id = 2, Periodo = "Segundo Cuatrimestre" },
                new rango { Id = 3, Periodo = "Dia Puntual" },
                new rango { Id = 4, Periodo = "Personalizado" }
            };

            Periodo.DataSource = listaAlumnos;

            Periodo.DisplayMember = "Periodo";
            
            Periodo.ValueMember = "Id";
        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.Periodo.Texts.ToString())
            {

                case "Primer Cuatrimestre":
                    fecha_desde.Value = new DateTime(2023, 3, 10);
                    fecha_hasta.Value = new DateTime(2023, 6, 15);
                    fecha_desde.Visible =false;
                    fecha_hasta.Visible = false;
                    break;
                case "Segundo Cuatrimestre":
                    fecha_hasta.Visible = false;
                    fecha_desde.Visible =false;
                    fecha_desde.Value = new DateTime(2023, 7, 10);
                    fecha_hasta.Value = new DateTime(2023, 11, 20);
                    break;
                case "Dia Puntual":
                    fecha.Visible = true;
                    fecha_desde.Visible = true; 
                    fecha_hasta.Visible = false;
                    fecha_desde.Value = fecha_hasta.Value;
                    break;
                default:
                    fecha_desde.Visible = true;
                    fecha_hasta.Visible = true;

                    break;
            }

        }

        private void CBPRofesor_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // intento fallido de editar aula 
        private void editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) || string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {

                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                var reservaid=LogicaReserva.reservaVacia(this.CBDia.Texts, this.CBHora.Texts, id_aula);
      
                LogicaReserva.actualizarReserva(reservaid.id_reserva, this.CBHora.Texts, this.CBMateria.Texts, this.CBPRofesor.Texts, this.CBDia.Texts, fecha_desde.Value.Date, fecha_hasta.Value.Date);
                MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

    public class rango
    {
        public int Id { get; set; }
        public string Periodo { get; set; }

       
    }
}
