using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Coffee.Service
{
    class PaymentService
    {
        PaymentDao pd = new PaymentDao();
        static List<OrderDetail> list = new List<OrderDetail>();
        private static string totalCusName;
        private static string totalStaffName;
        private static string totalShopName;
        private static double totalDiscount;
        private static double totalOldPrice;
        private double totalSum;
        private double totalCash;
        private double totalChange;

        public void setDetailBill(string[] name, string[] amount, string[] price, string cusName, string staffName, string shopName, string oldPrice, string discount)
        {
            int count = name.Length;
            for (int i = 0; i < count; i++) {
                list.Add(new OrderDetail { name = name[i], amount = int.Parse(amount[i]), price = double.Parse(price[i]) });
            }
            totalCusName = cusName;
            totalStaffName = staffName;
            totalShopName = shopName;
            totalOldPrice = double.Parse(oldPrice);
            totalDiscount = double.Parse(discount);

        }
  
        public void setPrice(double total, double cash, double change)
        {
            totalSum = total;
            totalCash = cash;
            totalChange = change;
        }

        public void setBill()
        {
            pd.insertBill(list, totalCusName, totalStaffName, totalShopName, totalSum, totalCash, totalChange, totalOldPrice, totalDiscount);
        }

        public Object getBill()
        {
            Object detailBill = pd.queryBill();
            return detailBill;
        }

        public class OrderDetail{
            public string name { get ; set ; }
            public int amount { get ; set ; }
            public double price { get ; set ; }
        } 

    }
}
