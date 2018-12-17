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
    class UserDao
    {
        public class User
        {
            public ObjectId _id { get; set; }
            public string username { set; get; }
            public string password { set; get; }
            public string name { set; get; }
        }

        public string getUser(string username,string password)
        {
            string name = "";
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<User>("User");
            BindingList<User> doclist = new BindingList<User>();
            var product = database.GetCollection<User>("User");
            var product1 = product.AsQueryable().Where(pd => pd.name == "ken");
            foreach (var p in product1)
            {
                doclist.Add(p);
                name = p.name;
            }
            return name;
        }

        public Boolean insertUser(string username, string password, string name)
        {
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<User>("User");
            BindingList<User> doclist = new BindingList<User>();
            User user = new User();
            var product = database.GetCollection<User>("User");
            var product2 = product.AsQueryable().Where(pd => pd.username == username);
            string checkuser = "";

            foreach (var p in product2)
            {
                checkuser = p.username;
            }
            if (checkuser.Length > 0)
            {
                return false;
            }
            else
            {
                user.username = username;
                user.password = password;
                user.name = name;
                collection.Insert(user);
                return true;
            }
        }
    }
}
