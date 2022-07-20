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
                        Price= 550.25m,
                        CategoryId=1,

                    },
             new Product
                    {
                        Id=2,
                        Title= "Entity Framework",
                        Descriptions= "This is a good Product",
                        ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                        Price= 400.25m,
                        CategoryId = 2,

                    },
              new Product
                      {
                          Id = 3,
                          Title = "JavaScriptHello",
                          Descriptions = "This is a good Product",
                          ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                          Price = 400.25m,
                          CategoryId=2,
                      },
              new Product
                      {
                          Id = 4,
                          Title = "TypeScript",
                          Descriptions = "This is a good Product",
                          ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                          Price = 400.25m,
                          CategoryId=1,
                      }

                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "/books"
                },
                new Category
                {
                    Id =2,
                    Name= "Megazines",
                    Url = "/megazines"
                },
                new Category
                {
                    Id = 3,
                    Name = "Literals",
                    Url = "/literals"
                }
                );
        }

        public  DbSet<Product>Products { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet<User> User { get; set; }

    }
}
