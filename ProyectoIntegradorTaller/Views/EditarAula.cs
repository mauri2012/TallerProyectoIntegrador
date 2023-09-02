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

namespace ProyectoIntegradorTaller.formularios
{
    public partial class EditarAula : Form
    {
        public int id;
        public string name;
        public string lugar;
        public int capacidad;
        public string tipo;
        public EditarAula(int Id, String Name, String Lugar, int CapacidadMax,String Tipo)
        {
            id = Id;
            name = Name;
            lugar = Lugar;
            capacidad = CapacidadMax;
            tipo= Tipo;
            InitializeComponent();
        }
        private void LoadEditarAula(object sender, EventArgs e)
        {
            TNombre.Text = name;
            CBUbicacion.Text = lugar.ToString();
            CBTipo.Text=tipo.ToString();
            TCapacidad.Text = capacidad.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BMaximizar.Visible = false;
            BRestaurar.Visible = true;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BMaximizar.Visible = true;
            BRestaurar.Visible = false;
        }

        private void BEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {

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

       
    }
}
