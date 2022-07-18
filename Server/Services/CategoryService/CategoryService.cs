using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAsmb.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>();
            var result = await _context.Categories.ToListAsync();

            if (result != null)
            {
                response.Data = result;
            }
            else
            {
                response.Data = null;
                response.status = false;
                response.message = "Not Found";
            }
            return response;
        }
    }
}
