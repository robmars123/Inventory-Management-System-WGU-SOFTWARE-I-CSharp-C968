using ClientApp.Parts.ModifyPart;
using ClientApp.Parts.AddPart;
using ClientApp.Products.AddProduct;
using ClientApp.Products.ModifyProduct;
using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using DAL.Models.Base;

namespace ClientApp
{
    public partial class MainScreen : Form
    {
        public Inventory inventory = new Inventory();

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
            var selectedPart = new ProductPart(); 
            foreach (DataGridViewRow item in this.dataPartsGrid.SelectedRows)
            {
                if (item.Selected)
                    selectedPart = item.DataBoundItem as ProductPart;
            }

            if(selectedPart.PartID == 0)
            {
                string message = "Please select something to modify.";
                MessageBox.Show(message);
            }
            else
            {
                modifyPartForm = new ModifyPart(this, selectedPart);
                modifyPartForm.Show();
                this.Visible = false;
            }
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = new Product();
            foreach (DataGridViewRow item in this.dataProductGrid.SelectedRows)
            {
                if (item.Selected)
                    selectedProduct = item.DataBoundItem as Product;
            }

            if (selectedProduct.ProductID == 0)
            {
                string message = "Please select something to modify.";
                MessageBox.Show(message);
            }
            else
            {
                modifyProductForm = new ModifyProduct(this, selectedProduct);
                modifyProductForm.Show();
                this.Visible = false;
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProductForm = new AddProduct(this);
            addProductForm.Show();
            this.Visible = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            dataPartsGrid.DataSource = inventory.Parts();
            dataProductGrid.DataSource = inventory.ProductsList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        private void deletePart_Click(object sender, EventArgs e)
        {
            var selectedPart = new ProductPart();

            //Foreach is being used for multi-select but SOFTWARE I – C# — C968 only 1 selection is required.
            foreach (DataGridViewRow item in this.dataPartsGrid.SelectedRows)
            {
                if(item.Selected)
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
                if(result == DialogResult.Yes)
                {
                    inventory.deletePart(selectedPart);
                    loadDataMainscreen();
                }
            }
        }

        public void loadDataMainscreen()
        {
                dataPartsGrid.DataSource = inventory.Parts();
                dataProductGrid.DataSource = inventory.ProductsList();
                dataPartsGrid.ClearSelection();
                dataProductGrid.ClearSelection();
        }

        private void MainScreen_Click(object sender, EventArgs e)
        {
            loadDataMainscreen();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = new Product();

            //Foreach is being used for multi-select but SOFTWARE I – C# — C968 only 1 selection is required.
            foreach (DataGridViewRow item in this.dataProductGrid.SelectedRows)
            {
                if (item.Selected)
                    selectedProduct = item.DataBoundItem as Product;

                //if this product does have children(parts) do not delete it.
                var children = selectedProduct.GetProductAssociatedParts(selectedProduct.ProductID);
                if (children.Any())
                {
                    string message = "This product has associated parts. Could not be deleted. Contact Administrator.";
                    MessageBox.Show(message);
                    return;
                }
            }
            if (selectedProduct.ProductID == 0)
            {
                string message = "Please select something to delete.";
                MessageBox.Show(message);
            }
            else
            {
                string message = "Are you sure you want to delete this product?";
                DialogResult result = MessageBox.Show(message, null, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    inventory.removeProduct(selectedProduct.ProductID);
                    loadDataMainscreen();
                }
            }
        }

        private void searchBoxParts_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchParts_Click(object sender, EventArgs e)
        {
            var selectedParts = new List<ProductPart>();
            var searchedTerm = searchBoxParts.Text.Trim().ToLower(); // Search by Part Name or Part ID
            
            var list = inventory.Parts().Cast<ProductPart>().ToList();

            //search for ID
            if (!string.IsNullOrEmpty(searchedTerm) && searchedTerm.All(char.IsDigit))
                //selectedParts = list.Where(x =>  x.PartID == Convert.ToInt32(searchedTerm)).ToList();
                selectedParts.Add(inventory.lookupPart(Convert.ToInt32(searchedTerm)) as ProductPart) ;
            //search for Name
            else
                selectedParts = list.Where(x => x.Name.ToLower().Contains(searchedTerm)).ToList();

            if (!searchBoxParts.Text.IsNullOrEmpty())
                dataPartsGrid.DataSource = selectedParts;
            else
                dataPartsGrid.DataSource = inventory.Parts();//restore list if no search term applied.

            if (!selectedParts.Any())
            {
                string message = "Part could not be found.";
                MessageBox.Show(message);
            }

            searchBoxParts.Text = String.Empty;

        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            var selectedProducts = new List<Product>();
            var searchedTerm = searchBoxProducts.Text.Trim().ToLower();

            var list = inventory.ProductsList();

            //check for ID
            if (!string.IsNullOrEmpty(searchedTerm) && searchedTerm.All(char.IsDigit))
                selectedProducts = list.Where(x => x.ProductID == Convert.ToInt32(searchedTerm)).ToList();
            //check for Name
            else
                selectedProducts = list.Where(x => x.Name.ToLower().Contains(searchedTerm)).ToList();

            if (!searchBoxProducts.Text.IsNullOrEmpty())
                dataProductGrid.DataSource = selectedProducts;
            else
                dataProductGrid.DataSource = inventory.ProductsList();//restore list if no search term applied.

            if (!selectedProducts.Any())
            {
                string message = "Product could not be found.";
                MessageBox.Show(message);
            }

            searchBoxProducts.Text = String.Empty;
        }
    }
}