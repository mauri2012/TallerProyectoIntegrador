﻿using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class menuAdmin : FormPersonalisado
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            
            try
            {

                dataGridView1.DataSource= LogicaClase.listarAula();
                DataGridViewColumn data = new DataGridViewTextBoxColumn();
    
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Columns[0].Visible = false;
            
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
                    Reporte unReporte = new Reporte((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    unReporte.Show();

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.Hide();

                    CrearAula aula = new CrearAula((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value,
                        (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[6].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[7].Value,
                        (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value);

                    aula.Show();

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar el " + (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ask == MsgBoxResult.Yes)
                    {
                        int idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                        LogicaClase.aulaActiva("NO",idUsuario);
                        dataGridView1.DataSource=LogicaClase.listarAula();
                    }

                }
            }
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearAula aula = new CrearAula();
            aula.Show();
        }

        private void BLugares_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lugares lugares = new Lugares();
            lugares.Show();
        }

        private void BMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.Show();
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


        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                dataGridView1.DataSource = LogicaClase.listarAula();
            }
            else
            {

                dataGridView1.DataSource= LogicaClase.busquedaAula(this.TBBusqueda.Texts);
            }


        }

        private void BBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                dataGridView1.DataSource=LogicaClase.listarAula();
            }
            else
            {

                dataGridView1.DataSource=LogicaClase.busquedaAula(this.TBBusqueda.Texts);
            }

        }

        private void BDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministracionDatabase admin = new AdministracionDatabase();
            admin.Show();
        }
    }
}
