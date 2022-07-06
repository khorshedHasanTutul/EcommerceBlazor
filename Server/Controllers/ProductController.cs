using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class ProductController : BaseController
    {
        private static List<Product> Products = new List<Product>
        {
        new Product
            {
                Id=1,
                Title= "Jwt Authentication",
                Descriptions= "This is a good Product",
                ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                Price= 550.25m

            },
             new Product
            {
                Id=2,
                Title= "Entity Framework",
                Descriptions= "This is a good Product",
                ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                Price= 400.25m

            },
              new Product
              {
                  Id = 3,
                  Title = "JavaScriptHello",
                  Descriptions = "This is a good Product",
                  ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                  Price = 400.25m
              },
              new Product
              {
                  Id = 4,
                  Title = "TypeScript",
                  Descriptions = "This is a good Product",
                  ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                  Price = 400.25m
              },
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
    }
}