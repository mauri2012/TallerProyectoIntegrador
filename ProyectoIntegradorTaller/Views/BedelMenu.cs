using ProyectoIntegradorTaller.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.formularios
{
    public partial class BedelMenu : Form
    {
        public BedelMenu()
        {

            InitializeComponent();
            List<ItemProfesor> staticData = new List<ItemProfesor>()
            {

                new ItemProfesor {Id=1, Name= "Aula 5",Lugar="9 de julio", CapacidadMax=40},
                new ItemProfesor{Id=2, Name= "Aula Magna",Lugar = "libertad",CapacidadMax=100},
            };
            dataGridView1.DataSource = staticData;
        }


   

        private void BMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BMaximizar.Visible = false;
            BRestaurar.Visible = true;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BMaximizar.Visible = true;
            BRestaurar.Visible = false;
        }

        private void BEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    
        private void BedelMenu_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Eliminar"; // Name the column
            buttonColumn1.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn1.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "Reserva"; // Name the column
            buttonColumn2.Text = "Reservas";    // Text for buttons in the column
            buttonColumn2.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.Name = "Reservar"; // Name the column
            buttonColumn3.Text = "Reservar";    // Text for buttons in the column
            buttonColumn3.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            dataGridView1.Columns.Add(buttonColumn1);
            dataGridView1.Columns.Add(buttonColumn2);
            dataGridView1.Columns.Add(buttonColumn3);


        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
    
                if (column is DataGridViewButtonColumn && column.Name == "Reservar")
                {
                    DataGridViewButtonCell buttonCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    buttonCell.Style.BackColor = Color.Green;
                    //buttonCell.Style.ForeColor = Color.White;

                }
            }
        }

        private void BReservarAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservarAula reserva =new ReservarAula();
            reserva.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reserva")
                {
                    Reservas unaReserva = new Reservas();
                    unaReserva.Show();

                }else if(dataGridView1.Columns[e.ColumnIndex].Name == "Reservar")
                {
                    ReservarAula unaReserva = new ReservarAula();
                    unaReserva.Show();
                }
            }
        }

      
    }
    public class ItemProfesor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lugar { get; set; }
        public int CapacidadMax { get; set; }


    }
}
