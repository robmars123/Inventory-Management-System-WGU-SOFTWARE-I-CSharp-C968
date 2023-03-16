using DAL.Models;

namespace ClientApp.Products.AddProduct
{
    public partial class AddProduct : Form
    {
        public Inventory inventory = new Inventory();
        private Product product = new Product();
        private List<ProductPart> AssociatedParts = new List<ProductPart>();
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
            dataPartsCandidate.DataSource = inventory.Parts();

            //This would be empty as Add has not happened yet.
            dataPartsAssociated.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //product first fields
            product.Name = textBoxName.Text;
            product.Max = Convert.ToInt32(textBoxMax.Text);
            product.Min = Convert.ToInt32(textBoxMin.Text);
            product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
            product.InStock = Convert.ToInt32(textBoxInventory.Text);

            //add the product to product table
            mainScreen.inventory.addProduct(product);

            //save the list
            AssociatedParts = dataPartsAssociated.DataSource as List<ProductPart>;

            //check if there is any associated parts you want to save
            if (AssociatedParts != null)
            {
                int newlyAddedProductID = mainScreen.inventory.NewAddedProductId;

                foreach (var part in AssociatedParts)
                {
                    var productAssociatedPart = new ProductAssociatedPart();
                    productAssociatedPart.PartID = part.PartID;
                    productAssociatedPart.ProductID = newlyAddedProductID;
                    //save product's selected parts
                    product.SaveProductAssociatedPart(productAssociatedPart);
                }
            }

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

            if (selectedPart.PartID == 0)
            {
                string message = "Please select something to add.";
                MessageBox.Show(message);
            }
            else
            {
                AssociatedParts = (dataPartsAssociated.DataSource != null) ? dataPartsAssociated.DataSource as List<ProductPart> : new List<ProductPart>(); //if null then create instance and add item to it.
                AssociatedParts.Add(selectedPart);

                dataPartsAssociated.DataSource = AssociatedParts;
                loadDataMainscreen();
            }
        }

        public void loadDataMainscreen()
        {
            dataPartsCandidate.DataSource = inventory.Parts();

            //clear old datasource
            dataPartsAssociated.DataSource = null;

            //rebind the datagridview datasource
            dataPartsAssociated.DataSource = AssociatedParts;
            //rebind on product
            product.AssociatedParts = AssociatedParts;
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
                    //delete existing from db
                    product.removeAssociatedPart(selectedPart.PartID);
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
