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
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat
{
    public partial class FAdmin : Form
    {
        private User currentUser;
        public FAdmin()
        {
            InitializeComponent();
            //currentUser = user;
            //lbl_hoten.Text = currentUser.HoTen;
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            ucOverview.BringToFront();
            btn_overview.Checked = true;
            btn_detail.Checked = false;
            btn_product.Checked = false;
            btn_transaction.Checked = false;
            btn_support.Checked = false;
            btn_coupon.Checked = false;

        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            ucOverview.BringToFront();
            btn_overview.Checked = true;
            btn_detail.Checked = false;
            btn_product.Checked = false;
            btn_transaction.Checked = false;
            btn_support.Checked = false;
            btn_coupon.Checked = false;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            ucCustomer.BringToFront();
            btn_overview.Checked = false;
            btn_detail.Checked = true;
            btn_product.Checked = false;
            btn_transaction.Checked = false;
            btn_support.Checked = false;
            btn_coupon.Checked = false;

        }

        private void btn_coupon_Click(object sender, EventArgs e)
        {
            ucCoupon.BringToFront();
            btn_overview.Checked = false;
            btn_detail.Checked = false;
            btn_product.Checked = false;
            btn_transaction.Checked = false;
            btn_support.Checked = false;
            btn_coupon.Checked = true;
        }

        private void btn_support_Click(object sender, EventArgs e)
        {
            ucSupport.BringToFront();
            btn_overview.Checked = false;
            btn_detail.Checked = false;
            btn_product.Checked = false;
            btn_transaction.Checked = false;
            btn_support.Checked = true;
            btn_coupon.Checked = false;
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            ucTransaction.BringToFront();
            btn_overview.Checked = false;
            btn_detail.Checked = false;
            btn_product.Checked = false;
            btn_transaction.Checked = true;
            btn_support.Checked = false;
            btn_coupon.Checked = false;
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ucProduct.BringToFront();
            btn_overview.Checked = false;
            btn_detail.Checked = false;
            btn_product.Checked = true;
            btn_transaction.Checked = false;
            btn_support.Checked = false;
            btn_coupon.Checked = false;
        }
    }
}
