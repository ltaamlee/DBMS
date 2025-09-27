using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangNoiThat.Config;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Dao
{
    public class CalendarTypeDao
    {
        public List<CalendarType> GetAll()
        {
            DBConnect db = new DBConnect();
            List<CalendarType> list = new List<CalendarType>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from LoaiLichHen", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new CalendarType
                    {
                        MaLoaiLH = reader["MaLoaiLH"].ToString(),
                        TenLoai = reader["TenLoai"].ToString()
                    });
                }
            }
            return list;


        }
    }
}
