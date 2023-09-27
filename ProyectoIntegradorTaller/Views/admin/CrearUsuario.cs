using DraggingControl;
using ProyectoIntegradorTaller.logica;
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
        public int id_;
        public bool isEdit;
        public CrearUsuario()
        {
            InitializeComponent();
        }
        public CrearUsuario(string nombre,string apellido,string mail, int dni,int tipo,int id )
        {
            InitializeComponent();
            this.TNombre.Texts= nombre;
            this.TApellido.Texts= apellido;
            this.TEmail.Texts= mail;
            this.TDni.Texts = dni.ToString();
            this.CBTipo.ValueMember = tipo.ToString();
            isEdit= true;
            id_ = id;
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
                        int tipoU = 1;
                        if (this.CBTipo.Texts=="bedel")
                        {
                            tipoU = 3;
                        }
                        if (!isEdit)
                        {
                            UsuarioLogica.agregar(int.Parse(TDni.Texts),this.TApellido.Texts, this.TEmail.Texts, this.TNombre.Texts,tipoU);


                        }
                        else
                        {
                            UsuarioLogica.update(id_,int.Parse(TDni.Texts), this.TApellido.Texts, this.TEmail.Texts, this.TNombre.Texts, tipoU);
                        }
                    this.TDni.Texts = this.TApellido.Texts = this.TEmail.Texts = this.TNombre.Texts = " ";
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

