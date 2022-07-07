using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebAsmb.Shared;

namespace EcommerceWebAsmb.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}