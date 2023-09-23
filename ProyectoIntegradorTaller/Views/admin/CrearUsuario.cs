using DraggingControl;
using ProyectoIntegradorTaller.models;
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

            
                if (string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(this.TApellido.Texts) || string.IsNullOrEmpty(this.TDni.Texts) || string.IsNullOrEmpty(this.TEmail.Texts) || string.IsNullOrEmpty(this.CBTipo.Texts))
                {
                    MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!IsValidEmail(this.TEmail.Texts))
                    {

                        MessageBox.Show("El correo electronico no es valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        usuario user = new usuario
                        {
                            dni = int.Parse(this.TDni.Texts),
                            nombre = this.TNombre.Texts,
                            apellido = this.TApellido.Texts,
                            correo = this.TEmail.Texts,
                            id_tipoUsuario = 1,
                        };
                        using (classroom_managerEntities db = new classroom_managerEntities())
                        {
                            db.usuario.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("se inserto el usuario correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    }
                }
            
          
        }

        public static bool IsValidEmail(string email)
        {
            // Define una expresión regular para validar direcciones de correo electrónico.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza Regex.IsMatch para verificar si la cadena coincide con el patrón.
            return Regex.IsMatch(email, pattern);
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo Capacidad solo acepta valores numericos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CBTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTipo_Load(object sender, EventArgs e)
        {
            tipoUsuario tuser =new  tipoUsuario();
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                CBTipo.DataSource = db.tipoUsuario.ToList();
                CBTipo.DisplayMember = "tipo"; // Specify the property to display in the ComboBox
                CBTipo.ValueMember = "id_tipoUsuario";
            }
               
        }
    }

}

