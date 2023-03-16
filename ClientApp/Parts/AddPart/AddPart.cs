using DAL.Models;
using System.Text.RegularExpressions;

namespace ClientApp.Parts.AddPart
{
    public partial class AddPart : Form
    {
        private MainScreen mainScreen;
        private Inventory inventory;
        private ProductPart part = new ProductPart();

        private InHouse inHouse;
        private Outsourced outSourced;
        public AddPart()
        {
            InitializeComponent();
        }

        public AddPart(MainScreen main)
        {
            mainScreen = main;
            InitializeComponent();
        }

        private void AddPart_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //fields
            part.Name = textBoxName.Text;
            part.Max = Convert.ToInt32(textBoxMax.Text);
            part.Min = Convert.ToInt32(textBoxMin.Text);
            part.Price = Convert.ToDecimal(textBoxPriceCost.Text);
            part.InStock = Convert.ToInt32(textBoxInventory.Text);
            part.MachineID = Convert.ToInt32(textBoxMachineID.Text);
            part.CompanyName = textBoxCompanyName.Text;

            mainScreen.inventory.addPart(part);

            mainScreen.loadDataMainscreen();

            this.Close();
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private bool ValidateLettersOnly(string letters)
        {
            return Regex.IsMatch(letters, @"^[a-zA-Z]+$");
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

            if (string.IsNullOrEmpty(textBoxMachineID.Text) || !ValidateNumbersOnly(textBoxMachineID.Text))
                textBoxMachineID.BackColor = Color.LightPink;
            else
                textBoxMachineID.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxCompanyName.Text) || !ValidateLettersOnly(textBoxCompanyName.Text))
                textBoxCompanyName.BackColor = Color.LightPink;
            else
                textBoxCompanyName.BackColor = Color.White;
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

        private void textBoxMachineID_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelCompanyName.Visible = false;
            textBoxCompanyName.Visible=false;

            labelMachineID.Visible = true;
            textBoxMachineID.Visible = true;
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelMachineID.Visible = false;
            textBoxMachineID.Visible=false;

            labelCompanyName.Visible = true;
            textBoxCompanyName.Visible = true;
        }

        private void textBoxCompanyName_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }
    }
}
