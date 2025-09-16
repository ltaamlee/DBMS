using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLCuaHangNoiThat.Dao
{
    public class UserDao
    {
        private string con = "Data Source=.;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True";

        public string Login(string username, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("sp_DangNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }


        public bool CheckActive(string username)
        {
            using (SqlConnection conn = new SqlConnection(con))
            using (SqlCommand cmd = new SqlCommand("SELECT TrangThai FROM [User] WHERE TenDN = @username", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToBoolean(result);
            }
        }
    }
}
