﻿using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoIntegradorTaller.views.admin
{
   
    public partial class ImprimirReporte : FormPersonalisado
    {
        public int id_aula;
        private Bitmap memoryImage;
        public DateTime fecha_desde;
        public DateTime fecha_hasta;
        public ImprimirReporte(int id,DateTime fecha_d,DateTime fecha_h)
        {
            InitializeComponent();
            id_aula = id;
            fecha_desde = fecha_d;
            fecha_hasta= fecha_h;
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
        
            ReporteLogica.diasListar(chart1, id_aula, fecha_desde, fecha_hasta);
         
            ReporteLogica.materiasListar(chart2, id_aula, fecha_desde, fecha_hasta);
        
            ReporteLogica.horasListar(chart3, id_aula, fecha_desde, fecha_hasta);

            ReporteLogica.profesorListar(chart4, id_aula, fecha_desde, fecha_hasta);

            PBEsconder_.Location = new Point(732, 11);
            PBMaximizar_.Location = new Point(752,11);
            PBCerrar_.Location = new Point(775, 11);



        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAdmin homeAdmin = new menuAdmin();
            homeAdmin.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();


        }
        private void PrintDocument1_PrintPage(System.Object sender,
      System.Drawing.Printing.PrintPageEventArgs e) =>
          e.Graphics.DrawImage(memoryImage, 0, 0);


        private void chart3_Click(object sender, EventArgs e)
        {
          
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(memoryImage, 0, 0);

            this.Hide();
            Reporte unrepo = new Reporte(id_aula);
            unrepo.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPersonalisado1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
   

        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
 
}
