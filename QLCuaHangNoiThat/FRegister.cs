using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Model;
using QLCuaHangNoiThat.Service;

namespace QLCuaHangNoiThat
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txt_hoten.ResetText();
            txt_sdt.ResetText();
            txt_email.ResetText();
            txt_username.ResetText();
            txt_passwd.ResetText();
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            txt_hoten.Focus();
            rbtn_admin.Checked = true;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                User user = new User()
                {
                    HoTen = txt_hoten.Text,
                    SDT = txt_sdt.Text,
                    Email = txt_email.Text,
                    ChucVu = rbtn_admin.Checked ? "Quản lý cửa hàng" : "Nhân viên chăm sóc khách hàng",
                    VaiTro = rbtn_admin.Checked ? "QuanLy" : "NhanVien",
                    Username = txt_username.Text,
                    Password = txt_passwd.Text,
                };

                userService.Register(user);
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Hide();
        }
    }
}
