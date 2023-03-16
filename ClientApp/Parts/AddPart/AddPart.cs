using DAL.Models;
using System.Text.RegularExpressions;
namespace ClientApp.Parts.AddPart
{
    public partial class AddPart : Form
    {
        private MainScreen mainScreen;
        private ProductPart part = new ProductPart();

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
            try
            {
                //fields
                part.Name = textBoxName.Text;
                part.Max = Convert.ToInt32(textBoxMax.Text);
                part.Min = Convert.ToInt32(textBoxMin.Text);
                part.Price = Convert.ToDecimal(textBoxPriceCost.Text);
                part.InStock = Convert.ToInt32(textBoxInventory.Text);
                part.MachineID = Convert.ToInt32(textBoxMachineID.Text);
                part.CompanyName = textBoxCompanyName.Text;

                if ((Convert.ToInt32(string.IsNullOrEmpty(textBoxMin.Text) ? "0"
                            : textBoxMin.Text) > Convert.ToInt32(string.IsNullOrEmpty(textBoxMax.Text) ? "0"
                            : textBoxMax.Text)))
                {
                    string message = "Your minimum exceeds your maximum value.";
                    MessageBox.Show(message);
                    return;
                }

                mainScreen.inventory.addPart(part);

                mainScreen.loadDataMainscreen();
                this.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
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
            {
                textBoxName.BackColor = Color.LightPink;
                toolTip1.SetToolTip(textBoxName, "Name requires letters.");
            }
            else
                textBoxName.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxInventory.Text) || !ValidateNumbersOnly(textBoxInventory.Text))
            {
                textBoxInventory.BackColor = Color.LightPink;
                toolTip1.SetToolTip(textBoxInventory, "Inventory requires numbers.");
            }
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
            {
                textBoxMin.BackColor = Color.LightPink;
            }
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


            //if required fields are empty, disable Save button
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                   string.IsNullOrEmpty(textBoxInventory.Text) ||
                   string.IsNullOrEmpty(textBoxPriceCost.Text) ||
                   string.IsNullOrEmpty(textBoxMin.Text) ||
                   string.IsNullOrEmpty(textBoxMax.Text) ||
                   string.IsNullOrEmpty(textBoxMachineID.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
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
            ControlsValidation();
            labelCompanyName.Visible = false;
            textBoxCompanyName.Visible = false;

            labelMachineID.Visible = true;
            textBoxMachineID.Visible = true;
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
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

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxName, "Name requires letters.");
        }
        private void ToolTipHoverValidation(string message, object sender)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 2000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show(message, TB, 30, 10, VisibleTime);
        }

        private void textBoxInventory_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxInventory, "Inventory requires numbers.");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBoxPriceCost_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxPriceCost, "Price requires decimal.");
        }

        private void textBoxMax_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxMax, "Max requires numbers.");
        }

        private void textBoxMin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxMin, "Min requires numbers.");
        }

        private void textBoxCompanyName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxCompanyName, "Company Name requires value.");
        }

        private void textBoxMachineID_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxMachineID, "Machine ID requires numbers.");
        }
    }
}
