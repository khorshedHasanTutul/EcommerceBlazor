using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAsmb.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetServiceResponseAsync();
        Task<ServiceResponse<Product>> GetProductResponseAsync(int id);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category);
    }
}