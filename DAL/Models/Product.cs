using DAL.DataContext;
using DAL.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            AssociatedParts = new List<ProductPart>();
        }
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        [ForeignKey("PartID")]
        public List<ProductPart>? AssociatedParts { get; set; }

        public void addAssociatedPart(ProductPart part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int id)
        {
            var partToRemove = AssociatedParts.Where(part => part.PartID == id).FirstOrDefault();
            return AssociatedParts.Remove(partToRemove);
        }

        //used in GetProductAssociatedParts(int productId).
        public ProductPart lookupAssociatedPart(int id)
        {
            using (var context = new InventoryDBContext())
            {
                return context.ProductParts.Where(part => part.PartID == id).Select(x => x).FirstOrDefault();
            }
        }

        public void SaveProductAssociatedPart(ProductAssociatedPart associatedPart)
        {
            using (var context = new InventoryDBContext())
            {
                context.ChangeTracker.Clear();
                context.ProductAssociatedParts.Add(associatedPart);
                context.SaveChanges();
            }
        }

        //Bridge table model
        public List<ProductPart> GetProductAssociatedParts(int productId)
        {
            var partsListofProduct = new List<ProductAssociatedPart>();
            var result = new List<ProductPart>();
            using (var context = new InventoryDBContext())
            {
                partsListofProduct = context.ProductAssociatedParts.Where(product => product.ProductID == productId).ToList();
                foreach (var partId in partsListofProduct)
                {
                    result.Add(lookupAssociatedPart(partId.PartID));
                }
            }
            var list = result.RemoveAll(item => item == null);
            return result;
        }

        public void CheckExistingAssociatedParts(List<ProductAssociatedPart> newPartsList, List<ProductPart> deletedList, int productId, string action)
        {
            //find the product and if partsList has items, replace the old ones with these.
            //delete old ones with this product 
            using (var context = new InventoryDBContext())
            {
                //get current list
                var currentList = context.ProductAssociatedParts.Where(x => x.ProductID == productId).ToList();

                //if records not exist in this product, save it
                for (int i = 0; i < newPartsList.Count; i++)
                {
                    var isFound = currentList.Any(x => x.PartID == newPartsList[i].PartID);
                    if (!isFound)
                        SaveProductAssociatedPart(newPartsList[i]);
                }

                //if deleted all from grid and pressed save.
                if (newPartsList.Count == 0 || deletedList.Any())
                {
                    for (int i = 0; i < deletedList.Count; i++)
                    {
                        var toDelete = context.ProductAssociatedParts.Where(x => x.PartID == deletedList[i].PartID && x.ProductID == productId).FirstOrDefault();
                        if (toDelete != null)
                        {
                            context.ProductAssociatedParts.Remove(toDelete);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

    }
}
