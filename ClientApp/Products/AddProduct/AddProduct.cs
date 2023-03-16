using DAL.Models;
using System.Text.RegularExpressions;

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
            ControlsValidation();
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
            try
            {
                //product first fields
                product.Name = textBoxName.Text;
                product.Max = Convert.ToInt32(textBoxMax.Text);
                product.Min = Convert.ToInt32(textBoxMin.Text);
                product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
                product.InStock = Convert.ToInt32(textBoxInventory.Text);

                if ((Convert.ToInt32(string.IsNullOrEmpty(textBoxMin.Text) ? "0"
                : textBoxMin.Text) > Convert.ToInt32(string.IsNullOrEmpty(textBoxMax.Text) ? "0"
                : textBoxMax.Text)))
                {
                    string message = "Your minimum exceeds your maximum value.";
                    MessageBox.Show(message);
                    return;
                }

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
            catch (Exception ex)
            {
                return;
            }
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

        private bool ValidateLettersOnly(string letters)
        {
            return Regex.IsMatch(letters, @"^[a-zA-Z ]+$");
        }
        private bool ValidateNumbersOnly(string numbers)
        {
            return Regex.IsMatch(numbers, @"^[0-9]+$");
        }
        private bool ValidateDecimalOnly(string numbers)
        {
            return Regex.IsMatch(numbers, @"^[1-9]\d*(\.\d+)?$");
        }

        private void ControlsValidation()
        {

            if (string.IsNullOrEmpty(textBoxName.Text) || !ValidateLettersOnly(textBoxName.Text))
                textBoxName.BackColor = Color.LightPink;
            else
                textBoxName.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxInventory.Text) || !ValidateNumbersOnly(textBoxInventory.Text))
                textBoxInventory.BackColor = Color.LightPink;
            else
                textBoxInventory.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxPriceCost.Text) || !ValidateDecimalOnly(textBoxPriceCost.Text))
                textBoxPriceCost.BackColor = Color.LightPink;
            else
                textBoxPriceCost.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxMax.Text) || !ValidateNumbersOnly(textBoxMax.Text))
                textBoxMax.BackColor = Color.LightPink;
            else
                textBoxMax.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxMin.Text) || !ValidateNumbersOnly(textBoxMin.Text))
                textBoxMin.BackColor = Color.LightPink;
            else
                textBoxMin.BackColor = Color.White;


            //if required fields are empty, disable Save button
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                   string.IsNullOrEmpty(textBoxInventory.Text) ||
                   string.IsNullOrEmpty(textBoxPriceCost.Text) ||
                   string.IsNullOrEmpty(textBoxMin.Text) ||
                   string.IsNullOrEmpty(textBoxMax.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxPriceCost_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }
    }
}
