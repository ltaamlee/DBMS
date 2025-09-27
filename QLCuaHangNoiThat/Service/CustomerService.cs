using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangNoiThat.Dao;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Service
{
    public class CustomerService
    {
        private Dao.CustomerDao customerDao = new Dao.CustomerDao();

        public int TongKhachHang()
        {
            return customerDao.TongKhachHang();
        }

        public List<Customer> GetAll()
        {
            return customerDao.GetAll();
        }

        //public List<Customer> GetByType(string maloai)
        //{
        //    return customerDao.GetByType(maloai);
        //}

        public List<Customer> SearchByPhone(string phone)
        {
            return customerDao.SearchByPhone(phone);
        }

        public List<Customer> SearchByName(string name)
        {
            return customerDao.SearchByName(name);
        }

        //public DataTable LoadCustomerType()
        //{
        //    return customerDao.LoadCustomerType();
        //}

        //public List<Customer> Update(string makh, string tenkh, string sdt, string email, string diachi, string gioitinh, string maloai)
        //{
        //    return customerDao.Update(makh, tenkh, sdt, email, diachi, gioitinh, maloai);
        //}

        //public List<Customer> GetCoupon()
        //{
        //    return customerDao.GetCoupon();
        //}
    }
}
