using Newtonsoft.Json;

namespace PokeDesktop.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("formId")]
        public string FormId { get; set; }

        [JsonProperty("dexNr")]
        public int DexNr { get; set; }

        [JsonProperty("generation")]
        public int Generation { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("primaryType")]
        public PokemonType PrimaryType { get; set; }

        [JsonProperty("secondaryType")]
        public PokemonType SecondaryType { get; set; }

        [JsonProperty("quickMoves")]
        public object QuickMoves { get; set; }

        [JsonProperty("cinematicMoves")]
        public object CinematicMoves { get; set; }

        [JsonProperty("eliteQuickMoves")]
        public object EliteQuickMoves { get; set; }

        [JsonProperty("eliteCinematicMoves")]
        public object EliteCinematicMoves { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }
    }

    public class Names
    {
        public string English { get; set; }
    }

    public class Stats
    {
        public int Stamina { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }

    public class PokemonType
    {
        [JsonProperty("type")]
        public string TypeName { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }
    }

    public class Move
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }
    }

    public class Assets
    {
        public string Image { get; set; }
        public string ShinyImage { get; set; }
    }
}
