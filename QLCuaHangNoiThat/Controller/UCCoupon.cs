using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCuaHangNoiThat.Service;

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCCoupon : UserControl
    {
        public UCCoupon()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            CustomerService customerService = new CustomerService();
            //var list = customerService.GetCoupon();
            //dgv_coupon.AutoGenerateColumns = false;
            //dgv_coupon.DataSource = list;
        }
        private void UCCoupon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_policy_Click(object sender, EventArgs e)
        {
            FCoupon fCoupon = new FCoupon();
            fCoupon.ShowDialog();
        }
    }
}
