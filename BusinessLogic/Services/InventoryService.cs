using DAL.DataContext;
using DAL.Models;
using DAL.Models.Base;

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

        //Bridge table model
        public List<ProductPart> GetProductAssociatedParts(int productId)
        {
            var partsListofProduct = new List<ProductAssociatedPart>();
            var result = new List<ProductPart>();
            using (var context = new InventoryDBContext())
            {
                partsListofProduct = context.ProductAssociatedParts.Where(product=>product.ProductID == productId).ToList();
                foreach (var partId in partsListofProduct)
                {
                    result.Add(Parts().Where(part => part.PartID == partId.PartID).Select(x=>x).FirstOrDefault());
                }               
            }
            var list = result.RemoveAll(item => item == null);
            return result;
        }
    }
}