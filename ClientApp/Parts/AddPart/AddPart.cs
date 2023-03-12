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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

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
    }
}
