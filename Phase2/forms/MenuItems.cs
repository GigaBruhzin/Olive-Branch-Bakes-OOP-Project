using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phase2.forms
{
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Login HomePage = new Login();
            HomePage.Show();
            this.Hide();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderPage PlaceOrder = new OrderPage();
            PlaceOrder.Show();
            this.Hide();
        }

        private void MenuItems_Load(object sender, EventArgs e)
        {
            txtMenuItems.Text = "Insert a menu grid with clickable tiles here";
        }
    }

}
