using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using System;
using System.Linq;

using System.Windows.Forms.DataVisualization.Charting;


namespace ProyectoIntegradorTaller.logica
{
    internal class ReporteLogica
    {
        private static void agregarChart(Chart chart,IQueryable<HorarioList> query,int tipo)
        {
            chart.Series.Clear();
            

            if (tipo == 1)
            {
                foreach (var reserva in query)
                {
                    var series = new Series(reserva.campo);
                    series.ChartType = SeriesChartType.Column;
                    series.Points.AddXY(0, reserva.cantcampo);
                    chart.Series.Add(series);
                }
            }
            else
            {
                int total;
                if(query != null)
                {
                    if (query.Any(r => !string.IsNullOrEmpty(r.cantcampo.ToString())))
                    {
                        total = query.Sum(reserva => reserva.cantcampo);
                    }
                    else
                    {
                        total = 10;
                    }
           
                }
                else
                {
                    total = 10;
                }
                
                var series = new Series("reserva");
                foreach (var reserva in query)
                { 
                    series.ChartType = SeriesChartType.Doughnut;

                    var porcentaje = reserva.cantcampo * 100 / total;
                     
                    series.Points.Add(new DataPoint { AxisLabel = $"{reserva.campo} ({porcentaje:F2})", YValues = new double[] { porcentaje } });
 
                }
                chart.Series.Add(series);
            }

        }
        public static void diasListar(Chart chart,int id_aula,string periodo)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p=>p.periodo_nombre==periodo );
                var query = from reserva in db.reserva
                             join aula in db.aula on reserva.id_aula equals aula.id_aula
                             join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                             join Periodo in db.Periodo on  reserva.id_periodo equals Periodo.id_periodo
                             where aula.activa == "SI" && aula.id_aula == id_aula && Periodo.fecha_desde >= periodoElejido.fecha_desde  && Periodo.fecha_hasta <= periodoElejido.fecha_hasta && reserva.activo=="SI"
                             group new { reserva, aula, dias_semana }
                             by new { reserva.id_dia, aula.nombre, dias_semana.dias } into g
                             select new HorarioList
                             {
                                 cantcampo = g.Count(),
                                 campo = g.Key.dias.ToString(),
                                 aula = g.Key.nombre.ToString(),
                             };
                agregarChart(chart,query,1);

            }
        }
        public static void profesorListar(Chart chart, int id_aula, string periodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                            join usuario in db.usuario on reserva.id_usuario equals usuario.id_usuario
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where usuario.desactivar == "NO"  && aula.activa=="SI" &&  aula.id_aula==id_aula && aula.id_aula == id_aula && Periodo.fecha_desde >= periodoElejido.fecha_desde && Periodo.fecha_hasta<=periodoElejido.fecha_hasta && reserva.activo=="SI"
                            group new { reserva,usuario,aula }
                            by new {  usuario.apellido,aula.nombre} into g
                            select new HorarioList
                            {
                                cantcampo = g.Count(),
                                campo = g.Key.apellido.ToString(),
                                aula = g.Key.nombre.ToString(),
                            };

                agregarChart(chart, query, 2);

            }
        }
        public static void materiasListar(Chart chart, int id_aula,string periodo)
        {

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where aula.activa == "SI" &&  aula.id_aula == id_aula && Periodo.fecha_desde >= periodoElejido.fecha_desde && Periodo.fecha_hasta <= periodoElejido.fecha_hasta && reserva.activo=="SI"
                            group new { reserva, aula, materias }
                            by new { reserva.id_materia, aula.nombre, materias.materia } into g
                            select new HorarioList
                            {
                                cantcampo = g.Count(),
                                campo = g.Key.materia.ToString(),
                                aula = g.Key.nombre.ToString(),
                            };
           
                agregarChart(chart, query,2);

            }
        }
        public static void horasListar(Chart chart, int id_aula, string periodo)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var periodoElejido = db.Periodo.FirstOrDefault(p => p.periodo_nombre == periodo);
                var query = from reserva in db.reserva
                               join aula in db.aula on reserva.id_aula equals aula.id_aula
                               join horas in db.horas on reserva.id_hora equals horas.id_hora
                               join Periodo in db.Periodo on reserva.id_periodo equals Periodo.id_periodo
                            where aula.activa == "SI" && aula.id_aula == id_aula && aula.id_aula == id_aula &&  Periodo.fecha_hasta <= periodoElejido.fecha_hasta && reserva.activo == "SI"
                               group new { reserva, aula, horas }
                               by new { reserva.id_hora, aula.nombre, horas.horario } into g
                               select new HorarioList
                               {
                                   cantcampo = g.Count(),
                                   campo = g.Key.horario.ToString(),
                                   aula = g.Key.nombre.ToString(),
                               };

                agregarChart(chart, query, 1 );

            }
        }

    }
}
