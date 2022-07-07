using Microsoft.AspNetCore.Mvc;
using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class ProductController : BaseController
    {
        private readonly DataContext _context;
        private static List<Product> Products = new List<Product>();

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var Products = await _context.Products.ToListAsync();
            return Ok(Products);
        }
    }
}
