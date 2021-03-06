using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebAsmb.Shared;
using System.Net.Http.Json;

namespace EcommerceWebAsmb.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"/api/Product/{productId}");
            return response;
        }

        public async Task GetProducts()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("/api/Product");
            if (response != null && response.Data != null)
            {
                Products = response.Data;
            }
        }
    }
}