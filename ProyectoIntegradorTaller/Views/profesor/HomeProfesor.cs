﻿using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.admin;
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

namespace ProyectoIntegradorTaller.views.profesor
{
    public partial class HomeProfesor : FormPersonalisado
    {
        public HomeProfesor()
        {
            InitializeComponent();
            dataGridView1.DataSource = LogicaClase.listarAula();
            dataGridView1.Columns[0].Visible=false;
        }

        private void botonPersonalisado3_Click(object sender, EventArgs e)
        {
            this.Hide();
            misPendientes complementos = new misPendientes();
            complementos.Show();
        }

        private void botonPersonalisado4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MisReservas misReservas = new MisReservas();
            misReservas.Show();
        }

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos misDatos = new Datos();
            misDatos.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Reservas")
            {
                this.Hide();
                VerReservas reservas = new VerReservas((int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                reservas.Show();

            }
        }
    }
}
