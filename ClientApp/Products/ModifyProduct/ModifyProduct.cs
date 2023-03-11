using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.Products.ModifyProduct
{
    public partial class ModifyProduct : Form
    {
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

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void ModifyProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
