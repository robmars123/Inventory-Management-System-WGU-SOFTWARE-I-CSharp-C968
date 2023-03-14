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

namespace ClientApp.Products.ModifyProduct
{
    public partial class ModifyProduct : Form
    {
        private Product product = new Product();
        private InventoryService _services = new InventoryService();
        private List<ProductPart> partList = new List<ProductPart>();
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

            dataCandidatePartsGrid.DataSource = _services.Parts();

            //This would be empty as Add has not happened yet.
            dataPartsAssociated.DataSource = _services.GetProductAssociatedParts(product.ProductID);
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

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var selectedPart = new ProductPart();
            foreach (DataGridViewRow item in this.dataPartsAssociated.SelectedRows)
            {
                if (item.Selected)
                    selectedPart = item.DataBoundItem as ProductPart;
            }

            partList.Add(selectedPart);
            loadDataMainscreen();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = new ProductPart();

            //Foreach is being used for multi-select but SOFTWARE I – C# — C968 only 1 selection is required.
            foreach (DataGridViewRow item in this.dataPartsAssociated.SelectedRows)
            {
                if (item.Selected)
                    selectedPart = item.DataBoundItem as ProductPart;
            }
            if (selectedPart.PartID == 0)
            {
                string message = "Please select something to delete.";
                MessageBox.Show(message);
            }
            else
            {
                string message = "Are you sure you want to delete this part?";
                DialogResult result = MessageBox.Show(message, null, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    partList.Remove(selectedPart);
                    loadDataMainscreen();
                }
            }
        }
        public void loadDataMainscreen()
        {
            dataCandidatePartsGrid.DataSource = _services.Parts();

            //clear old datasource
            dataPartsAssociated.DataSource = null;

            //rebind the list
            dataPartsAssociated.DataSource = partList;

            dataCandidatePartsGrid.ClearSelection();
            dataPartsAssociated.ClearSelection();
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            loadDataMainscreen();
        }
    }
}
