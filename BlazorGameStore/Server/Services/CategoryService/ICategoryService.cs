using BlazorGameStore.Shared;

namespace BlazorGameStore.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();

        Task<Category> GetCategoryByUrlAsync(string categoryUrl);
    }
}
