using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phase2.forms
{
    public partial class AdminConsole : Form
    {
        public AdminConsole()
        {
            InitializeComponent();
        }

        private void AdminConsole_Load(object sender, EventArgs e)
        {
            txtAdminInfo.Text = "This is the admin console, it will eventually allow menu items to be added and removed, prices to be adjusted, check the status of ongoing orders, as well as all orders currently not complete";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login HomePage = new Login();
            HomePage.Show();
            this.Hide();
        }

        private void btnCompleteAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
