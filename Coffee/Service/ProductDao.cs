using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Service
{
    class ProductDao
    {
        public string[] selectWater(int id)
        {
            string[] water = new string[3];
            string name = "", price = "", among = "";
            if (id == 1)
            {
                name = "น้ำดื่ม Splash";
                price = "40";
                among = "1";
            }
            else if (id == 2)
            {
                name = "น้ำดื่ม Singha";
                price = "25";
                among = "1";
            }
            else if (id == 3)
            {
                name = "น้ำดื่ม Purra";
                price = "35";
                among = "1";
            }
            else if (id == 4)
            {
                name = "น้ำดื่ม Pepsi";
                price = "30";
                among = "1";
            }
            else if (id == 5)
            {
                name = "น้ำดื่ม Minere";
                price = "20";
                among = "1";
            }
            water[0] = name;
            water[1] = price;
            water[2] = among;
            return water;
        }
    }
}
