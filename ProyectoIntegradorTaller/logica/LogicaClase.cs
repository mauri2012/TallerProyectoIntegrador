using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaClase
    {
        public static void aulaActiva(string estado, DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
           // dataGrid.Rows[e.RowIndex].Cells["Desactivar"].Value = estado;
            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                int idUsuario = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); // 

                aula aulaDesactivar = db.aula.FirstOrDefault(u => u.id_aula == idUsuario);
                if (aulaDesactivar != null)
                {
                    aulaDesactivar.activa = estado;
                    db.SaveChanges();

                }
            }
        }
        public static void listarAula(DataGridView dataGrid)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
        
                var query = from aula in db.aula
                            join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                            join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                           
                            where aula.activa=="SI"
                            select new
                            {
                                Id = aula.id_aula,
                                Name = aula.nombre,
                                CapacidadMax = aula.capacidad,
                                Lugar = ubicacion.lugar, // Assuming ubicacion has a "Nombre" property
                                Tipo = tipoSala.tipo, // Assuming tipo has a "Nombre" property
                          
                            };


                dataGrid.DataSource = query.ToList();

            }
        }
        public static void busquedaAula(string valor, DataGridView dataGrid)
        {
            int valorInt;


            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                if (int.TryParse(valor, out valorInt))
                {

                    var query = from aula in db.aula
                                join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                                join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                                where aula.activa=="SI" && aula.capacidad==valorInt
                                select new
                                {
                                    Id = aula.id_aula,
                                    Name = aula.nombre,
                                    CapacidadMax = aula.capacidad,
                                    Lugar = ubicacion.lugar, // Assuming ubicacion has a "Nombre" property
                                    Tipo = tipoSala.tipo // Assuming tipo has a "Nombre" property
                                };

                    dataGrid.DataSource = query.ToList();
                    /*var query =  dbContext.aula
                        .Where(entity =>
                               entity.capacidad.Equals(valorInt)
                                 )
                        .ToList();*/
                
                // Bind the filtered data to your DataGridView
                //dataGrid.DataSource = query;
                }
                else
                {
                    var query =from  aula in db.aula
                                join ubicacion in db.ubicacion on aula.id_ubicacion equals ubicacion.id_ubicacion
                                join tipoSala in db.tipoSala on aula.id_tipo equals tipoSala.id_sala
                                where aula.activa=="SI" && aula.nombre.Contains(valor)
                                select new
                                {
                                    Id = aula.id_aula,
                                    Name = aula.nombre,
                                    CapacidadMax = aula.capacidad,
                                    Lugar = ubicacion.lugar, // Assuming ubicacion has a "Nombre" property
                                    Tipo = tipoSala.tipo // Assuming tipo has a "Nombre" property
                                };
                 
                    dataGrid.DataSource = query.ToList();
                }
            }
        }
        public static void updateClassroom(int id, string ttipo,string CBubicacion, string tnombre, string tcapacidad, CheckBox CBAire, CheckBox CBWIFI, CheckBox CBProyector, CheckBox CBTelevisor)
        {
            List<aula_equipamiento> aula_equi = new List<aula_equipamiento>();
            List<string> equipamiento = new List<string>();
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var tipoSala = dbContext.tipoSala.FirstOrDefault(tipoS => tipoS.tipo ==ttipo);
                var ubicacion = dbContext.ubicacion.FirstOrDefault(tipoU => tipoU.lugar == CBubicacion);
            
                equipamiento.Add(CBAire.Checked ? "SI" : "NO");
                equipamiento.Add(CBWIFI.Checked ? "SI" : "NO");
                equipamiento.Add(CBProyector.Checked ? "SI" : "NO");
                equipamiento.Add(CBTelevisor.Checked ? "SI" : "NO");


                for (int i = 0; i < 4; i++)
                {
                    aula_equi.Add(new aula_equipamiento()
                    {
                        id_aula = id,
                        id_equipamiento = i,
                        disponible = equipamiento[i],
                   
                    }); 
                }
           

                var entityToUpdate = dbContext.aula.Find(id);
                var entityToUpdate1 = dbContext.aula_equipamiento;
                if (entityToUpdate != null)
                {
                    entityToUpdate.nombre = tnombre;
                    entityToUpdate.capacidad = int.Parse(tcapacidad);
                    entityToUpdate.id_ubicacion = ubicacion.id_ubicacion;
                    entityToUpdate.id_tipo = tipoSala.id_sala;

                    for (int i = 0; i < 4; i++)
                    {
                        var property = entityToUpdate1.GetType().GetProperty("aula_equi"+i);
                        if(property != null)
                        {
                            property.SetValue(entityToUpdate1, aula_equi[i]);
                        }
                        
                    }
                    dbContext.SaveChanges();
                
                }
            }
        }
        public static bool valNomAula(string tnombre)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var nomaula = db.aula.FirstOrDefault(nom => nom.nombre == tnombre && nom.activa == "SI");
                if (nomaula == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void addClassroom(string ttipo,string CBubicacion,string tnombre,string tcapacidad,bool CBAire,bool CBWIFI,bool CBProyector,bool CBTelevisor)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var tipoSala = db.tipoSala.FirstOrDefault(tipoS => tipoS.tipo == ttipo);
                var ubicacion = db.ubicacion.FirstOrDefault(tipoU => tipoU.lugar == CBubicacion);
                var  nomaula=db.aula.FirstOrDefault(nom=> nom.nombre == tnombre && nom.activa=="SI");
             


                    aula aula1 = new aula()
                    {
                        nombre = tnombre,
                        capacidad = int.Parse(tcapacidad),
                        id_ubicacion = ubicacion.id_ubicacion,
                        id_tipo = tipoSala.id_sala,
                        activa = "SI",
                    };


                    List<aula_equipamiento> aula_equi = new List<aula_equipamiento>();
                    List<string> equipamiento = new List<string>();


                    string disponibleCA = CBAire ? "SI" : "NO";
                    string disponibleWIFI = CBWIFI ? "SI" : "NO";
                    string disponibleProyector = CBProyector ? "SI" : "NO";
                    string disponibleTelevisor = CBTelevisor ? "SI" : "NO";
                    equipamiento.Add(disponibleCA);
                    equipamiento.Add(disponibleWIFI);
                    equipamiento.Add(disponibleProyector);
                    equipamiento.Add(disponibleTelevisor);


                    for (int i = 0; i < 4; i++)
                    {
                        aula_equi.Add(new aula_equipamiento()
                        {
                            id_aula = aula1.id_aula,
                            id_equipamiento = i + 1,
                            disponible = equipamiento[i],
                        });

                    }

                    db.aula.Add(aula1);

                    for (int i = 0; i < 4; i++)
                    {
                        db.aula_equipamiento.Add(aula_equi[i]);
                    };



                    db.SaveChanges();
                   
                
               

            }
        }
    }
}
