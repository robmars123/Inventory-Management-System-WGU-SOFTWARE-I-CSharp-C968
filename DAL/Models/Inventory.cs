using DAL.DataContext;

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
                product.AssociatedParts = null; //empty
                context.Products.Add(product);
                context.SaveChanges();
            }
            GetNewlyAddedProductID();
        }

        public bool removeProduct(int id)
        {
            using (var context = new InventoryDBContext())
            {
                var product = context.Products.Find(id);
                if (product != null)
                {
                    context.ChangeTracker.Clear();
                    context.Products.Remove(product);
                     context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Product lookupProduct(int id)
        {

            return null;
        }

        public void updateProduct(int id, Product product)
        {
            using (var context = new InventoryDBContext())
            {
                product.AssociatedParts = null; //empty first

                context.ChangeTracker.Clear();
                context.Products.Update(product);
                context.SaveChanges();
            }
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

        //my helper methods/properties below
        public int NewAddedProductId { get; set; }
        private int GetNewlyAddedProductID()
        {
            using (var context = new InventoryDBContext())
            {
                return NewAddedProductId = context.Products.OrderByDescending(x=>x.ProductID).FirstOrDefault().ProductID;
            }
        }


        public List<ProductPart> Parts()
        {
            using (var context = new InventoryDBContext())
            {
                AllParts = context.ProductParts.ToList();
            }
            return AllParts;
        }

        public List<Product> ProductsList()
        {
            using (var context = new InventoryDBContext())
            {
                Products = context.Products.ToList();
            }
            return Products;
        }

    }
}
