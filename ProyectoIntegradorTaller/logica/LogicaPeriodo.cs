using ProyectoIntegradorTaller.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaPeriodo
    {
        public static IList listarPeriodos()
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from Periodo in db.Periodo
                                // where materias.activo == "SI"
                            select new
                            {
                                Id = Periodo.id_periodo,
                                periodo = Periodo.periodo_nombre,
                                desde = Periodo.fecha_desde,
                                hasta = Periodo.fecha_hasta
                            };
                return query.ToList();

            }
        }

        public static void InsertarPeriodo(int id_periodo, DateTime desde, DateTime hasta)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var periodo = db.Periodo.FirstOrDefault(r => r.id_periodo == id_periodo);
                if (periodo != null)
                {
                    periodo.fecha_desde = desde;
                    periodo.fecha_hasta = hasta;
                    db.SaveChanges();
                }



            }
        }
        public static string getPeriodo(int id_periodo) { 
            using(classroom_managerEntities db=new classroom_managerEntities())
            {
                return db.Periodo.FirstOrDefault(r => r.id_periodo==id_periodo).periodo_nombre;
            }
        }
        public static IList busquedaPeriodo(string valor)
        {


            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from Periodo in db.Periodo
                            where Periodo.periodo_nombre.Contains(valor)
                            select new
                            {
                                Id = Periodo.id_periodo,
                                Periodo = Periodo.periodo_nombre,
                                Desde = Periodo.fecha_desde,
                                Hasta = Periodo.fecha_hasta
                            };

                return query.ToList();



            }
        }
    }
}