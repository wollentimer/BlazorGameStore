using BlazorGameStore.Server.Data;
using BlazorGameStore.Server.Services.CategoryService;
using BlazorGameStore.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorGameStore.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Variants)
                .ToListAsync();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            Product product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;
            
            await _context.SaveChangesAsync();

            return product;
        }


        public async Task<List<Product>> GetProductsByCategoryAsync(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrlAsync(categoryUrl);
            
            return await _context.Products
                .Include(p => p.Variants)
                .Where(p => p.CategoryId == category.Id)
                .ToListAsync();
        }

    }
}
