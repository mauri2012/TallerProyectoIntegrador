using DraggingControl;
//using ProyectoIntegrador.formularios;
//using ProyectoIntegradorTaller.formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin    
{
    public partial class LogIn : DraggablePanelUserControl
    {
     
   
        public LogIn()
        {
            InitializeComponent();
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
                AdminMenu menu = new AdminMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



       
    }
}