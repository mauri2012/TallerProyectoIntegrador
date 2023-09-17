using DraggingControl;
using ProyectoIntegradorTaller.views.admin;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegúrate de que se hizo clic dentro de una celda válida
            {
                string dia = DGHorarios.Columns[e.ColumnIndex].Name; // Obtén el nombre de la columna
                string hora = DGHorarios.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtén el primer elemento de la fila

                // Llama a la función que necesita el nombre de la columna y el primer elemento de la fila
                SeleccionarReserva(dia, hora);
            }
        }

        private void SeleccionarReserva(string dia, string hora)
        {
            Console.WriteLine("Dia: " + dia);
            Console.WriteLine("Hora: " + hora);

            this.Hide();
            ReservarAula reserva = new ReservarAula();
            reserva.Show();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }
    }
}
