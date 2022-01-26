namespace WebStore.Models
{
    public class Headphones
    {
        public int HeadphonesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Wireless { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
