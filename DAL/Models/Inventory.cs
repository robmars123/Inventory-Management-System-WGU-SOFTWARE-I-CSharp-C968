using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataContext;
using DAL.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class Inventory
    {
        public List<Product> Products { get; set; }
        public List<ProductPart> AllParts { get; set; }

        public void addProduct(Product product)
        {
            using (var context = new InventoryDBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
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
            using (var context = new InventoryDBContext())
            {
                context.ProductParts.Add(part);
                context.SaveChanges();
            }
        }

        public bool deletePart(ProductPart part)
        {
            using (var context = new InventoryDBContext())
            {
                context.ChangeTracker.Clear();
                context.ProductParts.Remove(part);
                context.SaveChanges();
                return true;
            }
        }

        public ProductPart lookupPart(int id)
        {
            return null;
        }

        public void updatePart(int id, ProductPart part)
        {
            using (var context = new InventoryDBContext())
            {
                context.ChangeTracker.Clear();
                context.ProductParts.Update(part);
                context.SaveChanges();
            }
        }
    }
}
