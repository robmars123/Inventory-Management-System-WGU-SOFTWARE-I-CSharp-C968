using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class ProductAssociatedPart
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("ProductPart")]
        public int PartID { get; set; }
    }
}
