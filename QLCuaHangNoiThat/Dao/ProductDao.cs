using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Config;
using QLCuaHangNoiThat.Model;


namespace QLCuaHangNoiThat.Dao
{
    public class ProductDao
    {
        DBConnect db = new DBConnect();

        public List<ProductWarranty> GetAll()
        {
            List<ProductWarranty> list = new List<ProductWarranty>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaSP, TenSP, TenDM, GiaBan, SLTon, HangSX, NgayBatDau, NgayKetThuc, TinhTrang from v_SanPham_BaoHanh", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductWarranty pw = new ProductWarranty
                    {
                        MaSP = reader["MaSP"].ToString(),
                        TenSP = reader["TenSP"].ToString(),
                        TenDM = reader["TenDM"].ToString(),
                        HangSX = reader["HangSX"].ToString(),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        SLTon = Convert.ToInt32(reader["SLTon"]),
                        NgayBatDau = reader["NgayBatDau"] == DBNull.Value? "" : Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy"),
                        NgayKetThuc = reader["NgayKetThuc"] == DBNull.Value? "" : Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy"),
                        TinhTrang = reader["TinhTrang"] == DBNull.Value? "" : reader["TinhTrang"].ToString()
                    };
                    list.Add(pw);
                }
            }
            return list;
        }
    }
}
