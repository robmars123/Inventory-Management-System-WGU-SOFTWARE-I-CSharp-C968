using DAL.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("ProductPart")]
    public class ProductPart : Part
    {
        public ProductPart()
        {
            this.MachineID = 0;
        }
        public int? MachineID { get; set; }
        public string? CompanyName { get; set; }
    }
}
