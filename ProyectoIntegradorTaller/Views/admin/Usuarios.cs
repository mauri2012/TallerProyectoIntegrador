//using ProyectoIntegradorTaller.formularios;
using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;

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

                UsuarioLogica.listarUsuarios(RBActivo,dataGridView1);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if(dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        this.Hide();
                    int tipo = 1;
                    if ((string)dataGridView1.Rows[e.RowIndex].Cells["Tipo"].Value == "bedel")
                    {
                        tipo = 3;
                    }
                   // MessageBox.Show((string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value);
                        CrearUsuario usuario = new CrearUsuario((string)dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells["Email"].Value,
                        (int)dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value,
                        tipo, 
                        (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                        usuario.Show();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Desactivar")
                {
                    string valorCelda = dataGridView1.Rows[e.RowIndex].Cells["Activo"].Value.ToString();

                    if (valorCelda == "NO")
                    {



                        UsuarioLogica.UsuarioActivo("SI", this.dataGridView1, e);
                    }
                    else
                    {
                        UsuarioLogica.UsuarioActivo("NO", this.dataGridView1, e);
                    }

                    UsuarioLogica.listarUsuarios(RBActivo, dataGridView1);
                }
                }
            
        }

        private void RBDesactivados_CheckedChanged(object sender, EventArgs e)
        {
            UsuarioLogica.listarUsuarios(RBActivo,dataGridView1);
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            UsuarioLogica.busqueda(this.rjTextBox1.Texts,dataGridView1);
        }
    }
}