using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class Bill
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public float TongTien {  get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }

    }
}
