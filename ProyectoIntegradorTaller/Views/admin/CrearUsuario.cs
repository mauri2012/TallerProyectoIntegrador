using DraggingControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class CrearUsuario : DraggablePanelUserControl
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios(); 
            usuarios.Show();
        }

        private void BInicioSesion_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(this.TEmail.Texts))
            {
                Console.WriteLine("La dirección de correo electrónico es válida.");
            }
            else
            {
                MessageBox.Show("El correo electronico no es valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            if (string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(this.TApellido.Texts) || string.IsNullOrEmpty(this.TDni.Text) || string.IsNullOrEmpty(this.TEmail.Texts) || string.IsNullOrEmpty(this.CBTipo.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                 

           
                


            }
        }

        public static bool IsValidEmail(string email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza Regex.IsMatch para verificar si la cadena coincide con el patrón.
            return Regex.IsMatch(email, pattern);
        }
    }

}

