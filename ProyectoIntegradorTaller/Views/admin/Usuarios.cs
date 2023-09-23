//using ProyectoIntegradorTaller.formularios;
using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Usuarios : DraggablePanelUserControl
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void BCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();
              
        }
        SqlConnection connection = new SqlConnection("");
        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            try
            {

                using (classroom_managerEntities db = new classroom_managerEntities())
                {
                 
                    dataGridView1.Columns["Nombre"].DataPropertyName = "nombre";
                    dataGridView1.Columns["Apellido"].DataPropertyName = "apellido";
                    dataGridView1.Columns["Email"].DataPropertyName = "correo";
                    dataGridView1.Columns["Tipo"].DataPropertyName = "id_tipoUsuario";
                    dataGridView1.DataSource = db.usuario.ToList();
                    dataGridView1.Columns["reserva"].Visible = false;
                    dataGridView1.Columns["tipoUsuario"].Visible=false;
                    
                    
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }
    }
}