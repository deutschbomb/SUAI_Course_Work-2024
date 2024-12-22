
namespace App
{
    public partial class RequestsForm : Form
    {
        Presenter Presenter;

        public RequestsForm(ref Presenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
    }
}
