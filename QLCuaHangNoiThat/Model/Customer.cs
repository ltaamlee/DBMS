using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class Customer
    {
        public string MaKH { get; set; }          
        public string HoTen { get; set; }        
        public string SDT { get; set; }           
        public string Email { get; set; }         
        public string DiaChi { get; set; }        
        public string GioiTinh { get; set; }     
        public string MaLoai { get; set; }        
        public DateTime NgayDangKy { get; set; }  
        public List<Customer> customers { get; set; }
    }
}
