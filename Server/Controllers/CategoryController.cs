using EcommerceWebAsmb.Server.Services.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>>GetResult()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }
    }
}
