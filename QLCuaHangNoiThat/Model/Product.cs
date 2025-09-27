using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class Product
    {
        public string MaSP { get; set; }     
        public string MaDM { get; set; }      
        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
        public string DonViTinh { get; set; }
        public int SLTon { get; set; }
        public string HangSX { get; set; }

        public Category Category { get; set; }
        public List<Warranty> Warranties { get; set; }

    }
}
