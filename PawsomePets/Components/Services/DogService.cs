using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace PawsomePets.Components.Models;

public class DogService
{

    private HttpClient _httpClient;

    public DogService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Dog>> GetDogsAsync()
    {
        var response = await _httpClient.GetStringAsync("breeds");
        return JsonConvert.DeserializeObject<List<Dog>>(response);
    }

}
