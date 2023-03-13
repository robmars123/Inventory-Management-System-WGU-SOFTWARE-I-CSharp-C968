using DAL.DataContext;
using DAL.Models;

namespace BusinessLogic.Services
{
    public class InventoryService
    {
        public Inventory inventory;
        public InventoryService()
        {
                inventory  = new Inventory();
        }

        public List<ProductPart> Parts()
        {
            using (var context = new InventoryDBContext())
            {
                inventory.AllParts = context.ProductParts.ToList();
            }
            return inventory.AllParts;
        }

        public List<Product> Products()
        {
            using (var context = new InventoryDBContext())
            {
                inventory.Products = context.Products.ToList();
            }
            return inventory.Products;
        }
    }
}