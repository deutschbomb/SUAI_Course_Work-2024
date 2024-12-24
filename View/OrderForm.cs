
namespace App
{
    public partial class OrderForm : Form, IView
    {
        Presenter Presenter;
        MainForm home;
        Form previous;


        public OrderForm(ref Presenter Presenter, MainForm home, RequestsForm prev)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
            this.previous = prev;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.previous = this.home;
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_FormClosed(object sender, EventArgs e)
        {
            this.previous.Show();
        }
    }
}
