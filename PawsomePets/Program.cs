using PawsomePets.Components.Models;
using PawsomePets.Components;
using System.Net.Http;
using PawsomePets.Components.Services;

namespace PawsomePets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            builder.Services.AddHttpClient<DogService>(client =>
            {
                
                client.BaseAddress = new Uri("https://api.thedogapi.com/v1/");
                client.DefaultRequestHeaders.Add("x-api-key", "live_kojvayaJ9xfHlmWbsY9NyOup4ScfwnVS30IhULAGb0wKXU1HgIlM7e8cz56zSKCo"); 
            });

            builder.Services.AddHttpClient<CatService>(client =>
            {
             
                client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");

                
                client.DefaultRequestHeaders.Add("x-api-key", "live_WAgvVqgUBZU4IgkB4MLPcomFeNQwjZQxaGldvGTmbRoPrMpTM4IG3mkVyZI63Par");
            });

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
