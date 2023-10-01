using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class MateriasLogica
    {

        public static void busqueda(string valor, DataGridView dataGrid)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.materias
                    .Where(materia => materia.materia.Contains(valor))
                    .ToList();

                
                dataGrid.DataSource = query;
            }
        }
    }
}
