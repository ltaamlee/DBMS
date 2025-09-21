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
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            CustomerService customerService = new CustomerService();
            var list = customerService.GetAll(); 
            dgv_customer.DataSource = list;
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_customer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_customer.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void LoadFilterType()
        {
            CustomerService customerService = new CustomerService();
            DataTable dt = customerService.LoadCustomerType();

            cbb_filter.DataSource = dt;
            cbb_filter.DisplayMember = "TenLoai";
            cbb_filter.ValueMember = "MaLoai";
            cbb_filter.SelectedIndex = -1;
        }
        private void cbb_filter_DropDown(object sender, EventArgs e)
        {
            LoadFilterType();
        }

        private void cbb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_filter.SelectedIndex != -1)
            {
                string loaikh = cbb_filter.SelectedValue.ToString();
                CustomerService customerService = new CustomerService();
                var list = customerService.GetByType(loaikh);
                dgv_customer.DataSource = list;
            }
            else LoadData();
        }

        // Thêm mới khách hàng
        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            //txt_id.Text = "";
            //txt_email.ResetText();
            //txt_name.ResetText();
            //txt_address.ResetText();
            //txt_phone.ResetText();
            txt_search.ResetText();

            cbb_filter.SelectedIndex = -1;
            cbb_filter.Text = string.Empty;

            //cbb_sex.SelectedIndex = -1;
            //cbb_sex.Text = string.Empty;

            //cbb_type.SelectedIndex = -1;
            //cbb_type.Text = string.Empty;

            dgv_customer.ClearSelection();
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            //string makh = txt_id.Text;
            //string tenkh = txt_name.Text;
            //string email = txt_email.Text;
            //string sdt = txt_phone.Text;
            //string diachi = txt_address.Text;
            //string gioitinh = cbb_sex.SelectedItem.ToString();
            //string maloai = cbb_type.SelectedValue.ToString();
            //var list = customerService.Update(makh, tenkh, sdt, email, diachi, gioitinh, maloai);
            //if (list != null)
            //{
            //    dgv_customer.DataSource = list;
            //    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LoadData();
            //}
            //else MessageBox.Show("Cập nhật khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sdt = txt_search.Text.Trim();
            CustomerService customerService = new CustomerService();
            var list = customerService.SearchByPhone(sdt);
            dgv_customer.DataSource = list;
            if (list.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
