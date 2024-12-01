using Newtonsoft.Json;
namespace PawsomePets.Components.Models
{
    public class CatBreed
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("temperament")]
        public string Temperament { get; set; }

        [JsonProperty("life_span")]
        public string life_Span { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("reference_image_id")]
        public string reference_image_id { get; set; }

       
    }
}
