using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
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
                                Tipo = tipoSala.tipo // Assuming tipo has a "Nombre" property
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
            int tipo = 1;
            if (ttipo == "laboratorio")
            {
                tipo = 2;
            }
            int tipoU = 1;
            if (CBubicacion == "segundo piso")
            {
                tipoU = 2;
            }
            else if (CBubicacion == "tercer piso")
            {
                tipoU = 3;
            }

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
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {

                var entityToUpdate = dbContext.aula.Find(id);
                var entityToUpdate1 = dbContext.aula_equipamiento;
                if (entityToUpdate != null)
                {
                    entityToUpdate.nombre = tnombre;
                    entityToUpdate.capacidad = int.Parse(tcapacidad);
                    entityToUpdate.id_ubicacion = tipoU;
                    entityToUpdate.id_tipo = tipo;

                    for (int i = 0; i < 4; i++)
                    {
                        var property = entityToUpdate1.GetType().GetProperty("aula_equi"+i);
                        if(property != null)
                        {
                            property.SetValue(entityToUpdate1, aula_equi[i]);
                        }
                        
                    }
                    dbContext.SaveChanges();
                    MessageBox.Show("se edito la clase correctamente correctamente!", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static void addClassroom(string ttipo,string CBubicacion,string tnombre,string tcapacidad,CheckBox CBAire,CheckBox CBWIFI,CheckBox CBProyector,CheckBox CBTelevisor)
        {
            int tipo = 1;
            if (ttipo == "laboratorio")
            {
                tipo = 2;
            }
            int tipoU = 1;
            if (CBubicacion == "segundo piso")
            {
                tipoU = 2;
            }
            else if (CBubicacion == "tercer piso")
            {
                tipoU = 3;
            }
            aula aula1 = new aula()
            {
                nombre = tnombre,
                capacidad = int.Parse(tcapacidad),
                id_ubicacion = tipoU,
                id_tipo = tipo,
                activa = "SI",
            };


            List<aula_equipamiento> aula_equi=new List<aula_equipamiento>();
            List<string> equipamiento = new List<string>();
            
       
            string disponibleCA = CBAire.Checked ? "SI" : "NO";
            string disponibleWIFI = CBWIFI.Checked ? "SI" : "NO";
            string disponibleProyector = CBProyector.Checked ? "SI" : "NO";
            string disponibleTelevisor = CBTelevisor.Checked ? "SI" : "NO";
            equipamiento.Add(disponibleCA);
            equipamiento.Add(disponibleWIFI);
            equipamiento.Add(disponibleProyector);
            equipamiento.Add(disponibleTelevisor);


            for (int i=0; i<4;i++){
                aula_equi.Add(new aula_equipamiento()
                {
                    id_aula = aula1.id_aula,
                    id_equipamiento = i+1,
                    disponible = equipamiento[i],
                });

            }
          
         
        
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.aula.Add(aula1);

                for (int i = 0; i < 4; i++)
                {
                     db.aula_equipamiento.Add(aula_equi[i]);
                };

               

                db.SaveChanges();
                MessageBox.Show("se inserto el aula correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

            }
        }
    }
}
