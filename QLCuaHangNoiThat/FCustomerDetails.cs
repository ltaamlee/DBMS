using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Config;

namespace QLCuaHangNoiThat
{
    public partial class FCustomerDetails : Form
    {
        public FCustomerDetails(string maKH)
        {
            InitializeComponent();
            LoadCustomer(maKH);
        }

        private void FCustomerDetails_Load(object sender, EventArgs e)
        {

        }
        private void LoadCustomer(string maKH)
        {
            try
            {
                DBConnect db = new DBConnect();
                using (SqlConnection conn = db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("select * from v_ChiTietKhachHang where MaKH = @MaKH", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_id.Text = reader["MaKH"]?.ToString() ?? "";
                                txt_name.Text = reader["TenKH"]?.ToString() ?? "";
                                txt_phone.Text = reader["SDT"]?.ToString() ?? "";
                                txt_email.Text = reader["Email"]?.ToString() ?? "";
                                txt_address.Text = reader["DiaChi"]?.ToString() ?? "";
                                dtp_dob.Value = reader["NgaySinh"] != DBNull.Value
                                    ? (DateTime)reader["NgaySinh"]
                                    : DateTime.Today;
                                txt_sex.Text = reader["GioiTinh"]?.ToString() ?? "";
                                txt_createdate.Text = reader["NgayTao"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["NgayTao"]).ToString("dd/MM/yyyy")
                                    : ""; txt_create_emp.Text = reader["MaNV"]?.ToString() ?? "";
                                txt_type.Text = reader["TenLoai"]?.ToString() ?? "Chưa có loại";
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
