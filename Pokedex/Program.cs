using System;
namespace Pokedex
{
    internal class Program
    {
        static void Main()
        {
            Conexion conexion = new Conexion();
            IPokemonEntrenadorRepository repository = new PokemonEntrenadorRepository(conexion);
            var listapokemon = repository.Leer();

            while (true)
            {
                Console.WriteLine("Pokedex");
                Console.WriteLine("agregar una opcion");
                Console.WriteLine("1 Agrgar entrenador");
                Console.WriteLine("2 Mostrar entrenador");
                Console.WriteLine("3 Actualizar entrenador");
                Console.WriteLine("4 Eliminar entrenador");
                Console.WriteLine("5 Salir");

                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        repository.Crear(new PokemonEntrenador { Id_Entrenador = 1, NombreEntrenador = "Ash", Ciudad = "Pueblo Paleta", Pokemon = "Pikachu", Tipo = "Eléctrico", Nivel = 85, Movimiento1 = "Impactrueno", Movimiento2 = "Rayo", Movimiento3 = "Ataque Rápido", Movimiento4 = "Cola Férrea", LigaGanada = "Liga Alola" });
                        break;
                    case 2:
                        repository.Leer().ForEach(e => Console.WriteLine($"{e.Id_Entrenador} - {e.NombreEntrenador} - {e.Pokemon}"));
                        break;
                    case 3:
                        repository.Actualizar(new PokemonEntrenador { Id_Entrenador = 1, Nivel = 55 });
                        break;
                    case 4:
                        repository.Eliminar(1);
                        break;
                    case 5:
                        return;
                }
            }

        }


    }
}

