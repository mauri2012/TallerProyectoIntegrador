using DraggingControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class AdminMenu : DraggablePanelUserControl
    {
        public AdminMenu()
        {

            InitializeComponent();
            List<Item> staticData = new List<Item>()
            {

                new Item{Id=1, Name= "Aula 5",Lugar="9 de julio", CapacidadMax=40,Tipo="Normal" },
                new Item{Id=2, Name= "Aula Magna",Lugar = "libertad",CapacidadMax=100,Tipo = "Magna"},
            };
            dataGridView1.DataSource = staticData;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reservas")
                {
                    this.Hide();
                    VerReservas reservas = new VerReservas();
                    reservas.Show();

                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Informe")
                {
                    this.Hide();
                    Reporte unReporte = new Reporte();
                    unReporte.Show();
                    
                }
                // Verificar si el clic ocurrió en la columna "Reservar"
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Reservar")
                {
                    this.Hide();
                    ReservarAula reserva = new ReservarAula();
                    reserva.Show();
                    // Realizar la acción correspondiente al botón "Reservar"
                    // Por ejemplo, abrir un formulario para realizar una nueva reserva
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.Hide();
                    CrearAula aula = new CrearAula((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[1].Value, (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value, (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value,(string)dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    
                    aula.Show();
                    
                }
            }
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.Name = "Reservar"; // Name the column
            buttonColumn1.Text = "Nueva Reserva";    // Text for buttons in the column
            buttonColumn1.UseColumnTextForButtonValue = true; // Display the Text value on buttons




            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "Informe"; // Name the column
            buttonColumn2.Text = "Nuevo Informe";    // Text for buttons in the column
            buttonColumn2.UseColumnTextForButtonValue = true; // Display the Text value on buttons

            
            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.Name = "Editar"; // Name the column
            buttonColumn3.Text = "Editar";    // Text for buttons in the column
            buttonColumn3.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewButtonColumn buttonColumn5 = new DataGridViewButtonColumn();
            buttonColumn5.Name = "Reservas"; // Name the column
            buttonColumn5.Text = "Reserva";    // Text for buttons in the column
            buttonColumn5.UseColumnTextForButtonValue = true; // Display the Text value on buttons
            
            dataGridView1.Columns.Add(buttonColumn1);
            dataGridView1.Columns.Add(buttonColumn2);
            dataGridView1.Columns.Add(buttonColumn3);
            dataGridView1.Columns.Add(buttonColumn4);
            dataGridView1.Columns.Add(buttonColumn5);
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

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearAula aula=new CrearAula();
            aula.Show();
        }

        private void BMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.Show();
        }

        private void utils2_Load(object sender, EventArgs e)
        {

        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void BProfesores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores profesores = new Profesores();
            profesores.Show();

        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lugar { get; set; }
        public int CapacidadMax { get; set; }
        public string Tipo { get; set; }
    }
}
