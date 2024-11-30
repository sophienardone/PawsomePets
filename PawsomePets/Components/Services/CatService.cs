using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PawsomePets.Components.Models; 

namespace PawsomePets.Components.Services
{
    public class CatService
    {
        private readonly HttpClient _httpClient;


        public CatService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       
        public async Task<List<CatBreed>> GetBreedsAsync()
        {
            
            var response = await _httpClient.GetStringAsync("breeds");

            
            return JsonConvert.DeserializeObject<List<CatBreed>>(response);
        }

        
        public async Task<List<CatImage>> GetCatImagesAsync()
        {
            
            var response = await _httpClient.GetStringAsync("images/search?limit=5"); 

           
            return JsonConvert.DeserializeObject<List<CatImage>>(response);
        }
    }
}

