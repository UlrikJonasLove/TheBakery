namespace Bageriet.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsProductOfTheWeek { get; set; }
        public Category Category { get; set; }
        public string Comment { get; set; }
        public float Ratings { get; set; }
        public float Count { get; set; }
        public float Average { get; set; }
        public int Price { get; set; }
    }
}
