using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormPayment : Form
    {
        
        private static double totalAll = 0;
        private static double totalPayment = 0;
        Service.PaymentService spms = new Service.PaymentService();

        public FormPayment()
        {
            InitializeComponent();
            total.Text = FormShop.allSumPrice;
        }

        private void number1Click(object sender, EventArgs e)
        {
            if(payment.Text.Length <= 7)
            {
                payment.Text += "1";
            }
        }

        private void number2Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "2";
            }
        }

        private void number3Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "3";
            }
        }

        private void number4Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "4";
            }
        }

        private void number5Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "5";
            }
        }

        private void number6Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "6";
            }
        }

        private void number7Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "7";
            }
        }

        private void number8Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "8";
            }
        }

        private void number9Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                payment.Text += "9";
            }
        }

        private void number0Click(object sender, EventArgs e)
        {
            if (payment.Text.Length <= 7)
            {
                if (payment.Text.Length > 1)
                {
                    payment.Text += "0";
                }
            }
        }

        private void btnRemoveClick(object sender, EventArgs e)
        {
            try
            {
                string totalT = payment.Text;
                totalT = totalT.Substring(0, totalT.Length - 1);
                payment.Text = totalT;
            }
            catch (Exception)
            {

            }
        }

        private void closingFormPayment(object sender, FormClosingEventArgs e)
        {
            FormShop fs = new FormShop();
            fs.Show();
    
        }

        private void btnPrintClick(object sender, EventArgs e)
        {

            Object detailBill = spms.getBill();
            var sourceDetailBill = new BindingSource();
            sourceDetailBill.DataSource = detailBill;
            dataGridViewDetailBill.DataSource = sourceDetailBill;

            Object listProducts = dataGridViewDetailBill.Rows[0].Cells[5].Value;
            var sourceListProducts = new BindingSource();
            sourceListProducts.DataSource = listProducts;
            dataGridViewListProducts.DataSource = sourceListProducts;
            createBill();
        }
        private void showBill()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.Print();
        }

        private void createBill()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();
            Font font = new Font("Courier New", 15);
            PaperSize paperSize = new PaperSize("Custom", 100, 200);

            printDialog.Document = printDocument;
            printDialog.Document.DefaultPageSettings.PaperSize = paperSize;
            printDocument.DefaultPageSettings.PaperSize.Height = 820;
            printDocument.DefaultPageSettings.PaperSize.Width = 520;
            printDocument.PrintPage += new PrintPageEventHandler(detailBill);

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                result = printPreviewDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    showBill();
                }
            }
        }

        void detailBill(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int positionX = 50;
            int positionY = 55;
            int gap = 40;
            const int firstDistance = 10;
            const int secondDistance = 10;
            const int thirdDistance = 10;

            graphics.DrawString("คิวที่ No. " + dataGridViewDetailBill.Rows[0].Cells[2].Value,
                    new Font("Courier New", 18),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 40;
            graphics.DrawString("ใบเสร็จ/ใบกำกับภาษีอย่างย่อ",
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            graphics.DrawString("เลขที่: " + dataGridViewDetailBill.Rows[0].Cells[0].Value,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            graphics.DrawString("" + dataGridViewDetailBill.Rows[0].Cells[1].Value,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            graphics.DrawString("วันเวลา: " + dataGridViewDetailBill.Rows[0].Cells[3].Value,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            graphics.DrawString("ชื่อลูกค้า: " + dataGridViewDetailBill.Rows[0].Cells[4].Value,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine,
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString(underLine,
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;

            for (int i = 0; i < dataGridViewListProducts.Rows.Count; i++)
            {
                var name = dataGridViewListProducts.Rows[i].Cells[0].Value;
                var amount = dataGridViewListProducts.Rows[i].Cells[1].Value;
                var price = dataGridViewListProducts.Rows[i].Cells[2].Value;

                gap = gap + 20;
                graphics.DrawString((string.Format(name + "").PadRight(firstDistance + secondDistance)) + (string.Format(amount + "").PadRight(secondDistance)) + (string.Format(price + "").PadRight(thirdDistance)),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            }

            gap = gap + 40;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            graphics.DrawString((string.Format("Sub Total: ").PadRight(firstDistance + secondDistance)) + (string.Format(dataGridViewDetailBill.Rows[0].Cells[6].Value + "").PadLeft(thirdDistance)),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString((string.Format("Discount: ").PadRight(firstDistance + secondDistance)) + (string.Format(dataGridViewDetailBill.Rows[0].Cells[7].Value + "").PadLeft(thirdDistance)),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString((string.Format("Total Price: ").PadRight(firstDistance + secondDistance)) + (string.Format(dataGridViewDetailBill.Rows[0].Cells[8].Value + "").PadLeft(thirdDistance)),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString((string.Format("Cash: ").PadRight(firstDistance + secondDistance)) + (string.Format(dataGridViewDetailBill.Rows[0].Cells[9].Value + "").PadLeft(thirdDistance)),
                   new Font("Courier New", 14),
                   new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString((string.Format("Change: ").PadRight(firstDistance + secondDistance)) + (string.Format(dataGridViewDetailBill.Rows[0].Cells[10].Value + "").PadLeft(thirdDistance)),
                   new Font("Courier New", 14),
                   new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 30;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine,
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 20;
            graphics.DrawString("ชื่อพนักงาน: " + dataGridViewDetailBill.Rows[0].Cells[11].Value,
                   new Font("Courier New", 14),
                   new SolidBrush(Color.Black), positionX, positionY + gap);
            gap = gap + 40;
            graphics.DrawString((string.Format("ขอบคุณที่ใช้บริการ ขอให้เดินทางโดยสวัสดิภาพ ").PadRight(secondDistance + 10)),
                   new Font("Courier New", 14),
                   new SolidBrush(Color.Black), positionX, positionY + gap);
        }

        private void loadFormPayment(object sender, EventArgs e)
        {
            total.Text = FormShop.allSumPrice;
            totalAll = double.Parse(total.Text);
            btnPrint.Enabled = false;
        }

        private void btnSubmitClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(payment.Text))
            {
                double change = 0;
                totalPayment = int.Parse(payment.Text);
                change = totalPayment - totalAll;
                if (change >= 0)
                {
                    crashChange.Text = change.ToString();
                    payment.ReadOnly = true;
                    spms.setPrice(totalAll, totalPayment, change);
                    spms.setBill();
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show("กรุณาใส่เงินให้ครบ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่เงิน");
            }

        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            payment.Text = string.Empty;
            crashChange.Text = string.Empty;
        }

        private void paymentKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
