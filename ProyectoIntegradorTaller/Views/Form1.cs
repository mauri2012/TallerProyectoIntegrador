using ProyectoIntegrador.formularios;
using ProyectoIntegradorTaller.formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller    
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point originalMousePos;
        private Point originalFormPos;
        public Form1()
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
            if (string.IsNullOrEmpty(this.TEmail.Texts) || string.IsNullOrEmpty(TPass.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BedelMenu menu = new BedelMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                originalMousePos = Control.MousePosition;
                originalFormPos = Location;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Control.MousePosition, new Size(originalMousePos));
                Location = Point.Add(originalFormPos, new Size(delta));
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                originalMousePos = Control.MousePosition;
                originalFormPos = Location;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}