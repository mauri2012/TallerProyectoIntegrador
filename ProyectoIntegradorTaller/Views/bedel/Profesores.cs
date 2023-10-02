using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using ProyectoIntegradorTaller.views.profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Profesores : FormPersonalisado
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            UsuarioLogica.ListarUsuariosPorId(4, dataGridView1);
        }

        private void BVolver_Click(object sender, EventArgs e)
        {

            BedelMenu menuBedel = new BedelMenu();
            menuBedel.Show();
            this.Hide();
        }

        private void BCrearProfesor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearProfesor crearProfesor = new CrearProfesor();
            crearProfesor.Show();
        }
    }
}
