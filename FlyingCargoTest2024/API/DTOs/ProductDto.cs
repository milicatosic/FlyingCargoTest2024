namespace API.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = String.Empty;
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
