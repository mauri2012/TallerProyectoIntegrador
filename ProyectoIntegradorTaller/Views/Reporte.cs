using DraggingControl;
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
    public partial class Reporte : FormPersonalisado
    {
        public Reporte()
        {
            InitializeComponent();
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {

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
    }
}
