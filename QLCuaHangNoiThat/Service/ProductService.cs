using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Service
{
    public class ProductService
    {
        private Dao.ProductDao productDao = new Dao.ProductDao();
        public  List<ProductWarranty> GetAll()
        {
            return productDao.GetAll();
        }
    }
}
