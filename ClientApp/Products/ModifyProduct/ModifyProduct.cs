using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

namespace ClientApp.Products.ModifyProduct
{
    public partial class ModifyProduct : Form
    {
        private Product product = new Product();
        private Inventory inventory = new Inventory();
        private List<ProductPart> AssociatedParts = new List<ProductPart>();
        private List<ProductPart> deletedList = new List<ProductPart>();
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

            dataCandidatePartsGrid.DataSource = inventory.Parts();

            //This would be empty as Add has not happened yet.
            dataPartsAssociated.DataSource = product.GetProductAssociatedParts(product.ProductID);
            //populate list
            AssociatedParts = (dataPartsAssociated.DataSource != null) ?
                                    dataPartsAssociated.DataSource as List<ProductPart> :
                                                        new List<ProductPart>(); //if null then create instance and add item to it.
            if (!product.AssociatedParts.Any())
                product.AssociatedParts = AssociatedParts;

            ControlsValidation();
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
            try
            {
                //fields of product to Modify
                product.Name = textBoxName.Text;
                product.Max = Convert.ToInt32(textBoxMax.Text);
                product.Min = Convert.ToInt32(textBoxMin.Text);
                product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
                product.InStock = Convert.ToInt32(textBoxInventory.Text);

                //validate minimum and maximum
                if ((Convert.ToInt32(string.IsNullOrEmpty(textBoxMin.Text) ? "0"
                : textBoxMin.Text) > Convert.ToInt32(string.IsNullOrEmpty(textBoxMax.Text) ? "0"
                : textBoxMax.Text)))
                {
                    string message = "Your minimum exceeds your maximum value.";
                    MessageBox.Show(message);
                    return;
                }

                AssociatedParts = dataPartsAssociated.DataSource as List<ProductPart>;
                if (AssociatedParts != null)
                {
                    //check if parts already exist with productID
                    var templist = new List<ProductAssociatedPart>();
                    foreach (var part in AssociatedParts)
                    {
                        var productAssociatedParts = new ProductAssociatedPart()
                        {
                            PartID = part.PartID,
                            ProductID = product.ProductID
                        };
                        templist.Add(productAssociatedParts);
                    }
                    product.CheckExistingAssociatedParts(templist, deletedList, product.ProductID, "Save");
                }

                inventory.updateProduct(product.ProductID, product);
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
            foreach (DataGridViewRow item in this.dataCandidatePartsGrid.SelectedRows)
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
                AssociatedParts = dataPartsAssociated.DataSource as List<ProductPart>;
                AssociatedParts.Add(selectedPart);
                dataPartsAssociated.DataSource = AssociatedParts;
                loadDataMainscreen();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = new ProductPart();

            //Foreach is being used for multi-select but SOFTWARE I – C# — C968 only 1 selection is required.
            foreach (DataGridViewRow item in this.dataPartsAssociated.SelectedRows)
            {
                if (item.Selected)
                    selectedPart = item.DataBoundItem as ProductPart;

                if (!deletedList.Contains(selectedPart))
                    deletedList.Add(selectedPart);
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
        public void loadDataMainscreen()
        {
            dataCandidatePartsGrid.DataSource = inventory.Parts();

            //clear old datasource
            dataPartsAssociated.DataSource = null;

            //rebind the list
            dataPartsAssociated.DataSource = product.AssociatedParts;
            dataCandidatePartsGrid.ClearSelection();
            dataPartsAssociated.ClearSelection();
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            loadDataMainscreen();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedParts = new List<ProductPart>();
            var searchedTerm = searchBoxParts.Text.Trim().ToLower(); // Search by Part Name or Part ID


            var list = inventory.Parts();

            //check for ID
            if (!string.IsNullOrEmpty(searchedTerm) && searchedTerm.All(char.IsDigit))
                selectedParts = list.Where(x => x.PartID == Convert.ToInt32(searchedTerm)).ToList();
            //check for Name
            else
                selectedParts = list.Where(x => x.Name.ToLower().Contains(searchedTerm)).ToList();

            if (!searchBoxParts.Text.IsNullOrEmpty())
                dataCandidatePartsGrid.DataSource = selectedParts;
            else
                dataCandidatePartsGrid.DataSource = inventory.Parts();//restore list if no search term applied.

            if (!selectedParts.Any())
            {
                string message = "Part could not be found.";
                MessageBox.Show(message);
            }

            searchBoxParts.Text = String.Empty;
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
