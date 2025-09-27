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

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCOverview : UserControl
    {
        private CustomerService customerService = new CustomerService();
        public UCOverview()
        {
            InitializeComponent();
        }

        private void UCOverview_Load(object sender, EventArgs e)
        {
            int res = customerService.TongKhachHang();
            lbl_tongkh.Text = res.ToString();
        }
    }
}
