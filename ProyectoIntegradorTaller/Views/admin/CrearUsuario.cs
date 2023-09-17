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
    public partial class CrearUsuario : DraggablePanelUserControl
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios(); 
            usuarios.Show();
        }
    }
}
