using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;


namespace ProyectoIntegradorTaller.views.admin
{
    public partial class Lugares : FormPersonalisado
    {
        public Lugares()
        {
            InitializeComponent();
        }

        private void Lugares_Load(object sender, EventArgs e)
        {


            try
            {
                LogicaLugares.listarLugares(dataGridView1);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataGridViewButtonColumn buttonColumn4 = new DataGridViewButtonColumn();
            buttonColumn4.Name = "Eliminar";
            buttonColumn4.Text = "Eliminar";
            buttonColumn4.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(buttonColumn4);
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin homeAdmin = new HomeAdmin();
                homeAdmin.Show();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TLugar.Texts))
            {
                LogicaLugares.agregarLugar(TLugar.Texts);
                MessageBox.Show("Se agrego con exito una nueva ubicacion!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("El campo esta vacio!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro que quiere eliminar la ubicaion " + (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value + "  ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == MsgBoxResult.Yes)
                {
                    LogicaLugares.desactivarLugar("NO", dataGridView1, e);
                   
                }
                LogicaLugares.listarLugares(dataGridView1);
                
            }
        }


        private void BBuscar_Click(object sender, EventArgs e)
        {
            LogicaLugares.busquedaLugares(TBBusqueda.Texts, dataGridView1);
        }
    }
}
