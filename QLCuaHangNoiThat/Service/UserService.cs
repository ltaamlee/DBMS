using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Service
{
    public class UserService
    {
        private Dao.UserDao userDao = new Dao.UserDao();

        public string Login(string username, string password, string role)
        {
            return userDao.Login(username, password, role);
        }

        public bool CheckActive(string username)
        {
            return userDao.CheckActive(username);
        }
    }
}
