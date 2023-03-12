using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.Base;

namespace DAL.Models
{
    public class Inventory
    {
        public List<Product> Products { get; set; }
        public List<ProductPart> AllParts { get; set; }

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

        public void addPart(ProductPart part)
        {

        }

        public bool deletePart(ProductPart part)
        {
            return false;
        }

        public ProductPart lookupPart(int id)
        {
            return null;
        }

        public void updatePart(int id, ProductPart part)
        {

        }
    }
}
