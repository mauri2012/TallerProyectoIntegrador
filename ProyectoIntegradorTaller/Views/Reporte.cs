using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Drawing.Printing;
using System.Drawing;

namespace ProyectoIntegradorTaller.views.admin
{
   
    public partial class Reporte : FormPersonalisado
    {
        public int id_aula;
        private Bitmap memoryImage;

        public Reporte(int id)
        {
            InitializeComponent();
            id_aula = id;
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            ReporteLogica.diasListar(chart1,id_aula);
            ReporteLogica.materiasListar(chart2, id_aula);
            ReporteLogica.horasListar(chart3, id_aula);

        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeAdmin homeAdmin = new homeAdmin();
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
        }
    }
    public class HorarioList
    {
            public string campo { set; get; }
            public string aula { set; get; }
            public int cantcampo { set; get; }
    }
}
