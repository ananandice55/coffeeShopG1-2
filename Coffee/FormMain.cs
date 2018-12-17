using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormMain : Form
    {
        public FormMain() 
        {
            InitializeComponent();
        }

        private void loadFormMain(object sender, EventArgs e)
        {
            Service.UserDao ds = new Service.UserDao();
            lblShowName.Text = ds.getUser("","");
        }

        private void btnShopClick(object sender, EventArgs e)
        {
            FormShop fs = new FormShop();
            this.Hide();
            fs.Show();
        }

        private void btnEmployeeClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnCustomerClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnProductClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnSettingClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnSignoutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }
        private void closingFormMain(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
