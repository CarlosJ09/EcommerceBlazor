using Microsoft.EntityFrameworkCore;
using ShopOnline_API.Entities;

public class ShopOnlineDbContext : DbContext
{
    public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Products
        //Beauty Category
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            ProductName = "Glossier - Beauty Kit",
            ProductDescription = "A kit provided by Glossier, containing skin care, hair care and makeup products",
            ImageURL = "/Images/Beauty/Beauty1.png",
            Price = 100,
            Quantity = 100,
            CategoryId = 1

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 2,
            ProductName = "Curology - Skin Care Kit",
            ProductDescription = "A kit provided by Curology, containing skin care products",
            ImageURL = "/Images/Beauty/Beauty2.png",
            Price = 50,
            Quantity = 45,
            CategoryId = 1

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 3,
            ProductName = "Cocooil - Organic Coconut Oil",
            ProductDescription = "A kit provided by Curology, containing skin care products",
            ImageURL = "/Images/Beauty/Beauty3.png",
            Price = 20,
            Quantity = 30,
            CategoryId = 1

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 4,
            ProductName = "Schwarzkopf - Hair Care and Skin Care Kit",
            ProductDescription = "A kit provided by Schwarzkopf, containing skin care and hair care products",
            ImageURL = "/Images/Beauty/Beauty4.png",
            Price = 50,
            Quantity = 60,
            CategoryId = 1

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 5,
            ProductName = "Skin Care Kit",
            ProductDescription = "Skin Care Kit, containing skin care and hair care products",
            ImageURL = "/Images/Beauty/Beauty5.png",
            Price = 30,
            Quantity = 85,
            CategoryId = 1

        });
        //Electronics Category
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 6,
            ProductName = "Air Pods",
            ProductDescription = "Air Pods - in-ear wireless headphones",
            ImageURL = "/Images/Electronic/Electronics1.png",
            Price = 100,
            Quantity = 120,
            CategoryId = 3

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 7,
            ProductName = "On-ear Golden Headphones",
            ProductDescription = "On-ear Golden Headphones - these headphones are not wireless",
            ImageURL = "/Images/Electronic/Electronics2.png",
            Price = 40,
            Quantity = 200,
            CategoryId = 3

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 8,
            ProductName = "On-ear Black Headphones",
            ProductDescription = "On-ear Black Headphones - these headphones are not wireless",
            ImageURL = "/Images/Electronic/Electronics3.png",
            Price = 40,
            Quantity = 300,
            CategoryId = 3

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 9,
            ProductName = "Sennheiser Digital Camera with Tripod",
            ProductDescription = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
            ImageURL = "/Images/Electronic/Electronic4.png",
            Price = 600,
            Quantity = 20,
            CategoryId = 3

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 10,
            ProductName = "Canon Digital Camera",
            ProductDescription = "Canon Digital Camera - High quality digital camera provided by Canon",
            ImageURL = "/Images/Electronic/Electronic5.png",
            Price = 500,
            Quantity = 15,
            CategoryId = 3

        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 11,
            ProductName = "Nintendo Gameboy",
            ProductDescription = "Gameboy - Provided by Nintendo",
            ImageURL = "/Images/Electronic/technology6.png",
            Price = 100,
            Quantity = 60,
            CategoryId = 3
        });
        //Furniture Category
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 12,
            ProductName = "Black Leather Office Chair",
            ProductDescription = "Very comfortable black leather office chair",
            ImageURL = "/Images/Furniture/Furniture1.png",
            Price = 50,
            Quantity = 212,
            CategoryId = 2
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 13,
            ProductName = "Pink Leather Office Chair",
            ProductDescription = "Very comfortable pink leather office chair",
            ImageURL = "/Images/Furniture/Furniture2.png",
            Price = 50,
            Quantity = 112,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 14,
            ProductName = "Lounge Chair",
            ProductDescription = "Very comfortable lounge chair",
            ImageURL = "/Images/Furniture/Furniture3.png",
            Price = 70,
            Quantity = 90,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 15,
            ProductName = "Silver Lounge Chair",
            ProductDescription = "Very comfortable Silver lounge chair",
            ImageURL = "/Images/Furniture/Furniture4.png",
            Price = 120,
            Quantity = 95,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 16,
            ProductName = "Porcelain Table Lamp",
            ProductDescription = "White and blue Porcelain Table Lamp",
            ImageURL = "/Images/Furniture/Furniture6.png",
            Price = 15,
            Quantity = 100,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 17,
            ProductName = "Office Table Lamp",
            ProductDescription = "Office Table Lamp",
            ImageURL = "/Images/Furniture/Furniture7.png",
            Price = 20,
            Quantity = 73,
            CategoryId = 2
        });
        //Shoes Category
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 18,
            ProductName = "Puma Sneakers",
            ProductDescription = "Comfortable Puma Sneakers in most sizes",
            ImageURL = "/Images/Shoes/Shoes1.png",
            Price = 100,
            Quantity = 50,
            CategoryId = 4
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 19,
            ProductName = "Colorful Trainers",
            ProductDescription = "Colorful trainsers - available in most sizes",
            ImageURL = "/Images/Shoes/Shoes2.png",
            Price = 150,
            Quantity = 60,
            CategoryId = 4
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 20,
            ProductName = "Blue Nike Trainers",
            ProductDescription = "Blue Nike Trainers - available in most sizes",
            ImageURL = "/Images/Shoes/Shoes3.png",
            Price = 200,
            Quantity = 70,
            CategoryId = 4
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 21,
            ProductName = "Colorful Hummel Trainers",
            ProductDescription = "Colorful Hummel Trainers - available in most sizes",
            ImageURL = "/Images/Shoes/Shoes4.png",
            Price = 120,
            Quantity = 120,
            CategoryId = 4
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 22,
            ProductName = "Red Nike Trainers",
            ProductDescription = "Red Nike Trainers - available in most sizes",
            ImageURL = "/Images/Shoes/Shoes5.png",
            Price = 200,
            Quantity = 100,
            CategoryId = 4
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 23,
            ProductName = "Birkenstock Sandles",
            ProductDescription = "Birkenstock Sandles - available in most sizes",
            ImageURL = "/Images/Shoes/Shoes6.png",
            Price = 50,
            Quantity = 150,
            CategoryId = 4
        });

        //Add users
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            UserName = "Bob"

        });
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 2,
            UserName = "Sarah"

        });
        //Add Product Categories
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
        {
            Id = 1,
            CategoryName = "Beauty"
        });
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
        {
            Id = 2,
            CategoryName = "Furniture"
        });
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
        {
            Id = 3,
            CategoryName = "Electronics"
        });
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
        {
            Id = 4,
            CategoryName = "Shoes"
        });
    }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<CartItem> CartItem { get; set; }

    public DbSet<Product> Product { get; set; }   

    public DbSet<User> User { get; set; }

    public DbSet<ProductCategory> ProductCategory { get; set; }



}

