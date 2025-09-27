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

namespace QLCuaHangNoiThat
{
    public partial class FCalendar : Form
    {
        public FCalendar()
        {
            InitializeComponent();
            LoadLoaiLichHen();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLoaiLichHen()
        {
            CalendarTypeDao calendarTypeDao = new CalendarTypeDao();
            var list = calendarTypeDao.GetAll();
            cbb_calendartype.DataSource = list;
            cbb_calendartype.DisplayMember = "TenLoai";
            cbb_calendartype.ValueMember = "MaLoaiLH";
        }

        private void cbb_calendartype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
