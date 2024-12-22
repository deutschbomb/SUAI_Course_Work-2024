
namespace App
{
    public partial class OrderForm : Form
    {
        Presenter Presenter;

        public OrderForm(ref Presenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
    }
}
