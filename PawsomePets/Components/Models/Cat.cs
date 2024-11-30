using Newtonsoft.Json;

namespace PawsomePets.Components.Models
{
    public class Cat
    {
        [JsonProperty("id")]
        public int Id { get; set; }  

        [JsonProperty("name")]
        public string Name { get; set; } 

        [JsonProperty("temperament")]
        public string Temperament { get; set; } 

        [JsonProperty("life_span")]
        public string LifeSpan { get; set; }  

        [JsonProperty("origin")]
        public string Origin { get; set; }  

       
        [JsonProperty("image")]
        public CatImage Image { get; set; }
    }
}
