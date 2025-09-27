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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txt_username.Focus();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text.Trim();

            try
            {
                UserService userService = new UserService();
                User user = new User()
                {
                    Username = txt_username.Text,
                    Password = txt_passwd.Text,
                };

                User us = userService.Login(user);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (us.VaiTro == "QuanLy")
                {
                    FAdmin fAdmin = new FAdmin();
                    fAdmin.Show();
                }
                else if (us.VaiTro == "NhanVien")
                {
                    FEmployee fEmployee = new FEmployee();
                    fEmployee.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_passwd.PasswordChar = '\0';
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_passwd.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_passwd.PasswordChar = '*';
            }
        }
    }
}
