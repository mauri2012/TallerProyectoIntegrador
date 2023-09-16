using DraggingControl;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProyectoIntegradorTaller.views.admin
{
    public partial class CrearAula : DraggablePanelUserControl 
    {
        public CrearAula(int Id, string Name, String Lugar, int CapacidadMax, String Tipo)
        {
            InitializeComponent();
           // id.Text = Id;
            TNombre.Texts = Name;
            CBUbicacion.Texts = Lugar;
            TCapacidad.Texts = CapacidadMax.ToString();
            TTipo.Texts = Tipo;
            BEditarAula.Visible = true;
            BCrearAula.Visible = false;
        }
        public CrearAula()
        {
            InitializeComponent();
            BEditarAula.Visible = false;
            BCrearAula.Visible = true;
            
        }
  




        private void BCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número (0-9), retroceso o una tecla de control.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime la pulsación de tecla.
                e.Handled = true;
            }
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(CBUbicacion.Texts) || string.IsNullOrEmpty(TTipo.Texts) || string.IsNullOrEmpty(TCapacidad.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo Capacidad solo acepta valores numericos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void BVolver_Click(object sender, EventArgs e)
        {
            // cuando podamos discriminar usuarios aca va un if
            AdminMenu admin = new AdminMenu();
            admin.Show();
            this.Hide();
        }
    }
}
