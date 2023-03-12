using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.Base;

namespace DAL.Models
{
    [Table("Product")]
    public class Product
    {
        
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        [ForeignKey("PartID")]
        public virtual BindingList<ProductPart>? AssociatedParts { get; set; }

        public void addAssociatedPart(ProductPart part)
        {
            //AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int id)
        {
            return false; //false default for now
        }
        
        public ProductPart lookupAssociatedPart(int id)
        {
            return null;//AssociatedParts[id];
        }
    }
}
