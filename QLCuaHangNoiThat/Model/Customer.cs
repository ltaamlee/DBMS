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
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }         
        public string DiaChi { get; set; }
        public CustomerType LoaiKH { get; set; }
        public DateTime NgayTao { get; set; }     
        public string MaNV { get; set; }        


        public Customer() { }
        public List<Customer> customers { get; set; }

        public string TenLoai
        {
            get { return LoaiKH != null ? LoaiKH.TenLoai : ""; }
        }
    }
}
