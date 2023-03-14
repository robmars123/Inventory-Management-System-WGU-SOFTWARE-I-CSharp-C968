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
        private List<ProductPart> partList = new List<ProductPart>();
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
            dataPartsCandidate.DataSource = _services.Parts();

            //This would be empty as Add has not happened yet.
            dataPartsAssociated.DataSource = null;
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

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var selectedPart = new ProductPart();
            foreach (DataGridViewRow item in this.dataPartsCandidate.SelectedRows)
            {
                if (item.Selected)
                    selectedPart = item.DataBoundItem as ProductPart;
            }

            partList.Add(selectedPart);
            loadDataMainscreen();
        }

        public void loadDataMainscreen()
        {
            dataPartsCandidate.DataSource = _services.Parts();

            //clear old datasource
            dataPartsAssociated.DataSource = null;
            
            //rebind the list
            dataPartsAssociated.DataSource = partList;

            dataPartsCandidate.ClearSelection();
            dataPartsAssociated.ClearSelection();
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            loadDataMainscreen();
        }
    }
}
