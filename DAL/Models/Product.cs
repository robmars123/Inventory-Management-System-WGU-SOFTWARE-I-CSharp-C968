using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        public List<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int id)
        {
            return false; //false default for now
        }
        
        public Part lookupAssociatedPart(int id)
        {
            return AssociatedParts[id];
        }
    }
}
