using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Pokedex
{
    public class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "Server=AL3XA1226;Database=Pokedex;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        public string getconnectionString()
        {
            return connectionString;
        }

        public void ProbarConexion()
        {
            try
            {
                using var conexion = new SqlConnection(connectionString);
                conexion.Open();
                Console.WriteLine("conexion exitosa a SQL Server");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"error al conectar{ex.Message}");
            }
        }
    }
}
