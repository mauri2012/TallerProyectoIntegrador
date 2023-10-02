using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LugaresLogica
    {

        public static void listarLugares(DataGridView datagrid
            )
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from ubicacion in db.ubicacion
                            select new
                            {
                                Id = ubicacion.id_ubicacion,
                                Lugar = ubicacion.lugar,

                            };
                datagrid.DataSource = query.ToList();

            }
        }

        public static void agregarLugar(string tlugar)
        {
            ubicacion sub = new ubicacion
            {
                lugar = tlugar
               
            };
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.ubicacion.Add(sub);
                db.SaveChanges();

            }
        }

        public static void busquedaLugares(string valor, DataGridView dataGrid)
        {
           
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = dbContext.ubicacion
                     .Where(lugar => lugar.lugar.Contains(valor))
                    .Select(lugar => new
                    {
                        Id = lugar.id_ubicacion,
                        Lugar = lugar.lugar
                    })
                    .ToList();

                dataGrid.DataSource = query;
            }
        }
    }
}
