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

        public int TongKhachHang()
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select dbo.fn_TongSoKhachHang()", conn);
                cmd.CommandType = CommandType.Text;
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaKH, TenKH, TenLoai, SDT from v_DSKhachHang", conn);
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            MaKH = reader["MaKH"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            LoaiKH = new CustomerType
                            {
                                TenLoai = reader["TenLoai"].ToString()
                            },
                            SDT = reader["SDT"].ToString(),
                        };
                        list.Add(c);
                    }
                }
            }
            return list;
        }

        //public List<Customer> GetByType(string maloai)
        //{
        //    List<Customer> list = new List<Customer>();

        //    using (SqlConnection conn = new SqlConnection(con))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("sp_LocKhachHang", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@MaLoai", maloai);
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Customer c = new Customer
        //                {
        //                    MaKH = reader["MaKH"].ToString(),
        //                    HoTen = reader["HoTen"].ToString(),
        //                    SDT = reader["SDT"].ToString(),
        //                    Email = reader["Email"].ToString(),
        //                    DiaChi = reader["DiaChi"].ToString(),
        //                    GioiTinh = reader["GioiTinh"].ToString(),
        //                    MaLoai = reader["MaLoai"].ToString()
        //                };
        //                list.Add(c);
        //            }
        //        }
        //    }
        //    return list;
        //}


        public DataTable LoadCustomerType()
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaLoai, TenLoai from LoaiKhachHang", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public List<Customer> SearchByPhone(string sdt)
        {
            List<Customer> list = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.fn_TimKiemKhachHangTheoSDT(@sdt)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SDT", sdt);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            MaKH = reader["MaKH"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            LoaiKH = new CustomerType
                            {
                                TenLoai = reader["TenLoai"].ToString()
                            },
                            SDT = reader["SDT"].ToString()
                        };
                        list.Add(c);
                    }
                }
            }
            return list;
        }

        public List<Customer> SearchByName(string tenkh)
        {
            List<Customer> list = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.fn_TimKiemKhachHangTheoTen(@tenkh)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TenKH", tenkh);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            MaKH = reader["MaKH"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            LoaiKH = new CustomerType
                            {
                                TenLoai = reader["TenLoai"].ToString()
                            },
                            SDT = reader["SDT"].ToString()
                        };
                        list.Add(c);
                    }
                }
            }
            return list;
        }
        //public List<Customer> Update(string makh, string tenkh, string sdt, string email, string diachi, string gioitinh, string maloai)
        //{
        //    List<Customer> list = new List<Customer>();
        //    using (SqlConnection conn = new SqlConnection(con))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("sp_CapNhatKhachHang", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@MaKH", makh);
        //        cmd.Parameters.AddWithValue("@HoTen", tenkh);
        //        cmd.Parameters.AddWithValue("@SDT", sdt);
        //        cmd.Parameters.AddWithValue("@Email", email);
        //        cmd.Parameters.AddWithValue("@DiaChi", diachi);
        //        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
        //        cmd.Parameters.AddWithValue("@MaLoai", maloai);

        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Customer c = new Customer
        //                    {
        //                        MaKH = reader["MaKH"].ToString(),
        //                        HoTen = reader["HoTen"].ToString(),
        //                        SDT = reader["SDT"].ToString(),
        //                        Email = reader["Email"].ToString(),
        //                        DiaChi = reader["DiaChi"].ToString(),
        //                        GioiTinh = reader["GioiTinh"].ToString(),
        //                        MaLoai = reader["MaLoai"].ToString()
        //                    };
        //                    list.Add(c);
        //                }
        //            }
        //            return list;
        //        }
        //    } 

        //}

        //public List<Customer> GetCoupon()
        //{
        //    List<Customer> list = new List<Customer>();

        //    using (SqlConnection conn = new SqlConnection(con))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("select * from dbo.v_DiemTichLuyKhachHang", conn);
        //        cmd.CommandType = CommandType.Text;
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Customer c = new Customer
        //                {
        //                    MaKH = reader["MaKH"].ToString(),
        //                    HoTen = reader["HoTen"].ToString(),
        //                    SDT = reader["SDT"].ToString(),
        //                    MaLoai = reader["MaLoai"].ToString(),
        //                    DiemTL = Convert.ToInt32(reader["DiemTL"])
        //                };
        //                list.Add(c);
        //            }
        //        }
        //    }
        //    return list;
        //}
    }
}
