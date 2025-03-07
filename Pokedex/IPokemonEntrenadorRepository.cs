﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public interface IPokemonEntrenadorRepository
    {
        void Crear(PokemonEntrenador entrenador);
        List<PokemonEntrenador> Leer();
        void Actualizar(PokemonEntrenador entrenador);
        void Eliminar(int Id_Entrenador);
    }
}
