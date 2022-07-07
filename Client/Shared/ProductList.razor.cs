using EcommerceWebAsmb.Shared;
using System.Net.Http.Json;

namespace EcommerceWebAsmb.Client.Shared
{
    public partial class ProductList
    {
        private static List<Product> Products = new List<Product>();
        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }
    }
}
