﻿using DraggingControl;
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
        }

        private void botonPersonalisado3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complementos complementos = new Complementos();
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
    }
}