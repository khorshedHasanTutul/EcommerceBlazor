using Microsoft.AspNetCore.Mvc;
using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;
using EcommerceWebAsmb.Server.Services.ProductService;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private static List<Product> Products = new List<Product>();

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var Products = await _productService.GetServiceResponseAsync();
            return Ok(Products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int id)
        {
            var Product = await _productService.GetProductResponseAsync(id);
            return Ok(Product);
        }
    }
}
