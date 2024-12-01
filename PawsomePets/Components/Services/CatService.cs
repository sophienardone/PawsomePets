using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PawsomePets.Components.Models;
using RestSharp;

namespace PawsomePets.Components.Services
{
    public class CatService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.thecatapi.com/v1/";


        public CatService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("x-api-key", "live_WAgvVqgUBZU4IgkB4MLPcomFeNQwjZQxaGldvGTmbRoPrMpTM4IG3mkVyZI63Par");
        }


        public async Task<List<CatBreed>> GetBreedsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CatBreed>>($"{BaseUrl}breeds");
            return response ?? new List<CatBreed>();
        }
    }
}






