using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.Products.AddProduct
{
    public partial class AddProduct : Form
    {
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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
