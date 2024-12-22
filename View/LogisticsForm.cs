
namespace App
{
    public partial class LogisticsForm : Form
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
        private void LogisticsForm_Load(object sender, EventArgs e)
        {
            postDatePicker.MinDate = DateTime.Now;
            deliveryDatePicker.MinDate = DateTime.Now;

            postDatePicker.Value = postDatePicker.MinDate;
            deliveryDatePicker.Value = deliveryDatePicker.MinDate;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

    }
}
