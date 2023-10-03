using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class AdminMenu : FormPersonalisado
    {
        public AdminMenu()
        {

            InitializeComponent();
 

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reservas")
                {
                    this.Hide();
                    VerReservas reservas = new VerReservas((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    reservas.Show();

                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Informe")
                {
                    this.Hide();
                    Reporte unReporte = new Reporte();
                    unReporte.Show();
                    
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.Hide();

                    CrearAula aula = new CrearAula((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[1].Value, (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value, (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    
                    aula.Show();
                    
                }
                else if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar el "+ (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ask == MsgBoxResult.Yes)
                    {
                        LogicaClase.aulaActiva("NO", dataGridView1, e);
                    }
                    
                }
            }
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Reservas"; // Name the column
            buttonColumn1.Text = "Ver Reservas";    // Text for buttons in the column
            buttonColumn1.UseColumnTextForButtonValue = true; // Display the Text value on buttons




            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "Informe"; // Name the column
            buttonColumn2.Text = "Nuevo Informe";    // Text for buttons in the column
            buttonColumn2.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            
            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.Name = "Editar"; // Name the column
            buttonColumn3.Text = "Editar";    // Text for buttons in the column
            buttonColumn3.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            
            dataGridView1.Columns.Add(buttonColumn1);
            dataGridView1.Columns.Add(buttonColumn2);
            dataGridView1.Columns.Add(buttonColumn3);
            dataGridView1.Columns.Add(buttonColumn4);



            try
            {

                LogicaClase.listarAula(dataGridView1);   
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

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn && column.Name == "Reservar")
                {
                    DataGridViewButtonCell buttonCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    buttonCell.Style.BackColor = Color.Green;
                    //buttonCell.Style.ForeColor = Color.White;

                }
            }
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearAula aula=new CrearAula();
            aula.Show();
        }

        private void BLugares_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lugares lugares=new Lugares();  
            lugares.Show();
        }

        private void BMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.Show();
        }

        private void utils2_Load(object sender, EventArgs e) { 
        
        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }


        
        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {
            this.Close();
            Datos misDatos = new Datos();
            misDatos.Show();
        }

        private void itemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                LogicaClase.listarAula(dataGridView1);
            }
            else
            {
                
                LogicaClase.busquedaAula(this.TBBusqueda.Texts,dataGridView1);
            }
              
       
        }
    }

}
