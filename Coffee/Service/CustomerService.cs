using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Service
{
    class CustomerService
    {
        CustomerDao cd = new CustomerDao();
        public string getCustomerName(string phonenumber)
        {
            string name = cd.getCustomer(phonenumber);
            return name;
        }

        public bool registerCustomer(string name,string phonenumber)
        {
            bool a = cd.addCustomer(name,phonenumber);
            return a;
        }
    }
}
