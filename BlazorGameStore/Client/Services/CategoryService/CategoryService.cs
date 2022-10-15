using BlazorGameStore.Shared;
using System.Net.Http.Json;

namespace BlazorGameStore.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadCategoriesAsync()
        {
            Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}
