using Microsoft.JSInterop;

namespace PawsomePets.Components.Services
{
    public class FavouritesService
    {
        private readonly IJSRuntime _jsRuntime;

        public FavouritesService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<List<string>> GetFavouritesAsync()
        {
            var favoritesJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "favoriteBreeds");
            if (string.IsNullOrEmpty(favoritesJson))
            {
                return new List<string>(); 
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(favoritesJson);

        }

        public async Task AddToFavoritesAsync(string breedId)
        {
            var favorites = await GetFavouritesAsync();
            if (!favorites.Contains(breedId))
            {
                favorites.Add(breedId);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "favoriteBreeds", Newtonsoft.Json.JsonConvert.SerializeObject(favorites));

            }
        }

        public async Task RemoveFromFavoritesAsync(string breedId)
        {
            var favorites = await GetFavouritesAsync();
            if (favorites.Contains(breedId))
            {
                favorites.Remove(breedId);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "favoriteBreeds", Newtonsoft.Json.JsonConvert.SerializeObject(favorites));
            }
        }

        private async Task SaveFavoritesAsync(List<string> favorites)
        {
            var favoritesJson = System.Text.Json.JsonSerializer.Serialize(favorites);
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "favoriteBreeds", favoritesJson);
        }
    }
}
