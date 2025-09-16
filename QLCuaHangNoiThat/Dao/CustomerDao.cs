using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Dao
{
    public class CustomerDao
    {
        public string con = "Data Source=.;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True";

        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.v_KhachHang", conn);
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            MaKH = reader["MaKH"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            MaLoai = reader["MaLoai"].ToString()
                        };
                        list.Add(c);
                    }
                }
            }
            return list;
        }
    }
}
