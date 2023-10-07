using DraggingControl;
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
            reservaLogica.mostrarGrilla(id_aula, DGHorarios);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1) // Asegúrate de que se hizo clic dentro de una celda válida
            {
                string dia = DGHorarios.Columns[e.ColumnIndex].Name; // Obtén el nombre de la columna
                string hora = DGHorarios.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtén el primer elemento de la fila
                
                SeleccionarReserva(dia, hora);
            }
        }

        private void SeleccionarReserva(string dia, string hora)
        {
            this.Hide();
            var reservaQuery = reservaLogica.reservaVacia(dia, hora, id_aula);
            if (reservaQuery == null)
            {
                ReservarAula reserva = new ReservarAula(id_aula, hora, dia);
                reserva.Show();
            }
            else
            {
                
                ReservarAula reserva = new ReservarAula(id_aula, hora, dia,reservaLogica.GetMateria((int)reservaQuery.id_materia),reservaLogica.GetUsuario((int)reservaQuery.id_usuario));
                reserva.Show();
            }
           // reserva.Show();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            switch (Session.SessionCacheData.IdProfile)
            {

                case 1:
                    AdminMenu menuAdmin = new AdminMenu();

                    menuAdmin.Show();

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
