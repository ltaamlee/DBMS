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
        }
    }
}
