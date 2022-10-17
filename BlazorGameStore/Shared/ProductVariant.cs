using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorGameStore.Shared
{
    public class ProductVariant
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Edition Edition { get; set; }
        public int EditionId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
