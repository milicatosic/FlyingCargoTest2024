using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = String.Empty;
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
