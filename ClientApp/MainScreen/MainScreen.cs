

namespace ClientApp
{
    public partial class MainScreen : Form
    {
        public AddPart.AddPart addPartForm;

        public MainScreen()
        {
            InitializeComponent();


        }

        private void addPart_Click(object sender, EventArgs e)
        {
            addPartForm = new AddPart.AddPart(this);
            addPartForm.Show();
            this.Visible = false;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}