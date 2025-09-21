using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Controller;

namespace QLCuaHangNoiThat
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            ucOverview.BringToFront();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            ucCustomer.BringToFront();
        }

        private void btn_coupon_Click(object sender, EventArgs e)
        {
            ucCoupon.BringToFront();
        }
    }
}
