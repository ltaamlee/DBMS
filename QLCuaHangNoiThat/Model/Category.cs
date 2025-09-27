using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangNoiThat.Model
{
    public class Category
    {
        public string MaDM { get; set; }
        public string TenDM { get; set; }

        public List<Product> Products { get; set; }
    }
}
