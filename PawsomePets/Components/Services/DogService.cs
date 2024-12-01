using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using RestSharp;



namespace PawsomePets.Components.Models;

public class DogService
{

    private readonly HttpClient _httpClient;

    private const string BaseUrl = "https://api.thedogapi.com/v1/";

    public DogService(HttpClient httpClient)
    {

        _httpClient = httpClient;

        _httpClient.DefaultRequestHeaders.Add("x-api-key", "live_kojvayaJ9xfHlmWbsY9NyOup4ScfwnVS30IhULAGb0wKXU1HgIlM7e8cz56zSKCo");
    }


    public async Task<List<DogBreed>> GetDogBreedsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<DogBreed>>($"{BaseUrl}breeds");
        if (response != null)
        {
            foreach (var breed in response)
            {
                if (!string.IsNullOrEmpty(breed.reference_image_id))
                {

                    breed.Image = new DogImage
                    {
                        Url = $"https://cdn2.thedogapi.com/images/{breed.reference_image_id}.jpg",
                    };
                }
            }
            }
            return response ?? new List<DogBreed>();
        }
    }







