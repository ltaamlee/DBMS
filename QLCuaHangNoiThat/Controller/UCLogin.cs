using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Dao;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private UserDao userDao = new UserDao();
        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        public string Login(string username, string password, string role)
        {
            return userDao.Login(username, password, role);
        }

        public bool CheckActive(string username)
        {
            return userDao.CheckActive(username);
        }
    }
}
