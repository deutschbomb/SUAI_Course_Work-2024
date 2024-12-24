
namespace App
{
    public partial class LogisticsForm : Form, IView
    {
        Presenter Presenter;
        MainForm home;
        Form previous;

        public LogisticsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
            this.previous = this.home;
        }

        public LogisticsForm(ref Presenter Presenter, MainForm home, StorageForm prev)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
            this.previous = prev;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.previous = this.previous == this.home ? this.previous : this.home;
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogisticsForm_FormClosed(object sender, EventArgs e)
        {
            this.previous.Show();
        }

    }
}
