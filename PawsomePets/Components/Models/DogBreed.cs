namespace PawsomePets.Components.Models
{
    public class DogBreed
    {

        public int Id { get; set; }  

        public string Name { get; set; }  

        public string Description { get; set; }  

        public string Temperament { get; set; }  

        public string Life_span { get; set; }  

        public string Origin { get; set; }  

        public string bred_for {  get; set; }
        public string breed_group { get; set; }


        public DogImage Image { get; set; }
        public string reference_image_id { get; set; }

        public string ImageUrl { get; set; }



    }

   
}
