using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void MO_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MO_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productsPic_Click(object sender, EventArgs e)
        {
            ManageProducts mp = new ManageProducts();
            mp.Show();
            this.Hide();
        }

        private void categoriesPic_Click(object sender, EventArgs e)
        {
            ManageCategories mc = new ManageCategories();
            mc.Show();
            this.Hide();
        }

        private void ordersPic_Click(object sender, EventArgs e)
        {
            ManageOrders mo = new ManageOrders();
            mo.Show();
            this.Hide();
        }

        private void customersPic_Click(object sender, EventArgs e)
        {
            ManageCustomers mcust = new ManageCustomers();
            mcust.Show();
            this.Hide();
        }

        private void usersPic_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();
        }

        private void logoutPic_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
