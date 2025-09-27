using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Service;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private UserService userService = new UserService();
        private void UCLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
