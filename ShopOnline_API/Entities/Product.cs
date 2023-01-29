namespace ShopOnline_API.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ImageURL { get; set; }

        public decimal Price { get; set; }

        public int CategoryId{ get; set;}

        public int Quantity { get; set; }

    }
}
