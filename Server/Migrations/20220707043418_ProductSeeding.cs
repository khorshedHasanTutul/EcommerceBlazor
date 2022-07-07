using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceWebAsmb.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Descriptions", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "This is a good Product", "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg", 550.25m, "Jwt Authentication Here Refresh Token" },
                    { 2, "This is a good Product", "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg", 400.25m, "Entity Framework" },
                    { 3, "This is a good Product", "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg", 400.25m, "JavaScriptHello" },
                    { 4, "This is a good Product", "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg", 400.25m, "TypeScript" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
