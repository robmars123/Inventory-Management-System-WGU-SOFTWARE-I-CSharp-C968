using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.Parts.ModifyPart
{
    public partial class ModifyPart : Form
    {
        private MainScreen mainScreen;
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(MainScreen main)
        {
            mainScreen = main;
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
    }
}
