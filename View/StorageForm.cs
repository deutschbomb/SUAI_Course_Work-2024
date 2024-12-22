
namespace App
{
    public partial class StorageForm : Form, IView
    {
        Presenter Presenter;
        MainForm home;

        public StorageForm(ref Presenter Presenter, MainForm home)
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

        private void toSupplyButton_Click(object sender, EventArgs e)
        {
            LogisticsForm logistics = new LogisticsForm(ref Presenter, home, this);
            this.Hide();
            logistics.Show();
        }

        private void StorageForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
