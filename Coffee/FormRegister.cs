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
    public partial class FormRegister : Form
    {
        Service.CustomerService cs = new Service.CustomerService();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void submitClick(object sender, EventArgs e)
        {
            if (name.Text != "" && phonenumber.Text != "")
            {
                bool register = cs.registerCustomer(name.Text, phonenumber.Text);
                if (register)
                {
                    MessageBox.Show("สมัครสำเร็จ");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("มีหมายเลขโทรศัพท์นี้ในระบบแล้ว กรุณาใส่หมายเลขโทรศัพท์ใหม่อีกครั้ง");
                }
            }
            else
            {
                name.Text = "";
                phonenumber.Text = "";
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");

            }
            
        }

        private void cancelClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
            }
        }

        private void phoneNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
