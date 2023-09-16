//using ProyectoIntegradorTaller.formularios;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

  
    }
}