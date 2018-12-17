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
    class PromotionService
    {
        public double[] getPromotion(string id, double subTotal)
        {
            double discount = 0;
            PromotionDao pd = new PromotionDao();
            string[] detailDiscout = pd.getPromotion(id);
            if (detailDiscout[1].Equals("percen"))
            {
                discount = (subTotal / 100) * double.Parse(detailDiscout[0]);
            }
            else
            {
                discount = double.Parse(detailDiscout[0]);
            }

            double[] listDiscount = new double[2];
            listDiscount[0] = discount;
            listDiscount[1] = subTotal - discount;

            return listDiscount;
        }
    }
}
