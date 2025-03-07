using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Pokedex
{
    public class PokemonEntrenadorRepository : IPokemonEntrenadorRepository
    {
        private readonly string connectionString;

        public PokemonEntrenadorRepository(Conexion conexion)
        {
        
            connectionString = conexion.getconnectionString();
        }

        public void Actualizar(PokemonEntrenador entrenador)
        {
            throw new NotImplementedException();
        }

        public void Crear(PokemonEntrenador entrenador)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id_Entrenador)
        {
            throw new NotImplementedException();
        }

        public List<PokemonEntrenador> Leer()
        {
            List<PokemonEntrenador> Entrenadores = new List<PokemonEntrenador>();

            using (SqlConnection conexion = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM PokemonEntrenadores";
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Entrenadores.Add(new PokemonEntrenador
                    {
                        Id_Entrenador = Convert.ToInt32(reader["Id_Entrenador"]),
                        NombreEntrenador = reader["NombreEntrenador"].ToString(),
                        Ciudad = reader["Ciudad"].ToString(),
                        Pokemon = reader["Pokemon"].ToString(),
                        Tipo = reader["Tipo"].ToString(),
                        Nivel = Convert.ToInt32(reader["Nivel"]),
                        Movimiento1 = reader["Movimiento1"].ToString(),
                        Movimiento2 = reader["Movimiento2"].ToString(),
                        Movimiento3 = reader["Movimiento3"].ToString(),
                        Movimiento4 = reader["Movimiento4"].ToString(),
                        LigaGanada = reader["LigaGanada"].ToString()
                    });
                }
            }
            return Entrenadores;
        }
    }
}
