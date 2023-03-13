using DAL.DataContext;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientApp.Parts.AddPart
{
    public partial class AddPart : Form
    {
        private MainScreen mainScreen;
        private Inventory inventory;
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

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
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

            mainScreen.inventory.addPart(part);

            mainScreen.loadDataMainscreen();

            this.Close();
        }

        private void textBoxInventory_TextChanged(object sender, EventArgs e)
        {
            ControlsValidation();
        }

        private void ControlsValidation()
        {

            if (string.IsNullOrEmpty(textBoxName.Text))
                textBoxName.BackColor = Color.LightPink;
            else
                textBoxName.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxInventory.Text))
                textBoxInventory.BackColor = Color.LightPink;
            else
                textBoxInventory.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxPriceCost.Text))
                textBoxPriceCost.BackColor = Color.LightPink;
            else
                textBoxPriceCost.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxMax.Text))
                textBoxMax.BackColor = Color.LightPink;
            else
                textBoxMax.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxMin.Text))
                textBoxMin.BackColor = Color.LightPink;
            else
                textBoxMin.BackColor = Color.White;

            if (string.IsNullOrEmpty(textBoxMachineID.Text))
                textBoxMachineID.BackColor = Color.LightPink;
            else
                textBoxMachineID.BackColor = Color.White;
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
    }
}
