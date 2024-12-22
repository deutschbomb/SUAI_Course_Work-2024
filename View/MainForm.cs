
namespace App
{
    public partial class MainForm : Form, IView
    {
        Presenter Presenter;

        public MainForm()
        {
            InitializeComponent();
            Presenter = new Presenter(this);
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employees = new EmployeesForm(ref Presenter, this);
            this.Hide();
            employees.Show();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clients = new ClientsForm(ref Presenter);
            this.Hide();
            clients.Show();
        }

        private void requestsButton_Click(object sender, EventArgs e)
        {
            RequestsForm requests = new RequestsForm(ref Presenter);
            this.Hide();
            requests.Show();
        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            StorageForm storage = new StorageForm(ref Presenter, this);
            this.Hide();
            storage.Show();
        }

        private void logisticsButton_Click(object sender, EventArgs e)
        {
            LogisticsForm logistics = new LogisticsForm(ref Presenter, this);
            this.Hide();
            logistics.Show();
        }
    }
}
