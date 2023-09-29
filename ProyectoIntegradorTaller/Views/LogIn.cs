using DraggingControl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin    
{

    public partial class LogIn : DraggablePanelUserControl
    {
        public string isAdmin;

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

                if (this.TEmail.Texts == "admin")
                {
                    AdminMenu menu = new AdminMenu();
                    isAdmin = TEmail.Texts;
                    menu.Show();
                    this.Hide();
                }
                else {

                    BedelMenu menu = new BedelMenu();
                    menu.Show();
                    this.Hide();
                }
                
            }
        }

        


       
    }
}