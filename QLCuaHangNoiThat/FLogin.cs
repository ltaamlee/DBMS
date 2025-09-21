using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            rbtn_admin.Checked = true;

        }

        //private void btn_show_Click(object sender, EventArgs e)
        //{


        //    if (txt_passwd.PasswordChar == '*')
        //    {
        //        btn_hide.BringToFront();
        //        txt_passwd.PasswordChar = '\0';
        //    }
        //}

        //private void btn_hide_Click(object sender, EventArgs e)
        //{
        //    if (txt_passwd.PasswordChar == '\0')
        //    {
        //        btn_show.BringToFront();
        //        txt_passwd.PasswordChar = '*';
        //    }
        //}

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text.Trim();   
            string role = rbtn_admin.Checked ? "Admin" : "NhanVien";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Controller.UCLogin ucLogin = new Controller.UCLogin();
            string res = ucLogin.Login(username, password, role);
            if (res == "Thành công")
            {
                if (!ucLogin.CheckActive(username))
                {
                    MessageBox.Show("Tài khoản đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    if (role == "Admin")
                    {
                        FAdmin fAdmin = new FAdmin();
                        fAdmin.ShowDialog();
                        
                    }
                    else
                    if (role == "NhanVien")
                    {
                        FEmployee fEmployee = new FEmployee();
                        fEmployee.ShowDialog();
                    }
                }
            }
            else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
