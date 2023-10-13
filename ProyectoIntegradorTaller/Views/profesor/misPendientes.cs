using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;

namespace ProyectoIntegradorTaller.views.profesor
{
    public partial class misPendientes : FormPersonalisado
    {
        public misPendientes()
        {
            InitializeComponent();
            
            dataGridView1.DataSource= LogicaReserva.ListarReservas("NO",Session.SessionCacheData.Id);
            dataGridView1.Columns[0].Visible = false;
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }
    }
}
