﻿using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
//using ProyectoIntegradorTaller.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class BedelMenu : FormPersonalisado
    {
        public BedelMenu()
        {

            InitializeComponent();
            LogicaClase.listarAula(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reserva")
                {
                    this.Hide();
                    VerReservas reservas = new VerReservas((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    //VerReservas reservas = new VerReservas();
                    reservas.Show();

                }
            }
        }



        private void BedelMenu_Load(object sender, EventArgs e)
        {
        
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "Reserva"; // Name the column
            buttonColumn2.Text = "Ver Reservas";    // Text for buttons in the column
            buttonColumn2.UseColumnTextForButtonValue = true; // Display the Text value on buttons
 
            dataGridView1.Columns.Add(buttonColumn2);


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

        

        private void BMaterias_Click(object sender, EventArgs e)
        {
            this.Close();
            Materias materias = new Materias();
            materias.Show();
        }

        private void BProfesores_Click(object sender, EventArgs e)
        {
            this.Close();
            Profesores profesores=new Profesores();
            profesores.Show();
        }

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {
            this.Close();
            Datos datos = new Datos();
            datos.Show();
        }

        private void BPendientes_Click(object sender, EventArgs e)
        {
            this.Close();
            ReservasPendientes reservasPendientes = new ReservasPendientes();
            reservasPendientes.Show();
        }

        private void BDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministracionDatabase admin = new AdministracionDatabase();
            admin.Show();
        }
    }
    public class ItemProfesor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lugar { get; set; }
        public int CapacidadMax { get; set; }


    }
}
