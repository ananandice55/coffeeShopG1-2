using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

class dataService
{
    public static string name;
    public class user
    {
        public ObjectId _id { get; set; }
        public string username { set; get; }
        public string password { set; get; }
        public string name { set; get; }
    }

    public class shop
    {
        public Object _id { get; set; }
        public string product { get; set; }
        public string price { get; set; }
        public string size { get; set; }
        public string detail { get; set; }
        public string totalPrice { get; set; }
        public string inCome { get; set; }
    }

    public class customer
    {
        public Object _id { get; set; }
        public string name { get; set; }
        public string id { get; set; }

    }

    public string getUser()
    {
        string name = "";
        MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
        MongoServer server = client.GetServer();
        MongoDatabase database = server.GetDatabase("coffeesofdev");
        MongoCollection collection = database.GetCollection<user>("user");
        BindingList<user> doclist = new BindingList<user>();
        var product = database.GetCollection<user>("user");
        var product1 = product.AsQueryable().Where(pd => pd.name == "ken");
        foreach (var p in product1)
        {
            doclist.Add(p);
            name = p.name;
        }
        return name;
    }

}

