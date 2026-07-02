using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDesktop.Models
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<PokemonType> Types { get; set; } = new();
        public Sprites Sprites { get; set; } = new();
    }

    internal class PokemonType
    {
        public TypeInfo Type { get; set; } = new();
    }

    internal class TypeInfo
    {
        public string Name { get; set; } = string.Empty;
    }

    internal class Sprites
    {
        public string FrontDefault { get; set; } = string.Empty;
    }
}
