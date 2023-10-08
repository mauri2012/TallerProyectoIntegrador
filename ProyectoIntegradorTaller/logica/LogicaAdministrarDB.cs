using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.logica
{
    internal class LogicaAdministrarDB
    {
        public static void RealizarBackup(string backupPath)
        {
            string backupQuery;
            string connectionString;

            using (var context = new classroom_managerEntities())
            {
                connectionString = context.Database.Connection.ConnectionString;
                string databaseName = context.Database.Connection.Database;
                backupQuery = $"BACKUP DATABASE {databaseName} TO DISK = '{backupPath}'";

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(backupQuery, connection))
                {
                    try
                    {
                        // Abre la conexión antes de ejecutar el comando
                        connection.Open();

                        command.ExecuteNonQuery();
                        Console.WriteLine("Backup completed successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
