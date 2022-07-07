using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAsmb.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
             new Product
                    {
                        Id=1,
                        Title= "Jwt Authentication Here Refresh Token",

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
                      }

                );
        }

        public  DbSet<Product>Products { get; set; }

    }
}
