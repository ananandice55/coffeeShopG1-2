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
    public partial class FormPromotion : Form
    {
        Service.PromotionService pmsv = new Service.PromotionService();
        

        public static double totalDiscount;
        public static string afterCalculed;

        public FormPromotion()
        {
            InitializeComponent();
        }

        private void cancelClick(object sender, EventArgs e)
        {
            showDiscount.Text = FormShop.allSumPrice;
            totalDiscount = 0;
            afterCalculed = showDiscount.Text;
            this.Close();
        }

        private void loadFormPromotion(object sender, EventArgs e)
        {
            showDiscount.Text = FormShop.allSumPrice;
            if (int.Parse(showDiscount.Text) <= 0)
            {
                promotion1.Enabled = false;
                promotion2.Enabled = false;
                promotion3.Enabled = false;
            }

            if (int.Parse(showDiscount.Text) < 200)
            {
                promotion1.Enabled = false;
            }

            if (int.Parse(showDiscount.Text) < 1000)
            {
                promotion3.Enabled = false;
            }

            if (int.Parse(showDiscount.Text) < 500)
            {
                promotion4.Enabled = false;
            }
        }

        private void clickPromotion1(object sender, EventArgs e)
        {
            selectPromotion("1");
        }

        private void clickPromotion2(object sender, EventArgs e)
        {
            selectPromotion("2");
        }

        private void clickPromotion3(object sender, EventArgs e)
        {
            selectPromotion("3");
        }

        private void clickPromotion4(object sender, EventArgs e)
        {
            selectPromotion("4");
        }

        public void selectPromotion(string id)
        {
            showDiscount.Text = FormShop.allSumPrice;
            double[] listDiscount = pmsv.getPromotion(id, double.Parse(showDiscount.Text));
            totalDiscount = listDiscount[0];
            afterCalculed = listDiscount[1].ToString();
            this.Close();
        }

    }
}
