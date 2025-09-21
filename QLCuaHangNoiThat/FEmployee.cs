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
    public partial class FEmployee : Form
    {
        public FEmployee()
        {
            InitializeComponent();
        }

        private void FEmployee_Load(object sender, EventArgs e)
        {
            btn_overview.Visible = false;
            //ucCustomer.btn_delete.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            FLogin fLogin = new FLogin();
            fLogin.Show();
        }
    }
}
