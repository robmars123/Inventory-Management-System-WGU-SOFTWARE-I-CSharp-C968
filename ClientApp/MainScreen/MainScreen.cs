

using ClientApp.Parts.ModifyPart;
using ClientApp.Parts.AddPart;

namespace ClientApp
{
    public partial class MainScreen : Form
    {
        public AddPart addPartForm;
        public ModifyPart modifyPartForm;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            addPartForm = new AddPart(this);
            addPartForm.Show();
            this.Visible = false;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            modifyPartForm = new ModifyPart(this);
            modifyPartForm.Show();
            this.Visible = false;
        }
    }
}