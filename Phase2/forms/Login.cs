using Phase2.forms;
using Phase2.services;

namespace Phase2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login HomePage = new Login();
            HomePage.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminConsole Admin = new AdminConsole();
            Admin.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerProfile Profile = new CustomerProfile();
            Profile.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just click on the login button they do the same thing for right now");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label3.Text = "help";
            label3.Text = "This is a Placeholder Logo";
        }
        // login heads to menu, option to move to profile always available






    }



}
