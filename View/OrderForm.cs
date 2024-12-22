
namespace App
{
    public partial class OrderForm : Form
    {
        Presenter Presenter;
        MainForm home;
        RequestsForm previous;


        public OrderForm(ref Presenter Presenter, MainForm home, RequestsForm prev)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
            this.previous = prev;
        }

        private void OrderForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
