using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class Warranty
    {
        public string MaBH { get; set; }
        public string MaSP { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TinhTrang { get; set; }

        public Product Product { get; set; }
    }
}
