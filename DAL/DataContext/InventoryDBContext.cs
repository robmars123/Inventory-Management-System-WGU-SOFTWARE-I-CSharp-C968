using DAL.Models;
using DAL.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DAL.DataContext
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionstring = "Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\WGU - 2022 - 2023\\Software I - C# C968\\Inventory Management System App\\Project Solution\\Inventory Management System\\DAL\\AppData\\InventoryDB.mdf\";Integrated Security=True;Database=InventoryDB";
            string connectionstring = "Server=(LocalDB)\\MSSQLLocalDB;attachdbfilename=\"C:\\Inventory Management System\\ClientApp\\AppData\\InventoryDB.mdf\";integrated security=True;";
            //string connectionstring = "Server=(LocalDB)\\MSSQLLocalDB;attachdbfilename=|DataDirectory|\\InventoryDB.mdf;Integrated Security=True;User Instance=False;";
            optionsBuilder.UseSqlServer(connectionstring, builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPart> ProductParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add the shadow property to the model
            // Use the shadow property as a foreign key


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductPart>().ToTable("ProductPart");
        }

    }
}
