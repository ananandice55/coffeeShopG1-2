using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Coffee.Service
{
    class CustomerDao
    {
        public string getCustomer(string phoneNumber)
        {
            string name = "";
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<Customer>("Customer");
            BindingList<Customer> doclist = new BindingList<Customer>();
            var query = database.GetCollection<Customer>("Customer");
            var queryCheck = query.AsQueryable().Where(pd => pd.phoneNumber == phoneNumber);
            foreach (var p in queryCheck)
            {
                doclist.Add(p);
                name = p.name;
            }
            return name;
        }

        public bool addCustomer(string name,string phoneNumber)
        {
            bool a = true;
            int count = 0;
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<Customer>("Customer");
            BindingList<Customer> doclist = new BindingList<Customer>();
            Customer add = new Customer();
            var query = database.GetCollection<Customer>("Customer");
            var queryCheck = query.AsQueryable().Where(pd => pd.phoneNumber == phoneNumber);
            foreach (var p in queryCheck)
            {
                count++;
            }
            if (count > 0)
            {
                a = false;
            }
            else
            {
                add.name = name;
                add.phoneNumber = phoneNumber;
                collection.Insert(add);
                a = true;
            }
            return a;
        }

        public class Customer
        {
            public ObjectId _id { get; set; }
            public string name { set; get; }
            public string phoneNumber { set; get; }
        }
    }
}
