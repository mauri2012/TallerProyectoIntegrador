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

namespace ProyectoIntegradorTaller.views
{
    public partial class VerReservas : DraggablePanelUserControl
    {
        public VerReservas()
        {
            InitializeComponent();
            RellenarHorarios();
        }

        void RellenarHorarios()
        {
            for (int i = 8; i < 22; i+=2)
            {
                DGHorarios.Rows.Add( i+":00-"+(i+2)+":00","","","","","","");
            }
        }
    }
}
