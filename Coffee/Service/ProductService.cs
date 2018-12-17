using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Service
{
    class ProductService
    {
        Service.ProductDao spd = new ProductDao();
        public string[] selectWater(int select)
        {
            string[] showProduct = spd.selectWater(select);
            return showProduct;
        }
    }
}
