using DraggingControl;
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

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class ReservarAula : DraggablePanelUserControl
    {
        
       
        public ReservarAula(string hora, string dia)
        {
            InitializeComponent();
            CBHora.Texts = hora;
            CBDia.Texts = dia;

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
        private void LoadReservarAula1(object sender,EventArgs e)
        {
            List<diasSemana> items = new List<diasSemana>();
            items.Add(new diasSemana() { value = "lunes", text = "Lunes" });
            items.Add(new diasSemana() { value = "martes", text = "Martes" });
            items.Add(new diasSemana() { value = "miercoles", text = "Miercoles" });
            items.Add(new diasSemana() { value = "jueves", text = "Jueves" });
            items.Add(new diasSemana() { value = "viernes", text = "Viernes" });
            items.Add(new diasSemana() { value = "sabado", text = "Sabado" });
            items.Add(new diasSemana() { value = "domingo", text = "Domingo" });
            CBDia.DataSource = items;
            CBDia.DisplayMember = "text";
            CBDia.ValueMember = "value";
        }

       

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            //discriminar a usuarios con if cuando se pueda
            this.Hide();
             VerReservas reservas = new VerReservas();
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
            
        }
    }

    class diasSemana
        {
            public diasSemana() { }
            public string value { set; get; }
            public string text { set; get; }

        }
    
}
