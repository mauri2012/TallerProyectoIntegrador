using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class AdministracionDatabase : FormPersonalisado
    {
        public AdministracionDatabase()
        {
            InitializeComponent();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            BedelMenu bedelMenu = new BedelMenu();
            bedelMenu.Show();
        }

        private void BBuscarRuta_Click(object sender, EventArgs e)
        {


            // Configura el cuadro de diálogo para buscar una carpeta
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Mostrar el cuadro de diálogo
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Verificar si el usuario hizo clic en el botón Aceptar
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                // Mostrar la ruta en el TextBox
                TBRutaExport.Texts = folderPath;
            }

        }

        private void BExportarDB_Click(object sender, EventArgs e)
        {
            // Verifica si los TextBox no están vacíos
            if (string.IsNullOrWhiteSpace(TBRutaExport.Texts) || string.IsNullOrWhiteSpace(TBNombreArchivo.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                
            }
            else {

                string backupPath = Path.Combine(TBRutaExport.Texts, TBNombreArchivo.Texts + ".bak");

                LogicaAdministrarDB.RealizarBackup(backupPath);
                MessageBox.Show("Se exporto correctamente la copia");
            }

            
        }
    }
}
