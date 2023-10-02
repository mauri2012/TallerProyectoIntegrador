using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                LugaresLogica.listarLugares(dataGridView1);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TLugar.Texts))
            {
                LugaresLogica.agregarLugar(TLugar.Texts);
                MessageBox.Show("Se agrego con exito una nueva ubicacion!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("El campo esta vacio!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            LugaresLogica.busquedaLugares(TBBusqueda.Texts, dataGridView1);
        }
    }
}
