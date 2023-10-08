using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;

namespace ProyectoIntegradorTaller.views.admin
{
   
    public partial class Reporte : FormPersonalisado
    {
        public int id_aula;
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
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
    public class HorarioList
    {
            public string campo { set; get; }
            public string aula { set; get; }
            public int cantcampo { set; get; }
    }
}
