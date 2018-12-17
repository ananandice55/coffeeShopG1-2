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
    class PromotionDao
    {
        public class Promotion
        {
            public ObjectId _id { get; set; }
            public string number { get; set; }
            public string name { set; get; }
            public string detail { set; get; }
            public double discount { set; get; }
            public string type { set; get; }
        }

        public string[] getPromotion(string discountID)
        {
            double discount = 0.00;
            string typeDiscount = "";
            string[] listPromotion = new string[2];
            MongoClient client = new MongoClient("mongodb://admin:a123456@ds052649.mlab.com:52649/coffeesofdev");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("coffeesofdev");
            MongoCollection collection = database.GetCollection<Promotion>("Promotion");
            BindingList<Promotion> doclist = new BindingList<Promotion>();
            var query = database.GetCollection<Promotion>("Promotion");
            var queryCheck = query.AsQueryable().Where(pd => pd.number == discountID);
            foreach (var p in queryCheck)
            {
                doclist.Add(p);
                discount = p.discount;
                typeDiscount = p.type;

            }
            listPromotion[0] = discount.ToString();
            listPromotion[1] = typeDiscount;

            return listPromotion;
        }

    }
}
