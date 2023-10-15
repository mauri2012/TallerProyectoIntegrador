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
        private reserva res;
        

        public ReservarAula(int idAula,int idHora, int idDia)
        {
            InitializeComponent();
            CBHora.Texts = LogicaReserva.ObtenerHorarioPorID(idHora).horario;
            CBDia.Texts = LogicaReserva.ObtenerDiaPorID(idDia).dias;
            id_aula = idAula;
            LogicaReserva.CBMateriasListar(CBMateria);
            fecha.Visible = false;
            BEliminar.Visible = false;
            this.BReservarAula.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            this.BImprimir.Visible= false; 
        }



        //Editar aula
        public ReservarAula(reserva reserva1)
        {
            InitializeComponent();
            CBHora.Texts = LogicaReserva.ObtenerHorarioPorID(reserva1.id_hora).horario;
            CBDia.Texts = LogicaReserva.ObtenerDiaPorID(reserva1.id_dia).dias;
            CBPRofesor.Texts=LogicaUsuarios.getUsuario(reserva1.id_usuario).nombre;

            id_aula = reserva1.id_aula;
            res= reserva1;
            LogicaReserva.CBMateriasListar(CBMateria);
            //Cambiar el ?? 1 cuando se resuelva el problema de nulos
            CBMateria.Texts = LogicaMaterias.getMateria(reserva1.id_materia ?? 1).materia;
            fecha.Visible = false;
           // CBMateria.SelectedIndex =reserva1.id_materia.Value;
            BReservarAula.Text = "Editar Aula";
            BReservarAula.Click += new System.EventHandler(this.editar_Click);
        }

        
        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VerReservas reservas = new VerReservas(id_aula);
            reservas.Show();
           
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
                LogicaReserva.InsertarReserva(id_aula,this.CBHora.Texts,this.CBMateria.Texts,this.CBPRofesor.Texts,this.CBDia.Texts,fecha_desde.Value.Date,fecha_hasta.Value.Date,estado);
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
            
            List<rango> listaPeriodo = new List<rango>
            {
                new rango { Id = 1, Periodo = "Primer Cuatrimestre" },
                new rango { Id = 2, Periodo = "Segundo Cuatrimestre" },
                new rango { Id = 3, Periodo = "Dia Puntual" },
                new rango { Id = 4, Periodo = "Personalizado" }
            };

            Periodo.DataSource = listaPeriodo;

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

        
        // Editar Aula
        private void editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) || string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {

                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                LogicaReserva.EditarReserva(res.id_reserva, res.id_hora, CBMateria.Texts, CBPRofesor.Texts, res.id_dia, fecha_desde.Value.Date, fecha_hasta.Value.Date, "SI");
                MessageBox.Show("Se edito con exito la reserva!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            LogicaReserva.EliminarReserva(res.id_reserva);
            this.Hide();
            VerReservas reservas = new VerReservas(id_aula);
            reservas.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void fecha_desde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fecha_hasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            LogicaReserva.ImprimirComprobante(res.id_reserva);
        }
    }

    public class rango
    {
        public int Id { get; set; }
        public string Periodo { get; set; }

       
    }
}
