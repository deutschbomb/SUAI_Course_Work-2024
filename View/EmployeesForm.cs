
namespace App
{
    public partial class EmployeesForm : Form
    {
        Presenter Presenter;
        MainForm home;

        public EmployeesForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            birthDatePicker.MinDate = DateTime.Now.AddYears(-18);
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

        private void EmployeesForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
