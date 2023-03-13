using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
