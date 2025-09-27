using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Service
{
    public class UserService
    {
        private Dao.UserDao userDao = new Dao.UserDao();
        
        public void Register(User user)
        {

            if (string.IsNullOrWhiteSpace(user.HoTen))
                throw new Exception("Họ tên không được để trống");
            if (string.IsNullOrWhiteSpace(user.VaiTro))
                throw new Exception("Vai trò không được để trống");
            if (string.IsNullOrWhiteSpace(user.Email))
                throw new Exception("Số điện thoại không được để trống");
            if (string.IsNullOrWhiteSpace(user.Username))
                throw new Exception("Email không được để trống");
            if (string.IsNullOrWhiteSpace(user.SDT))
                throw new Exception("Username không được để trống");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Password không được để trống");

            userDao.Register(user);
        }

        public User Login(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
                throw new Exception("Username không được để trống");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Password không được để trống");

            return userDao.Login(user);
        }

    }
}
