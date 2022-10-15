using BlazorGameStore.Shared;

namespace BlazorGameStore.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
            };

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrlAsync(string categoryUrl)
        {
            return Categories
                .FirstOrDefault(c => c.Url.ToLower()
                                          .Equals(categoryUrl.ToLower()));
        }
    }
}
