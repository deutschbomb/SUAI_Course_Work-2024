
namespace App
{
    public partial class ClientsForm : Form
    {
        Presenter Presenter;
        MainForm home;

        public ClientsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }

        private void ClientsForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
