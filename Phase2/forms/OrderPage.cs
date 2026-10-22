using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phase2.forms
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login HomePage = new Login();
            HomePage.Show();
            this.Hide();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("High Five");
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            double Subtotal = /*placeholder value*/ 20.57;
            double Tax = /*more placeholders*/ Math.Round(Subtotal/10, 2);
            double Total = Math.Round(Subtotal + Tax, 2);

            lblSubtotal.Text = "Subtotal: $" + Subtotal;
            lblTax.Text = "Tax: $" + Tax;
            lblTotal.Text = "Total: $" + Total;

            txtOrderContains.Text = "-insert order details here-";
        }
    }
}
