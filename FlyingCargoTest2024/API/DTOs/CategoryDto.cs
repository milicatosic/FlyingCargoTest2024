namespace API.DTOs
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
