using DraggingControl;
using Microsoft.VisualBasic;
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

        private void BLogOut_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere deslogearse?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == MsgBoxResult.Yes)
            {
                this.Close();
                LogIn log = new LogIn();
                log.Show();
            }
        }
    }
}
