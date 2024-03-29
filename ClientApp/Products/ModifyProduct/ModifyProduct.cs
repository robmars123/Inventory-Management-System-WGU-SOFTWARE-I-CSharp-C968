﻿using DAL.Models;
using DAL.Models.Base;
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

            dataPartsAssociated.DataSource = product.GetProductAssociatedParts(product.ProductID);
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

        private string ValidateWholeNumber(TextBox textbox)
        {
            string errorMessage = string.Empty;
            if (!ValidateNumbersOnly(textbox.Text))
            {
                errorMessage = "Please enter whole number for " + textbox.Name.Replace("textBox", "") + ".";
                MessageBox.Show(errorMessage);
                return "";
            }
            return textbox.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //fields of product to Modify
                product.Name = textBoxName.Text;
                product.Max = Convert.ToInt32(ValidateWholeNumber(textBoxMax));
                product.Min = Convert.ToInt32(ValidateWholeNumber(textBoxMin));
                product.Price = Convert.ToDecimal(textBoxPriceCost.Text);
                product.InStock = Convert.ToInt32(ValidateWholeNumber(textBoxInventory));

                var inventoryValue = (Convert.ToInt32(string.IsNullOrEmpty(textBoxInventory.Text) ? "0" : textBoxInventory.Text));
                var maxValue = (Convert.ToInt32(string.IsNullOrEmpty(textBoxMax.Text) ? "0" : textBoxMax.Text));
                var minValue = (Convert.ToInt32(string.IsNullOrEmpty(textBoxMin.Text) ? "0" : textBoxMin.Text));

                if (minValue > maxValue)
                {
                    string message = "Your minimum exceeds your maximum value.";
                    MessageBox.Show(message);
                    return;
                }

                if (inventoryValue > maxValue || inventoryValue < minValue)
                {
                    string message = "Your inventory is outside of min/max range.";
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
            selectedPart = dataCandidatePartsGrid.SelectedRows[0].DataBoundItem as ProductPart;

            if (selectedPart.PartID == 0)
            {
                string message = "Please select something to add.";
                MessageBox.Show(message);
            }
            else
            {
                product.addAssociatedPart(selectedPart);
                AssociatedParts = product.AssociatedParts;

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
            var list = inventory.Parts().Cast<ProductPart>();

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
