
namespace App
{
    public partial class ClientsForm : Form
    {
        Presenter Presenter;

        public ClientsForm(ref Presenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
    }
}
