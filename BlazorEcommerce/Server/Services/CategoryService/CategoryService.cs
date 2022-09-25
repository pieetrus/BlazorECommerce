using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            this._context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            return new ServiceResponse<List<Category>>
            {
                Data = await _context.Categories.ToListAsync()
            };
        }
    }
}
