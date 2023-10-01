using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Materias : FormPersonalisado
    {
        public Materias()
        {

            InitializeComponent();
  
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            
            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            dataGridView1.Columns.Add(buttonColumn4);
            try
            {

                using (classroom_managerEntities db = new classroom_managerEntities())
                {

                    dataGridView1.DataSource = db.materias.ToList();

                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearAula aula=new CrearAula();
            aula.Show();
        }

        

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin=new AdminMenu();
            admin.Show();
        }

       

        private void BAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TMateria.Texts))
            {
                materias sub = new materias { 
                        materia = TMateria.Texts
                    };
                using (classroom_managerEntities db = new classroom_managerEntities())
                {
                    db.materias.Add(sub);
                    db.SaveChanges();
                    MessageBox.Show("materia ingresada correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TMateria.Texts  = " ";
                }

            }
            else
            {
                MessageBox.Show("El campo esta vacio!");
            }

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            MateriasLogica.busqueda(TBBusqueda.Texts, dataGridView1);
        }
    }
  
}
