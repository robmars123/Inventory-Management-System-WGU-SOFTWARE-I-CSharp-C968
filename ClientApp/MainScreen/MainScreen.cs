using ClientApp.Parts.ModifyPart;
using ClientApp.Parts.AddPart;
using ClientApp.Products.AddProduct;
using ClientApp.Products.ModifyProduct;
using DAL.DataContext;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace ClientApp
{
    public partial class MainScreen : Form
    {
        InventoryDBContext db = new InventoryDBContext();
        private AddPart addPartForm;
        private ModifyPart modifyPartForm;

        private AddProduct addProductForm;
        private ModifyProduct modifyProductForm;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            addPartForm = new AddPart(this);
            addPartForm.Show();
            this.Visible = false;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            modifyPartForm = new ModifyPart(this);
            modifyPartForm.Show();
            this.Visible = false;
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            modifyProductForm = new ModifyProduct(this);
            modifyProductForm.Show();
            this.Visible = false;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProductForm = new AddProduct(this);
            addProductForm.Show();
            this.Visible = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            using (var context = new InventoryDBContext())
            {
                context.ChangeTracker.LazyLoadingEnabled = false;
                dataPartsGrid.DataSource = context.ProductParts.ToList();
                dataProductGrid.DataSource = context.Products.ToList();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}