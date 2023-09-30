using DraggingControl;
using ProyectoIntegradorTaller.views.admin;
using ProyectoIntegradorTaller.views.components;
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
    public partial class VerReservas : FormPersonalisado
    {
        private string isAdmin { get; set; }
        private int id_aula;

        public VerReservas()
        {
            InitializeComponent();
            RellenarHorarios();
        }
        public VerReservas(int id,string isAdmin)
        {
            this.isAdmin=isAdmin;
            id_aula=id;
            InitializeComponent();
            RellenarHorarios();
        }

        void RellenarHorarios()
        {
            for (int i = 8; i < 22; i+=2)
            {
                DGHorarios.Rows.Add( i+":00-"+(i+2)+":00");
            }
        }
        private void Reservas_load(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 1 && e.ColumnIndex >= 1) // Asegúrate de que se hizo clic dentro de una celda válida
            {
                string dia = DGHorarios.Columns[e.ColumnIndex].Name; // Obtén el nombre de la columna
                string hora = DGHorarios.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtén el primer elemento de la fila
              // int id = DGHorarios.Rows[e.RowIndex].Cells[0].Value;
                // Llama a la función que necesita el nombre de la columna y el primer elemento de la fila
               SeleccionarReserva(dia, hora);
            }
        }

        private void SeleccionarReserva(string dia, string hora)
        {
            this.Hide();
            ReservarAula reserva = new ReservarAula(id_aula,hora,dia);
            reserva.Show();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            if (this.isAdmin == "admin")
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else { 
                BedelMenu bedelMenu = new BedelMenu();
                bedelMenu.Show();
            }
            this.Hide();
            
        }
    }
}
