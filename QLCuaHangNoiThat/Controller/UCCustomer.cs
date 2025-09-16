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
using QLCuaHangNoiThat.Dao;

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
            CustomerDao customerDao = new CustomerDao();
            var list = customerDao.GetAll(); 
            dgv_customer.DataSource = list;
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
