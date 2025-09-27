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
using QLCuaHangNoiThat.Service;

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCProduct : UserControl
    {
        private ProductService productService = new ProductService();
        public UCProduct()
        {
            InitializeComponent();

        }
        private void LoadData()
        {
            var list = productService.GetAll();
            dgv_product.AutoGenerateColumns = false;
            dgv_product.DataSource = list;
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_product_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_product.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();

        }
        //private void LoadData()
        //{
        //    try
        //    {
        //        var list = productService.GetAll();

        //        // Cho phép tự sinh cột
        //        dgv_product.AutoGenerateColumns = true;

        //        // Gán dữ liệu
        //        dgv_product.DataSource = null;
        //        dgv_product.DataSource = list;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi load dữ liệu: " + ex.Message,
        //                        "Error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}
    }
}
