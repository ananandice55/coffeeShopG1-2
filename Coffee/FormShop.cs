using System;
using System.Linq;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormShop : Form
    {
        private static int count = 0;
        private static string countAmong = "";
        private static int product = 0;
        public static string allSumPrice;
        public static string nameStaff;
        public static string showedDis;
        public static string showedTol;
        FormPayment fpm = new FormPayment();
        Service.PaymentService spms = new Service.PaymentService();
        Service.UserDao ds = new Service.UserDao();
        Service.ProductService sps = new Service.ProductService();
        Service.CustomerService scs = new Service.CustomerService();
        FormRegister fr = new FormRegister();

        public FormShop()
        {
            InitializeComponent();
        }

        private void loadFormShop(object sender, EventArgs e)
        {
            count = 0;
            nameStaff = ds.getUser("", "");
            discountButton.Enabled = false;
            FormPromotion.afterCalculed = "0";
            FormPromotion.totalDiscount = 0;
        }

        private void btnIcedMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnHotMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnTeaMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnMilkMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnFurityMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnBakeryMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void btnWaterMenuClick(object sender, EventArgs e)
        {
            water1.Visible = true;
            water2.Visible = true;
            water3.Visible = true;
            water4.Visible = true;
            water5.Visible = true;
        }

        private void btnSnackMenuClick(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void water1Click(object sender, EventArgs e)
        {
            string findCount = "";
            int sumCount = 0;
            int index = 0;
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumTotal = 0;
            string[] showProduct = sps.selectWater(1);
            string name = showProduct[0];
            string price = showProduct[1];
            string amount = showProduct[2];
            Boolean flag = false;

            for (int i = 0; i < this.showProduct.Rows.Count; i++)
            {
                if (this.showProduct.Rows[i].Cells[0].Value.Equals("น้ำดื่ม Splash"))
                {
                    flag = true;
                    findCount = this.showProduct.Rows[i].Cells[1].Value.ToString();
                    index = i;
                    break;
                }
            }
            for (int j = 0; j < this.showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(this.showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(this.showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += valueData;
                sumTotal += valueData * priceData;
            }
            if (flag == false)
            {
                this.showProduct.Rows.Add();
                this.showProduct.Rows[count].Cells[0].Value = name;
                this.showProduct.Rows[count].Cells[1].Value = amount;
                this.showProduct.Rows[count].Cells[2].Value = price;
                count++;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }
            else
            {
                sumCount = Int32.Parse(findCount);
                sumCount++;
                this.showProduct.Rows[index].Cells[1].Value = sumCount;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }
            totalProduct.Text = sumValue.ToString();
            totalPrice.Text = sumTotal.ToString();
            lblNumberTotalPrice.Text = sumTotal.ToString();
        }

        private void water2Click(object sender, EventArgs e)
        {
            string findCount = "";
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumCount = 0;
            int index = 0;
            int sumTotal = 0;
            string[] showProduct = sps.selectWater(2);
            string name = showProduct[0];
            string price = showProduct[1];
            string amount = showProduct[2];
            Boolean flag = false;

            for (int i = 0; i < this.showProduct.Rows.Count; i++)
            {
                if (this.showProduct.Rows[i].Cells[0].Value.Equals("น้ำดื่ม Singha"))
                {
                    flag = true;
                    findCount = this.showProduct.Rows[i].Cells[1].Value.ToString();
                    index = i;
                    break;
                }
            }
            for (int j = 0; j < this.showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(this.showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(this.showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += valueData;
                sumTotal += valueData * priceData;
            }
            if (flag == false)
            {
                this.showProduct.Rows.Add();
                this.showProduct.Rows[count].Cells[0].Value = name;
                this.showProduct.Rows[count].Cells[1].Value = amount;
                this.showProduct.Rows[count].Cells[2].Value = price;
                count++;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }
            else
            {
                sumCount = Int32.Parse(findCount);
                sumCount++;
                this.showProduct.Rows[index].Cells[1].Value = sumCount;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }

            lblNumberTotalPrice.Text = sumTotal.ToString();
            totalProduct.Text = sumValue.ToString();
            totalPrice.Text = sumTotal.ToString();
        }

        private void water3Click(object sender, EventArgs e)
        {
            string findCount = "";
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumCount = 0;
            int index = 0;
            int sumTotal = 0;
            string[] showProduct = sps.selectWater(3);
            string name = showProduct[0];
            string price = showProduct[1];
            string amount = showProduct[2];
            Boolean flag = false;

            for (int i = 0; i < this.showProduct.Rows.Count; i++)
            {
                if (this.showProduct.Rows[i].Cells[0].Value.Equals("น้ำดื่ม Purra"))
                {
                    flag = true;
                    findCount = this.showProduct.Rows[i].Cells[1].Value.ToString();
                    index = i;
                    break;
                }
            }
            for (int j = 0; j < this.showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(this.showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(this.showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += valueData;
                sumTotal += valueData * priceData;
            }
            if (flag == false)
            {
                this.showProduct.Rows.Add();
                this.showProduct.Rows[count].Cells[0].Value = name;
                this.showProduct.Rows[count].Cells[1].Value = amount;
                this.showProduct.Rows[count].Cells[2].Value = price;
                count++;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }
            else
            {
                sumCount = Int32.Parse(findCount);
                sumCount++;
                this.showProduct.Rows[index].Cells[1].Value = sumCount;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }


            lblNumberTotalPrice.Text = sumTotal.ToString();
            totalProduct.Text = sumValue.ToString();
            totalPrice.Text = sumTotal.ToString();
        }

        private void water4Click(object sender, EventArgs e)
        {
            string findCount = "";
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumCount = 0;
            int index = 0;
            int sumTotal = 0;
            string[] showProduct = sps.selectWater(4);
            string name = showProduct[0];
            string price = showProduct[1];
            string amount = showProduct[2];
            Boolean flag = false;

            for (int i = 0; i < this.showProduct.Rows.Count; i++)
            {
                if (this.showProduct.Rows[i].Cells[0].Value.Equals("น้ำดื่ม Pepsi"))
                {
                    flag = true;
                    findCount = this.showProduct.Rows[i].Cells[1].Value.ToString();
                    index = i;
                    break;
                }
            }
            for (int j = 0; j < this.showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(this.showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(this.showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += valueData;
                sumTotal += valueData * priceData;
            }
            if (flag == false)
            {
                this.showProduct.Rows.Add();
                this.showProduct.Rows[count].Cells[0].Value = name;
                this.showProduct.Rows[count].Cells[1].Value = amount;
                this.showProduct.Rows[count].Cells[2].Value = price;
                count++;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }
            else
            {
                sumCount = Int32.Parse(findCount);
                sumCount++;
                this.showProduct.Rows[index].Cells[1].Value = sumCount;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);
            }

            lblNumberTotalPrice.Text = sumTotal.ToString();
            totalProduct.Text = sumValue.ToString();
            totalPrice.Text = sumTotal.ToString();
        }

        private void water5Click(object sender, EventArgs e)
        {
            string findCount = "";
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumCount = 0;
            int index = 0;
            int sumTotal = 0;
            string[] showProduct = sps.selectWater(5);
            string name = showProduct[0];
            string price = showProduct[1];
            string amount = showProduct[2];
            Boolean flag = false;

            for (int i = 0; i < this.showProduct.Rows.Count; i++)
            {
                if (this.showProduct.Rows[i].Cells[0].Value.Equals("น้ำดื่ม Minere"))
                {
                    flag = true;
                    findCount = this.showProduct.Rows[i].Cells[1].Value.ToString();
                    index = i;
                    break;
                }
            }
            for (int j = 0; j < this.showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(this.showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(this.showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += valueData;
                sumTotal += valueData * priceData;
            }
            if (flag == false)
            {
                this.showProduct.Rows.Add();
                this.showProduct.Rows[count].Cells[0].Value = name;
                this.showProduct.Rows[count].Cells[1].Value = amount;
                this.showProduct.Rows[count].Cells[2].Value = price;
                count++;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);

            }
            else
            {
                sumCount = Int32.Parse(findCount);
                sumCount++;
                this.showProduct.Rows[index].Cells[1].Value = sumCount;
                sumValue += int.Parse(amount);
                sumTotal += int.Parse(price);

            }
            lblNumberTotalPrice.Text = sumTotal.ToString();
            totalProduct.Text = sumValue.ToString();
            totalPrice.Text = sumTotal.ToString();
        }

        private void btnAddProductClick(object sender, EventArgs e)
        {
            try
            {
                int valueData = 0;
                int priceData = 0;
                int sumValue = 0;
                int sumCount = 0;
                int setCount = Int32.Parse(countAmong);
                int setRow = product;
                setCount++;
                showProduct.Rows[setRow].Cells[1].Value = setCount;
                for (int i = 0; i < showProduct.Rows.Count; i++)
                {
                    valueData = int.Parse(showProduct.Rows[i].Cells[1].Value.ToString());
                    priceData = int.Parse(showProduct.Rows[i].Cells[2].Value.ToString());
                    sumValue += valueData;
                    sumCount += valueData * priceData;
                }
                totalProduct.Text = sumValue.ToString();
                totalPrice.Text = sumCount.ToString();
                lblNumberTotalPrice.Text = sumCount.ToString();
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการจะเพิ่มจำนวน");
            }
        }

        private void showProductCellClick(object sender, DataGridViewCellEventArgs e)
        {
            countAmong = showProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            product = e.RowIndex;
        }

        private void btnReduceProdectClick(object sender, EventArgs e)
        {
            try
            {
                int setCount = Int32.Parse(countAmong);
                int setRow = product;
                int valueData = 0;
                int priceData = 0;
                int sumValue = 0;
                int sumCount = 0;
                setCount--;
                if (setCount == 0)
                {
                    showProduct.Rows.RemoveAt(setRow);
                    count--;
                    for (int i = 0; i < showProduct.Rows.Count; i++)
                    {
                        valueData = int.Parse(showProduct.Rows[i].Cells[1].Value.ToString());
                        priceData = int.Parse(showProduct.Rows[i].Cells[2].Value.ToString());
                        sumValue += valueData;
                        sumCount += valueData * priceData;
                    }
                    totalProduct.Text = sumValue.ToString();
                    totalPrice.Text = sumCount.ToString();
                    lblNumberTotalPrice.Text = sumCount.ToString();
                }
                else
                {
                    showProduct.Rows[setRow].Cells[1].Value = setCount;
                    for (int i = 0; i < showProduct.Rows.Count; i++)
                    {
                        valueData = int.Parse(showProduct.Rows[i].Cells[1].Value.ToString());
                        priceData = int.Parse(showProduct.Rows[i].Cells[2].Value.ToString());
                        sumValue += valueData;
                        sumCount += valueData * priceData;

                    }
                    totalProduct.Text = sumValue.ToString();
                    totalPrice.Text = sumCount.ToString();
                    lblNumberTotalPrice.Text = sumCount.ToString();
                }
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการจะลดจำนวน");
            }
        }

        private void btnClearListClick(object sender, EventArgs e)
        {
            try
            {
                int valueData = 0;
                int priceData = 0;
                int sumValue = 0;
                int sumCount = 0;
                int setRow = product;
                showProduct.Rows.RemoveAt(setRow);
                count--;
                for (int i = 0; i < showProduct.Rows.Count; i++)
                {
                    valueData = int.Parse(showProduct.Rows[i].Cells[1].Value.ToString());
                    priceData = int.Parse(showProduct.Rows[i].Cells[2].Value.ToString());
                    sumValue += int.Parse(showProduct.Rows[i].Cells[1].Value.ToString());
                    sumCount += valueData * priceData;
                }
                totalProduct.Text = sumValue.ToString();
                totalPrice.Text = sumCount.ToString();
                lblNumberTotalPrice.Text = sumCount.ToString();
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการจะลบออก");
            }
        }

        private void btnPaymentClick(object sender, EventArgs e)
        {

            if (checkEmptyProduct(showProduct.Rows.Count))
            {
                allSumPrice = lblNumberTotalPrice.Text;
                this.Focus();
                ((Button)btnAddProduct).Enabled = false;
                this.Focus();
                ((Button)btnClearList).Enabled = false;
                this.Focus();
                ((Button)btnReduceProdect).Enabled = false;
                fpm.Show();

                string[] namePd = new string[showProduct.Rows.Count];
                string[] amongPd = new string[showProduct.Rows.Count];
                string[] pricePd = new string[showProduct.Rows.Count];
                for (int i = 0; i < showProduct.Rows.Count; i++)
                {
                    namePd[i] = showProduct.Rows[i].Cells[0].Value.ToString();
                    amongPd[i] = showProduct.Rows[i].Cells[1].Value.ToString();
                    pricePd[i] = showProduct.Rows[i].Cells[2].Value.ToString();
                }
                if (checkEmptyDiscount(lblNumberDistcount.Text))
                {
                    lblNumberDistcount.Text = "0";
                }
                spms.setDetailBill(namePd, amongPd, pricePd, lbshowname.Text, nameStaff, "Coffee Mojave", totalPrice.Text, lblNumberDistcount.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน");
            }
        }

        public bool checkEmptyProduct(int tableCount)
        {
            if (tableCount > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkEmptyDiscount(string discount)
        {
            if(discount.Equals("$ 0.00") || discount.Equals("0"))
            {
                return true;
            }
            return false;
        }
        private void btnCancelClick(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Invalidate();
            this.Hide();
        }

        private void closingFormShop(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void discountButtonClick(object sender, EventArgs e)
        {
            FormPromotion fp = new FormPromotion();
            int valueData = 0;
            int priceData = 0;
            int sumValue = 0;
            int sumCount = 0;
            for (int j = 0; j < showProduct.Rows.Count; j++)
            {
                valueData = int.Parse(showProduct.Rows[j].Cells[1].Value.ToString());
                priceData = int.Parse(showProduct.Rows[j].Cells[2].Value.ToString());
                sumValue += int.Parse(showProduct.Rows[j].Cells[1].Value.ToString());
                sumCount += valueData * priceData;
            }
            allSumPrice = sumCount.ToString();
            fp.Show();

        }

        private void btnInputCustomerClick(object sender, EventArgs e)
        {
            if (lbshowname.Text != "")
            {
                discountButton.Enabled = true;
                lbshowname.Text = scs.getCustomerName(txtIdCustomer.Text);
            }
            else
            {
                discountButton.Enabled = false;
                MessageBox.Show("ไม่พบข้อมูลในระบบ");
            }
        }

        private void activatedFormShop(object sender, EventArgs e)
        {
            if (!totalPrice.Text.Equals("$ 0.00"))
            {
                lblNumberTotalPrice.Text = FormPromotion.afterCalculed;
                lblNumberDistcount.Text = FormPromotion.totalDiscount.ToString();
            }
        }

        private void btnRegisterCustomerClick(object sender, EventArgs e)
        {
            fr.Show();
        }

        private void txtIdCustomerKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
