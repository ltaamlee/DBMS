using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class User
    {
        public string MaNV { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string VaiTro { get; set; }
        public string HoTen { get; set; }      
        public string Email { get; set; }      
        public string SDT { get; set; }
        public string ChucVu { get; set; } = "Nhân viên chăm sóc khách hàng";


        public User() { }

        public User(string manv, string username, string password, string role, string vaitro, string hoten, string sdt, string email, string chucvu)
        {
            MaNV = manv;
            Username = username;
            Password = password;
            VaiTro = role;
            HoTen = hoten;
            SDT = sdt;
            Email = email;
            ChucVu = chucvu;
        }
    }
}
