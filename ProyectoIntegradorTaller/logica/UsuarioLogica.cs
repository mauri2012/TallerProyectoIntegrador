using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class UsuarioLogica
    {
        public static void CBTipoListar(ComboBoxPersonalisado box)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                box.DataSource = db.tipoUsuario.ToList();
                box.DisplayMember = "tipo"; 
                box.ValueMember = "id_tipoUsuario";
            }
        }
    
        public static void listarUsuarios(RadioButton RBActivo ,DataGridView dataGrid)
        {
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                var query = from usuario in db.usuario
                            join tipoUsuario in db.tipoUsuario on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where usuario.desactivar == (RBActivo.Checked ? "SI" : "NO")
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI =usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar,
                            };

                dataGrid.DataSource = query.ToList();



            }
        }
        public static void busqueda(string valor,DataGridView dataGrid, RadioButton RBActivo)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
                var query = from usuario in dbContext.usuario
                            join tipoUsuario in dbContext.tipoUsuario
                            on usuario.id_tipoUsuario equals tipoUsuario.id_tipoUsuario
                            where (usuario.nombre.Contains(valor) || usuario.apellido.Contains(valor)) && usuario.desactivar == (RBActivo.Checked ? "SI" : "NO")
                            select new
                            {
                                Id = usuario.id_usuario,
                                Nombre = usuario.nombre,
                                Apellido = usuario.apellido,
                                DNI = usuario.dni,
                                Email = usuario.correo,
                                Tipo = tipoUsuario.tipo,
                                Activo = usuario.desactivar
                            };

                
                dataGrid.DataSource = query.ToList();
            }
        }
        public static void update(int id,int dni_, string apellido_, string emial, string nombre, int tipoU)
        {
            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {
              
                var entityToUpdate = dbContext.usuario.Find(id); // Replace YourEntities with your actual DbSet and id with the primary key value.

                if (entityToUpdate != null)
                {
                    // Step 3: Modify the properties of the entity
                    entityToUpdate.nombre = nombre;
                    entityToUpdate.apellido = apellido_;
                    entityToUpdate.correo = emial;
                    entityToUpdate.id_tipoUsuario = tipoU;
                    entityToUpdate.dni = dni_;

                    // Step 4: Save changes to the database
                    dbContext.SaveChanges();
                    MessageBox.Show("se edito al usuario correctamente!", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        public static void agregar(int dni_, string apellido_ , string emial, string nombre,int tipoU)
        {
            usuario user = new usuario
            {
                dni = dni_,
                nombre = nombre,
                apellido = apellido_,
                correo = emial,
                id_tipoUsuario = tipoU,
                password=Encrypt.GetSHA256(dni_.ToString())
            };

            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                db.usuario.Add(user);
                db.SaveChanges();
                MessageBox.Show("se inserto el usuario correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public static void UsuarioActivo(string estado,DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].Cells["Desactivar"].Value = estado;

            using (classroom_managerEntities db = new classroom_managerEntities())
            {


                int idUsuario = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["Id"].Value); // 

                usuario usuarioDesactivar = db.usuario.FirstOrDefault(u => u.id_usuario == idUsuario);
                if (usuarioDesactivar != null)
                {
                    usuarioDesactivar.desactivar = estado;
                    db.SaveChanges();

                }
            }
        }


        public static void CambiarPassword(string password) {

            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {

                var entityToUpdate = dbContext.usuario.Find(Session.SessionCacheData.Id); 

                if (entityToUpdate != null)
                {
                   
                    entityToUpdate.password = Encrypt.GetSHA256(password);
                     
                    dbContext.SaveChanges();
                    
                }
            }
        }


        public static void BlanquearPassword(string password,int id)
        {

            using (classroom_managerEntities dbContext = new classroom_managerEntities())
            {

                var entityToUpdate = dbContext.usuario.Find(id);

                if (entityToUpdate != null)
                {

                    entityToUpdate.password = Encrypt.GetSHA256(password);

                    dbContext.SaveChanges();

                }
            }
        }
    }
}
