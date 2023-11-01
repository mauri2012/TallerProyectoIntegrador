using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;
using System.Collections.Generic;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class ReservarAula : DraggablePanelUserControl
    {

        private int id_aula;
        private reserva res;
        

        public ReservarAula(int idAula,int idHora, int idDia,string nombre)
        {
            InitializeComponent();
            CBHora.Texts = LogicaReserva.ObtenerHorarioPorID(idHora).horario;
            CBDia.Texts = LogicaReserva.ObtenerDiaPorID(idDia).dias;
            Periodo.Texts = nombre;
            id_aula = idAula;
            
            CBMateria.DataSource = LogicaReserva.CBMateriasListar();
            CBMateria.DisplayMember = "materia";
            CBMateria.ValueMember = "id_materia";

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
            Periodo.Texts = LogicaReserva.obtenerPeriodoPorId(reserva1.id_periodo ?? 1).periodo_nombre;
            id_aula = reserva1.id_aula;
            res= reserva1;

            CBMateria.DataSource=LogicaReserva.CBMateriasListar();
            CBMateria.DisplayMember = "materia";
            CBMateria.ValueMember = "id_materia";


            //Cambiar el ?? 1 cuando se resuelva el problema de nulos
            CBMateria.Texts = LogicaMaterias.getMateria(reserva1.id_materia ?? 1).materia;
            fecha.Visible = false;
           // CBMateria.SelectedIndex =reserva1.id_materia.Value;
            BReservarAula.Text = "Editar Aula";
            BReservarAula.Click += new System.EventHandler(this.editar_Click);

            if (Session.SessionCacheData.IdProfile==4) {
                BEliminar.Visible = false;
                BReservarAula.Visible = false;
                BImprimir.Visible = false;
            }
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
                LogicaReserva.InsertarReserva(id_aula,this.CBHora.Texts,this.CBMateria.Texts,this.CBPRofesor.Texts,this.CBDia.Texts,this.Periodo.Texts,estado);
                MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            fecha_desde.Visible = false;
            fecha_hasta.Visible = false;
            CBMateria.DataSource = LogicaReserva.CBMateriasListar();
            CBMateria.DisplayMember = "materia";
            CBMateria.ValueMember = "id_materia";
            if (Session.SessionCacheData.IdProfile == 1 || Session.SessionCacheData.IdProfile==3)
            {
                CBPRofesor.DataSource= LogicaReserva.CBPRofesorListar();
                CBPRofesor.DisplayMember = "nombre";
                CBPRofesor.ValueMember = "id_usuario";
            }
            else
            {
                CBPRofesor.Texts = Session.SessionCacheData.Name;
            }
        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.Periodo.Texts.ToString())
            {

       
                case "Dia Puntual":
                    fecha.Visible = true;
                    fecha_desde.Visible = true; 
                    fecha_hasta.Visible = false;
                    fecha_desde.Value = fecha_hasta.Value;
                    break;
                case "Personalizado":
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

                LogicaReserva.EditarReserva(res.id_reserva, res.id_hora, CBMateria.Texts, CBPRofesor.Texts, res.id_dia, this.Periodo.Texts, "SI");
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

        

        private void BImprimir_Click(object sender, EventArgs e)
        {
            LogicaReserva.ImprimirComprobante(res.id_reserva);
        }
    }
}
