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
    }
}
