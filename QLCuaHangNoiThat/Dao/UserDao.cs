using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Dao
{
    public class UserDao
    {
        private string con = "Data Source=.;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True";


        public void Register(User user)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoanTheoVaiTro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@VaiTro", user.VaiTro);
                cmd.Parameters.AddWithValue("@HoTen", user.HoTen);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@SDT", user.SDT);
                cmd.Parameters.AddWithValue("@ChucVu", user.ChucVu);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public User Login(User user)
        {
            using (SqlConnection conn = new SqlConnection(con))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user.VaiTro = reader["VaiTro"].ToString();
                        user.HoTen = reader["HoTen"].ToString(); 
                        user.MaNV = reader["MaNV"].ToString();
                        return user;
                    }
                    else
                    {
                        throw new Exception("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
            }
        }
    }
}
