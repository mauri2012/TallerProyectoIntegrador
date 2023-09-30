using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoIntegradorTaller.logica
{
    internal class Session
    {
        public static SessionCache SessionCacheData = null;

        public static bool StartSession( string email, string password) {
            
            password = Encrypt.GetSHA256(password);

            using (classroom_managerEntities db = new classroom_managerEntities())
            {

                var lst = from d in db.usuario
                          where d.correo == email
                          && d.password == password
                          select d;

                if (lst.Count() > 0) {
                    Console.WriteLine(lst.First());
                    var user = lst.FirstOrDefault();

                    SessionCacheData = new SessionCache(user.correo,user.nombre, user.apellido,user.id_usuario, user.id_tipoUsuario);
                    
                    return true;
                
                }else { 
                    return false; 
                
                }
            }
        }
    }


    public class SessionCache
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int IdProfile { get; set; }

        public SessionCache(string email, string name, string lastName, int id, int idProfile)
        {
            Email = email;
            Name = name;
            LastName = lastName;
            Id = id;
            IdProfile = idProfile;
        }

    }
}
