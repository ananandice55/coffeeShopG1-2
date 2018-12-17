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
    class PaymentDao
    {

        public void insertBill(List<PaymentService.OrderDetail> list, string cusName, string staffName, string shopName, double total, double cash, double change, double oldPrice, double discount)
        {
            int count = 1;
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<Bill>("Bill");
            Bill bill = new Bill();
            var query = database.GetCollection<Bill>("Bill");
            var queryCheck = query.AsQueryable();

            foreach (var i in queryCheck)
            {
                count++;
            }

            bill.shopName = shopName;
            bill.queue = count;
            bill.dateTime = DateTime.Now.ToString();
            bill.customerName = cusName;
            bill.listProduct = list;
            bill.subTotal = Math.Round(oldPrice,2);
            bill.discount = Math.Round(discount,2);
            bill.totalPrice = Math.Round(total,2);
            bill.cash = Math.Round(cash,2);
            bill.change = Math.Round(change,2);
            bill.staffName = staffName;
            collection.Insert(bill);
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย");
        }
        public Object queryBill()
        {
            int count = 0;
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<Bill>("Bill");
            var product = database.GetCollection<Bill>("Bill");
            var queryCheck = product.AsQueryable();
            BindingList<Bill> doclist = new BindingList<Bill>();
            foreach (var i in queryCheck)
            {
                count++;
            }
            //var queryProduct = product.AsQueryable().Last();
            var product2 = product.AsQueryable().Where(pd => pd.queue == count);

            foreach (var p in product2)
            {
                doclist.Add(p);
            }

            return doclist;
        }
        public class Bill
        {
            public ObjectId _id { get; set; }
            public string shopName { get; set; }
            public int queue { get; set; }
            public string dateTime { get; set; }
            public string customerName { get; set; }
            public Object listProduct { get; set; }
            public double subTotal { get; set; }
            public double discount { get; set; }
            public double totalPrice { get; set; }
            public double cash { get; set; }
            public double change { get; set; }
            public string staffName { get; set; }
        }

    }
}
