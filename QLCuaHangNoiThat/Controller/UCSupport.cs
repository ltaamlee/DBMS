using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangNoiThat.Model;
using Syncfusion.WinForms.Input.Events;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Controls;

namespace QLCuaHangNoiThat.Controller
{
    public partial class UCSupport : UserControl
    {

        public UCSupport()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FCalendar fCalendar = new FCalendar();
            fCalendar.ShowDialog();
        }

        private void UCSupport_Load(object sender, EventArgs e)
        {
        }

    }
}
