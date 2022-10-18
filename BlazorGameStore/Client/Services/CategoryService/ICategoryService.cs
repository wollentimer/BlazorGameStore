using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategoriesAsync();
    }
}
