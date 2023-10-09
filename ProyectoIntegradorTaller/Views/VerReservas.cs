using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoIntegradorTaller.views
{
    public partial class VerReservas : FormPersonalisado
    {

        private int id_aula;
        private string materia;
        private string nom_profesor;
        public VerReservas()
        {
            InitializeComponent();
            RellenarHorarios();
        }
        public VerReservas(int id)
        {

            id_aula = id;
            
            InitializeComponent();
        }

        void RellenarHorarios()
        {
            for (int i = 8; i < 22; i += 2)
            {
                DGHorarios.Rows.Add(i + ":00-" + (i + 2) + ":00");
            }
        }
        private void Reservas_load(object sender, EventArgs e)
        {
            LogicaReserva.MostrarGrilla(id_aula, DGHorarios);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1) // Asegúrate de que se hizo clic dentro de una celda válida
            {
                int idDia = e.ColumnIndex; // Obtén el indice de la columna
                int idHora = e.RowIndex + 1; // obten el indice de la fila, sumamos uno para corregir el indice
                
                SeleccionarReserva(idDia, idHora);
            }
        }

        private void SeleccionarReserva(int idDia, int idHora)
        {


            this.Hide();
            reserva reserva1 = LogicaReserva.BuscarReserva(idDia, idHora, id_aula);
            if (reserva1 == null)
            {
                ReservarAula reserva = new ReservarAula(id_aula, idHora, idDia);
                reserva.Show();
            }
            else
            {
                
                ReservarAula reserva = new ReservarAula(reserva1);
                reserva.Show();
            }
           
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            switch (Session.SessionCacheData.IdProfile)
            {

                case 1:
                   homeAdmin homeAdmin = new homeAdmin();
                    homeAdmin.Show();

                    break;
                case 3:
                    BedelMenu menuBedel = new BedelMenu();
                    menuBedel.Show();

                    break;
                default:
                    HomeProfesor homeProfesor = new HomeProfesor();
                    homeProfesor.Show();

                    break;

            }
            this.Hide();

        }
    }
}
