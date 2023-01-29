using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopOnlineAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Productid = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "ImageURL", "Price", "ProductDescription", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "/Images/Beauty/Beauty1.png", 100m, "A kit provided by Glossier, containing skin care, hair care and makeup products", "Glossier - Beauty Kit", 100 },
                    { 2, 1, "/Images/Beauty/Beauty2.png", 50m, "A kit provided by Curology, containing skin care products", "Curology - Skin Care Kit", 45 },
                    { 3, 1, "/Images/Beauty/Beauty3.png", 20m, "A kit provided by Curology, containing skin care products", "Cocooil - Organic Coconut Oil", 30 },
                    { 4, 1, "/Images/Beauty/Beauty4.png", 50m, "A kit provided by Schwarzkopf, containing skin care and hair care products", "Schwarzkopf - Hair Care and Skin Care Kit", 60 },
                    { 5, 1, "/Images/Beauty/Beauty5.png", 30m, "Skin Care Kit, containing skin care and hair care products", "Skin Care Kit", 85 },
                    { 6, 3, "/Images/Electronic/Electronics1.png", 100m, "Air Pods - in-ear wireless headphones", "Air Pods", 120 },
                    { 7, 3, "/Images/Electronic/Electronics2.png", 40m, "On-ear Golden Headphones - these headphones are not wireless", "On-ear Golden Headphones", 200 },
                    { 8, 3, "/Images/Electronic/Electronics3.png", 40m, "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones", 300 },
                    { 9, 3, "/Images/Electronic/Electronic4.png", 600m, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod", 20 },
                    { 10, 3, "/Images/Electronic/Electronic5.png", 500m, "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera", 15 },
                    { 11, 3, "/Images/Electronic/technology6.png", 100m, "Gameboy - Provided by Nintendo", "Nintendo Gameboy", 60 },
                    { 12, 2, "/Images/Furniture/Furniture1.png", 50m, "Very comfortable black leather office chair", "Black Leather Office Chair", 212 },
                    { 13, 2, "/Images/Furniture/Furniture2.png", 50m, "Very comfortable pink leather office chair", "Pink Leather Office Chair", 112 },
                    { 14, 2, "/Images/Furniture/Furniture3.png", 70m, "Very comfortable lounge chair", "Lounge Chair", 90 },
                    { 15, 2, "/Images/Furniture/Furniture4.png", 120m, "Very comfortable Silver lounge chair", "Silver Lounge Chair", 95 },
                    { 16, 2, "/Images/Furniture/Furniture6.png", 15m, "White and blue Porcelain Table Lamp", "Porcelain Table Lamp", 100 },
                    { 17, 2, "/Images/Furniture/Furniture7.png", 20m, "Office Table Lamp", "Office Table Lamp", 73 },
                    { 18, 4, "/Images/Shoes/Shoes1.png", 100m, "Comfortable Puma Sneakers in most sizes", "Puma Sneakers", 50 },
                    { 19, 4, "/Images/Shoes/Shoes2.png", 150m, "Colorful trainsers - available in most sizes", "Colorful Trainers", 60 },
                    { 20, 4, "/Images/Shoes/Shoes3.png", 200m, "Blue Nike Trainers - available in most sizes", "Blue Nike Trainers", 70 },
                    { 21, 4, "/Images/Shoes/Shoes4.png", 120m, "Colorful Hummel Trainers - available in most sizes", "Colorful Hummel Trainers", 120 },
                    { 22, 4, "/Images/Shoes/Shoes5.png", 200m, "Red Nike Trainers - available in most sizes", "Red Nike Trainers", 100 },
                    { 23, 4, "/Images/Shoes/Shoes6.png", 50m, "Birkenstock Sandles - available in most sizes", "Birkenstock Sandles", 150 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Beauty" },
                    { 2, "Furniture" },
                    { 3, "Electronics" },
                    { 4, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
