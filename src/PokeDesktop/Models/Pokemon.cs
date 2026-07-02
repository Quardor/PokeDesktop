using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDesktop.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<PokemonType> Types { get; set; } = new();
        public Sprites Sprites { get; set; } = new();
    }

    public class PokemonType
    {
        public TypeInfo Type { get; set; } = new();
    }

    public class TypeInfo
    {
        public string Name { get; set; } = string.Empty;
    }

    public class Sprites
    {
        public string FrontDefault { get; set; } = string.Empty;
    }
}
