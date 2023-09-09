﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.formularios
{
    public partial class ReservarAula : Form
    {
        public ReservarAula()
        {
            InitializeComponent();
            List<diasSemana> items = new List<diasSemana>();
            items.Add(new diasSemana() { value = "lunes", text = "Lunes" });
            items.Add(new diasSemana() { value = "martes", text = "Martes" });
            items.Add(new diasSemana() { value = "miercoles", text = "Miercoles" });
            items.Add(new diasSemana() { value = "jueves", text = "Jueves" });
            items.Add(new diasSemana() { value = "viernes", text = "Viernes" });
            items.Add(new diasSemana() { value = "sabado", text = "Sabado" });
            items.Add(new diasSemana() { value = "domingo", text = "Domingo" });
            CBDias.DataSource = items;
            CBDias.DisplayMember = "text";
            CBDias.ValueMember = "value";


        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

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
            //Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

        class diasSemana
        {
            public diasSemana() { }
            public string value { set; get; }
            public string text { set; get; }

        }
    
}
