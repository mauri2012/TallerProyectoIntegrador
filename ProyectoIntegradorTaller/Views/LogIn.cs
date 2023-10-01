using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.profesor;
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
            string password = this.TPass.Texts.Trim();
            string email = this.TEmail.Texts.Trim();

            if (Session.StartSession(email, password))
            {
                
                switch (Session.SessionCacheData.IdProfile)
                {

                    case 1:
                        AdminMenu menuAdmin = new AdminMenu();
                        isAdmin = TEmail.Texts;
                        menuAdmin.Show();
                        this.Hide();
                        break;
                    case 2:
                        BedelMenu menuBedel = new BedelMenu();
                        menuBedel.Show();
                        this.Hide();
                        break;
                    default:
                        HomeProfesor homeProfesor = new HomeProfesor();
                        homeProfesor.Show();
                        this.Hide();
                        break;

                }

            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
        }


        private void BInicioSesion_Click2(object sender, EventArgs e)
        {
            string password = this.TPass.Texts.Trim();
            string email = this.TEmail.Texts.Trim();

            if (Session.StartSession(email, password))
            {
                MessageBox.Show("sus usuario es_  "+ Session.SessionCacheData.IdProfile);
                switch (Session.SessionCacheData.IdProfile) {

                    case 1:
                        AdminMenu menuAdmin = new AdminMenu();
                        isAdmin = TEmail.Texts;
                        menuAdmin.Show();
                        this.Hide();
                        break;
                    case 3:
                        BedelMenu menuBedel = new BedelMenu();
                        menuBedel.Show();
                        this.Hide();
                        break;
                    default: 
                        HomeProfesor homeProfesor= new HomeProfesor();
                        homeProfesor.Show();
                        this.Hide();
                        break;
                
                }

            }
            else {
                MessageBox.Show("El usuario no existe");
            }
        }

        


       
    }
}