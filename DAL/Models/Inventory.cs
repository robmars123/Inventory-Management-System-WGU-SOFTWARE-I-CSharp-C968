using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Inventory
    {
        public List<Product> Products { get; set; }
        public List<Part> AllParts { get; set; }

        public void addProduct(Product product)
        {

        }

        public bool removeProduct(int id)
        {
            return false; 
        }

        public Product lookupProduct(int id)
        {
            return null;
        }

        public void updateProduct(int id, Product product)
        {

        }

        public void addPart(Part part)
        {

        }

        public bool deletePart(Part part)
        {
            return false;
        }

        public Part lookupPart(int id)
        {
            return null;
        }

        public void updatePart(int id, Part part)
        {

        }
    }
}
