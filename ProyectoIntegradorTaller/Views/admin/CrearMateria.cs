using ProyectoIntegrador.formularios;
using ProyectoIntegradorTaller.formularios;
using System;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller    
{
    public partial class CrearMateria : Form
    {
        public CrearMateria(string materia)
        {
            InitializeComponent();
            TMateria.Texts = materia;
        }
        public CrearMateria()
        {
            InitializeComponent();
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
        private void BInicioSesion_Click(object sender, EventArgs e)
        {

           
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(this.TMateria.Texts) )
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}