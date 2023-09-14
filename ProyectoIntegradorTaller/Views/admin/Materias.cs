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

namespace ProyectoIntegradorTaller.formularios
{
    public partial class Materias : DraggablePanelUserControl
    {
        public Materias()
        {

            InitializeComponent();
            List<ItemMaterias> staticData = new List<ItemMaterias>()
            {

                new ItemMaterias{Materia="Taller de Programacion 1" },
                 new ItemMaterias{Materia="Ingeneria del Software 1" },
            };
            dataGridView1.DataSource = staticData;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            //string[] array = { "Hi" ,"world"};
            //List<ItemMaterias> lista = array.Select(item => new ItemMaterias { Materia = item }).ToList();
            //dataGridView1.DataSource=lista;
        }

 


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
               
                // Verificar si el clic ocurrió en la columna "Reservar"
          
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    CrearMateria aula = new CrearMateria((string)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    aula.Show();
                    
                }
            }
        }
        private void Reservas_Load(object sender, EventArgs e)
        {

           
            
            DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
            buttonColumn3.Name = "Editar"; // Name the column
            buttonColumn3.Text = "Editar";    // Text for buttons in the column
            buttonColumn3.UseColumnTextForButtonValue = true; // Display the Text value on buttons


            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar"; // Name the column
            buttonColumn4.Text = "Eliminar";    // Text for buttons in the column
            buttonColumn4.UseColumnTextForButtonValue = true; // Display the Text value on buttons

     
            dataGridView1.Columns.Add(buttonColumn3);
            dataGridView1.Columns.Add(buttonColumn4);

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

        private void BCrearMateria_Click(object sender, EventArgs e)
        {
            
            CrearMateria unaMateria = new CrearMateria();
            unaMateria.Show();
        }

    
    }
    public class ItemMaterias
    {
     
        public string Materia { get; set; }
    
    }
}
