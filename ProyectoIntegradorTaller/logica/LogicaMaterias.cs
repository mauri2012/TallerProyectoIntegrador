using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaMaterias
    {
        public static materias getMateria(int id_materia)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var materiaElejida = db.materias.FirstOrDefault(m => m.id_materia == id_materia);
                return materiaElejida;
            }
        }
        public static void listarMaterias(DataGridView datagrid)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from materias in db.materias
                            where materias.activo == "SI"
                            select new
                            {
                                Id = materias.id_materia,
                                Materia = materias.materia,
                                Activo = materias.activo

                            };
                datagrid.DataSource = query.ToList();

            }
        }
        public static void agregarMateria(string tmateria)
        {
            materias sub = new materias
            {
                materia = tmateria,
                activo = "SI"
            };
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.materias.Add(sub);
                db.SaveChanges();

            }
        }
        public static void materiaActiva(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            // dataGrid.Rows[e.RowIndex].Cells["Desactivar"].Value = estado;
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                int idUsuario = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); // 

                materias aulaDesactivar = db.materias.FirstOrDefault(u => u.id_materia == idUsuario);
                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activo = estado;
                    db.SaveChanges();

                }
            }
        }
        public static void busqueda(string valor, DataGridView dataGrid)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.materias
                    .Where(materia => materia.materia.Contains(valor) && materia.activo == "SI")
                    .Select(materia => new
                    {
                        Id = materia.id_materia,
                        Materia = materia.materia,
                        Activo = materia.activo
                    })
                    .ToList();

                dataGrid.DataSource = query;
            }
        }
    }
}
