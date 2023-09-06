﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.formularios
{
    public partial class Reservas : Form
    {
        public Reservas()
        {

            InitializeComponent();
            List<ItemReservas> staticData = new List<ItemReservas>()
            {

                new ItemReservas{Hora="14:00-18:00",Desde="14/8/23",Hasta="7/11/23",Materias="Ingeneria del Software",Profesor="Apellido Nombre" },
                 new ItemReservas{Hora="14:00-18:00",Desde="14/8/23",Hasta="7/11/23",Materias="Ingeneria del Software",Profesor="Apellido Nombre" },
            };
            dataGridView1.DataSource = staticData;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BMaximizar.Visible = false;
            BRestaurar.Visible = true;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BMaximizar.Visible = true;
            BRestaurar.Visible = false;
        }

        private void BEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
               
                // Verificar si el clic ocurrió en la columna "Reservar"
          
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    EditarAula aula = new EditarAula((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[1].Value, (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value, (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    aula.Show();
                    
                }
            }
        }
        private void Reservas_Load(object sender, EventArgs e)
        {

           
            
            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.Name = "Editar"; // Name the column
            buttonColumn3.Text = "Editar";    // Text for buttons in the column
            buttonColumn3.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons

     
            dataGridView1.Columns.Add(buttonColumn3);
            dataGridView1.Columns.Add(buttonColumn4);

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

     
    }
    public class ItemReservas
    {
        public string Hora { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Materias { get; set; }
        public string Profesor { get; set; }
    }
}
