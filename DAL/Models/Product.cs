using DAL.DataContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            AssociatedParts = new List<ProductPart>(); // this.SetAssociatedParts();
        }
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        [ForeignKey("PartID")]
        public virtual List<ProductPart>? AssociatedParts { get; set; }
        private Inventory inventory;

        public void addAssociatedPart(ProductPart part)
        {
            if (AssociatedParts.Any())
            {
                AssociatedParts.Add(part);
            }
            else
                AssociatedParts = (ProductID > 0) ? GetProductAssociatedParts(this.ProductID) : new List<ProductPart>();

        }
        public bool removeAssociatedPart(int id)
        {
            var partToRemove = AssociatedParts.Where(part => part.PartID == id).FirstOrDefault();
            return AssociatedParts.Remove(partToRemove);
        }

        public ProductPart lookupAssociatedPart(int id)
        {
            return null;//AssociatedParts[id];
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
                    result.Add(context.ProductParts.Where(part => part.PartID == partId.PartID).Select(x => x).FirstOrDefault());
                }
            }
            var list = result.RemoveAll(item => item == null);
            return result;
        }

        public void CheckExistingAssociatedParts(List<ProductAssociatedPart> newPartsList, List<ProductPart> deletedList,int productId, string action)
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
               if(newPartsList.Count == 0 || deletedList.Any())
                {
                    for (int i = 0; i < deletedList.Count; i++)
                    {
                        var toDelete = context.ProductAssociatedParts.Where(x => x.PartID == deletedList[i].PartID && x.ProductID == productId).FirstOrDefault();
                        if(toDelete != null)
                        {
                            context.ProductAssociatedParts.Remove(toDelete);
                            context.SaveChanges();
                        }
                    }

                }

            }
        }

        private List<ProductPart> SetAssociatedParts()
        {
            AssociatedParts = new List<ProductPart>();
            return AssociatedParts = GetProductAssociatedParts(ProductID);
        }
    }
}
