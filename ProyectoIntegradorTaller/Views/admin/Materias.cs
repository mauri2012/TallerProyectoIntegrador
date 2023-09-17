﻿using DraggingControl;
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
    public partial class Materias : DraggablePanelUserControl
    {
        public Materias()
        {

            InitializeComponent();
            List<ItemMaterias> staticData = new List<ItemMaterias>()
            {

                new ItemMaterias{Materia="Taller de Programacion 1" },
                 new ItemMaterias{Materia="Ingeneria del Software 1" },
            };
            dataGridView1.DataSource = staticData;
           
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons

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
                    

                }
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
            
                
            }
            else
            {
                MessageBox.Show("El campo esta vacio!");
            }

        }
    }
    public class ItemMaterias
    {
     
        public string Materia { get; set; }
    
    }
}
