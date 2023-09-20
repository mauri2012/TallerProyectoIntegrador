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
    public partial class Datos :DraggablePanelUserControl
    {
        private string isAdmin;
        public Datos()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            if (isAdmin=="admin")
            {
                AdminMenu menu=new AdminMenu();
                menu.Show();
            }
            else
            {
                BedelMenu menu = new BedelMenu();
                menu.Show();
            }
           
            
        }
    }
}
