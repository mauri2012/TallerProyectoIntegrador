using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.admin;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;


namespace ProyectoIntegradorTaller.logica
{
    internal class ReporteLogica
    {
        private static void agregarChart(Chart chart,IQueryable<HorarioList> query)
        {
            chart.Series.Clear();

            foreach (var reserva in query)
            {
                var series = new Series(reserva.campo);
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY(0, reserva.cantcampo);
                chart.Series.Add(series);
            }
        }
        public static void diasListar(Chart chart,int id_aula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from reserva in db.reserva
                             join aula in db.aula on reserva.id_aula equals aula.id_aula
                             join dias_semana in db.dias_semana on reserva.id_dia equals dias_semana.id_dias
                             where aula.activa == "SI" && aula.id_aula == id_aula
                             group new { reserva, aula, dias_semana }
                             by new { reserva.id_dia, aula.nombre, dias_semana.dias } into g
                             select new HorarioList
                             {
                                 cantcampo = g.Count(),
                                 campo = g.Key.dias.ToString(),
                                 aula = g.Key.nombre.ToString(),
                             };
                agregarChart(chart,query);

            }
        }
        public static void materiasListar(Chart chart, int id_aula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from reserva in db.reserva
                            join aula in db.aula on reserva.id_aula equals aula.id_aula
                            join materias in db.materias on reserva.id_materia equals materias.id_materia
                            where aula.activa == "SI" && aula.id_aula == id_aula
                            group new { reserva, aula, materias }
                            by new { reserva.id_materia, aula.nombre, materias.materia } into g
                            select new HorarioList
                            {
                                cantcampo = g.Count(),
                                campo = g.Key.materia.ToString(),
                                aula = g.Key.nombre.ToString(),
                            };
           
                agregarChart(chart, query);

            }
        }
        public static void horasListar(Chart chart, int id_aula)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from reserva in db.reserva
                               join aula in db.aula on reserva.id_aula equals aula.id_aula
                               join horas in db.horas on reserva.id_hora equals horas.id_hora
                               where aula.activa == "SI" && aula.id_aula == id_aula
                               group new { reserva, aula, horas }
                               by new { reserva.id_hora, aula.nombre, horas.horario } into g
                               select new HorarioList
                               {
                                   cantcampo = g.Count(),
                                   campo = g.Key.horario.ToString(),
                                   aula = g.Key.nombre.ToString(),
                               };

                agregarChart(chart, query);

            }
        }

    }
}
