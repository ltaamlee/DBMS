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
        public string HoTen { get; set; }      
        public string Email { get; set; }      
        public string SDT { get; set; }       
        public string VaiTro { get; set; }     
        public bool TrangThai { get; set; }    
        public string TenDN { get; set; }     
        public string MatKhau { get; set; }    


        public User() { }

        public User(string username, string password, string role)
        {
            TenDN = username;
            MatKhau = password;
            VaiTro = role;
        }
    }
}
