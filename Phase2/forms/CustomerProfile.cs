using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phase2.forms
{
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login HomePage = new Login();
            HomePage.Show();
            this.Hide();
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            MenuItems MenuPage = new MenuItems();
            MenuPage.Show();
            this.Hide();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            txtProfileInfo.Text = "Please Log in to set profile information";
        }
    }
}
