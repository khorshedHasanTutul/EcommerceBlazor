using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAsmb.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetServiceResponseAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }
        public async Task<ServiceResponse<Product>> GetProductResponseAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.status = false;
                response.message = "Not Found";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }
    }
}