﻿using DAL.Models;
using System.Text.RegularExpressions;
namespace ClientApp.Parts.ModifyPart
{
    public partial class ModifyPart : Form
    {
        private MainScreen mainScreen;
        private ProductPart part = new ProductPart();
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(MainScreen main)
        {
            mainScreen = main;
            InitializeComponent();
        }

        public ModifyPart(MainScreen main, ProductPart _part)
        {
            mainScreen = main;
            part = _part;
            InitializeComponent();
        }

        private void ModifyPart_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ModifyPart_Load(object sender, EventArgs e)
        {
            ControlsValidation();
            textBoxID.Text = part.PartID.ToString();
            textBoxName.Text = part.Name;
            textBoxMax.Text = part.Max.ToString();
            textBoxMin.Text = part.Min.ToString();
            textBoxPriceCost.Text = part.Price.ToString();
            textBoxInventory.Text = part.InStock.ToString();
            textBoxMachineID.Text = (part.MachineID == null || part.MachineID == 0) ? "0" : part.MachineID.ToString();
            textBoxCompanyName.Text = (string.IsNullOrEmpty(part.CompanyName)) ? "" : part.CompanyName.ToString();
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
                part.Name = textBoxName.Text;
                part.Max = Convert.ToInt32(ValidateWholeNumber(textBoxMax));
                part.Min = Convert.ToInt32(ValidateWholeNumber(textBoxMin));
                part.Price = Convert.ToDecimal(textBoxPriceCost.Text);
                part.InStock = Convert.ToInt32(ValidateWholeNumber(textBoxInventory));
                part.MachineID = Convert.ToInt32(ValidateWholeNumber(textBoxMachineID));
                part.CompanyName = textBoxCompanyName.Text;

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

                mainScreen.inventory.updatePart(part.PartID, part);
                mainScreen.loadDataMainscreen();
                this.Close();
            }
            catch (Exception ex)
            {
                return;
            }
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

            if (string.IsNullOrEmpty(textBoxMachineID.Text) || !ValidateNumbersOnly(textBoxMachineID.Text))
                textBoxMachineID.BackColor = Color.LightPink;
            else
                textBoxMachineID.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxCompanyName.Text))
                textBoxCompanyName.BackColor = Color.LightPink;
            else
                textBoxCompanyName.BackColor = Color.White;
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

        private void textBoxMachineID_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void radioInHouseModify_CheckedChanged(object sender, EventArgs e)
        {
            ControlsValidation();
            labelCompanyName.Visible = false;
            textBoxCompanyName.Visible = false;

            labelMachineID.Visible = true;
            textBoxMachineID.Visible = true;
        }

        private void radioOutsourcedModify_CheckedChanged(object sender, EventArgs e)
        {
            ControlsValidation();
            labelMachineID.Visible = false;
            textBoxMachineID.Visible = false;

            labelCompanyName.Visible = true;
            textBoxCompanyName.Visible = true;
        }

        private void textBoxCompanyName_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }
    }
}
