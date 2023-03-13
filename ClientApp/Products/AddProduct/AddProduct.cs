using BusinessLogic.Services;
using DAL.DataContext;
using DAL.Models;
using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.Products.AddProduct
{
    public partial class AddProduct : Form
    {
        public Inventory inventory = new Inventory();
        private InventoryService _services = new InventoryService();

        private Product product = new Product();
        private MainScreen mainScreen;
        public AddProduct()
        {
            InitializeComponent();
        }

        public AddProduct(MainScreen main)
        {
            mainScreen = main;
            InitializeComponent();
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
                dataCandidatePartsGrid.DataSource = _services.Parts();
                dataPartsAssociated.DataSource = _services.Products();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //fields
            product.Name = textBoxName.Text;
            product.Max = Convert.ToInt32(textBoxMax.Text);
            product.Min = Convert.ToInt32(textBoxMin.Text);
            product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
            product.InStock = Convert.ToInt32(textBoxInventory.Text);

            mainScreen.inventory.addProduct(product);

            mainScreen.loadDataMainscreen();

            this.Close();
        }
    }
}
