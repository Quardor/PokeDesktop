using PokeDesktop.Models;
using Newtonsoft.Json;

namespace PokeDesktop.Services
{
    internal class PokeApiClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://pokeapi.co/api/v2/";

        public PokeApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("PokeDesktop/1.0");
        }

        public async Task<Pokemon?> GetPokemonAsync(string name)
        {
            try
            {
                string url = $"{BaseUrl}pokemon/{name.ToLower().Trim()}";
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Pokemon>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
            return null;
        }
    }
}
