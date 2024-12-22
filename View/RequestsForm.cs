
namespace App
{
    public partial class RequestsForm : Form
    {
        Presenter Presenter;
        MainForm home;

        public RequestsForm(ref Presenter Presenter, MainForm home)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm(ref Presenter, home, this);
            this.Hide();
            order.Show();
        }

        private void RequestsForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
