using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("ProductCategories")]
    public class ProductCategories
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
