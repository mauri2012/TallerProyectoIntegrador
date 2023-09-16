using DraggingControl;
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
    public partial class CrearProfesor : DraggablePanelUserControl
    {
        public CrearProfesor()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores profesores= new Profesores();
            profesores.Show();
            //admin.;
        }

        private void BInicioSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
