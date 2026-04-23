using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TableViewer.DbLayer
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260422160000_InsertData")]
    public class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ViewCount", "PurchaseCount" },
                columnTypes: new string[] { "integer", "text", "integer", "integer", "integer" },
                values: new object[,]
                {
                    { 1, "iPhone", 1000, 10000, 50 },
                    { 2, "MacBook", 2000, 9500, 70 },
                    { 3, "AirPods", 200, 15000, 110 },
                    { 4, "iPad", 800, 7000, 39 },
                    { 5, "Apple Watch", 500, 11000, 60 }
                });
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Products", "Id", new object[] { 1, 2, 3, 4, 5 });
        }
    }
}