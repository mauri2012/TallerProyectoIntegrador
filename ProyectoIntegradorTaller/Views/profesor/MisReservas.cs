using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorTaller.views.components;

namespace ProyectoIntegradorTaller.views.profesor
{
    public partial class MisReservas : FormPersonalisado
    {
        public MisReservas()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeProfesor homeProfesor = new HomeProfesor();
            homeProfesor.Show();
        }
    }
}
