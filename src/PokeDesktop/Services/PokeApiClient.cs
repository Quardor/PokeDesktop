using PokeDesktop.Models;
using Newtonsoft.Json;

namespace PokeDesktop.Services
{
    public class PokeApiClient
    {
        private readonly HttpClient _httpClient = new HttpClient 
        { 
            BaseAddress = new Uri("https://pokemon-go-api.github.io/pokemon-go-api/api/") 
        };

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            ObjectCreationHandling = ObjectCreationHandling.Replace
        };

        public async Task<List<Pokemon>> GetAllPokemonAsync()
        {
            var response = await _httpClient.GetAsync("pokedex.json");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Pokemon>>(json, Settings);
        }

        public async Task<Pokemon> GetPokemonByIdAsync(int dexNr)
        {
            var response = await _httpClient.GetAsync($"pokedex/id/{dexNr}.json");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Pokemon>(json, Settings);
        }
    }
}
