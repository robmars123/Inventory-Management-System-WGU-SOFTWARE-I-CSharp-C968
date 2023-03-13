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

namespace ClientApp.Products.ModifyProduct
{
    public partial class ModifyProduct : Form
    {
        private Product product = new Product();
        private MainScreen mainScreen;
        public ModifyProduct()
        {
            InitializeComponent();
        }

        public ModifyProduct(MainScreen main)
        {
            mainScreen = main;
            InitializeComponent();
        }
        public ModifyProduct(MainScreen main, Product _product)
        {
            mainScreen = main;
            product = _product;
            InitializeComponent();
        }
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            textBoxID.Text = product.ProductID.ToString();
            textBoxName.Text = product.Name;
            textBoxMax.Text = product.Max.ToString();
            textBoxMin.Text = product.Min.ToString();
            textBoxPriceCost.Text = product.Price.ToString();
            textBoxInventory.Text = product.InStock.ToString();
        }

        private void ModifyProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //fields of product to Modify
            product.Name = textBoxName.Text;
            product.Max = Convert.ToInt32(textBoxMax.Text);
            product.Min = Convert.ToInt32(textBoxMin.Text);
            product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
            product.InStock = Convert.ToInt32(textBoxInventory.Text);

            mainScreen.inventory.updateProduct(product.ProductID, product);

            mainScreen.loadDataMainscreen();

            this.Close();
        }
    }
}
