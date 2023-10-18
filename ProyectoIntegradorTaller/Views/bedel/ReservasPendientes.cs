using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.admin;
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

namespace ProyectoIntegradorTaller.views.admin

{
    public partial class ReservasPendientes : FormPersonalisado
    {
        public ReservasPendientes()
        {
            InitializeComponent();
            dataGridView1.DataSource= LogicaReserva.ListarReservas("NO");
            dataGridView1.Columns[0].Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Estado")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere autorizar la reserva en el  " + (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value + "  ?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    int idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    LogicaReserva.ReservaActiva("SI", idUsuario);
                    dataGridView1.DataSource= LogicaReserva.ListarReservas("NO");
                }

            }
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            BedelMenu bedel = new BedelMenu();
            bedel.Show();
        }
    }
}
