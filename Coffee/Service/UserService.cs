using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Service
{
    class UserService
    {
        public string getUserService(string username,string password)
        {
            UserDao ud = new UserDao();
            return ud.getUser(username,password);
        }

        public void setUserService(string username,string password,string name)
        {
            UserDao ud = new UserDao();
            ud.insertUser(username, password, name);
        }

        public Boolean checkedUser(string username, string password)
        {
            UserDao ud = new UserDao();
            string check = ud.getUser(username, password);
            if (!string.IsNullOrEmpty(check))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
