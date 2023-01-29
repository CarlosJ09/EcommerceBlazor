namespace ShopOnline_API.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CartId { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
        
    }
}
