namespace QLCuaHangNoiThat.Controller
{
    partial class UCSupport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSupport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.calendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.dgv_schedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_time = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat ExtraBold", 22.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(37, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(515, 51);
            this.label8.TabIndex = 27;
            this.label8.Text = "Lịch hẹn tư vấn và hỗ trợ";
            // 
            // calendar
            // 
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Location = new System.Drawing.Point(44, 131);
            this.calendar.Name = "calendar";
            this.calendar.NumberOfWeeksInView = 4;
            this.calendar.SelectedDate = new System.DateTime(2025, 9, 23, 0, 0, 0, 0);
            this.calendar.ShowToolTip = true;
            this.calendar.Size = new System.Drawing.Size(441, 411);
            this.calendar.SpecialDates.Add(((Syncfusion.WinForms.Input.SpecialDate)(resources.GetObject("calendar.SpecialDates"))));
            this.calendar.SpecialDates.Add(((Syncfusion.WinForms.Input.SpecialDate)(resources.GetObject("calendar.SpecialDates1"))));
            this.calendar.SpecialDates.Add(((Syncfusion.WinForms.Input.SpecialDate)(resources.GetObject("calendar.SpecialDates2"))));
            this.calendar.Style.BorderColor = System.Drawing.Color.Transparent;
            this.calendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.White;
            this.calendar.Style.Cell.CellBackColor = System.Drawing.Color.White;
            this.calendar.Style.Cell.CellFont = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Style.Cell.CellForeColor = System.Drawing.Color.Black;
            this.calendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calendar.Style.Cell.SelectedCellFont = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.calendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.calendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.Transparent;
            this.calendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calendar.Style.Cell.TodayFont = new System.Drawing.Font("Montserrat", 10.2F);
            this.calendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calendar.Style.Cell.TrailingCellFont = new System.Drawing.Font("Montserrat", 10.2F);
            this.calendar.Style.Cell.WeekNumberFont = new System.Drawing.Font("Montserrat", 10.2F);
            this.calendar.Style.Header.BackColor = System.Drawing.Color.AntiqueWhite;
            this.calendar.Style.Header.DayNamesBackColor = System.Drawing.Color.DarkSalmon;
            this.calendar.Style.Header.DayNamesFont = new System.Drawing.Font("Montserrat", 10.2F);
            this.calendar.Style.Header.DayNamesForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendar.Style.Header.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Style.Header.ForeColor = System.Drawing.Color.Maroon;
            this.calendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.Maroon;
            this.calendar.TabIndex = 28;
            this.calendar.Text = "Lịch tháng";
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.AllowUserToAddRows = false;
            this.dgv_schedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_schedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_schedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_schedule.ColumnHeadersHeight = 40;
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenKH,
            this.LichHen,
            this.ThoiGian,
            this.ChiTiet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_schedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_schedule.GridColor = System.Drawing.Color.White;
            this.dgv_schedule.Location = new System.Drawing.Point(508, 131);
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.ReadOnly = true;
            this.dgv_schedule.RowHeadersVisible = false;
            this.dgv_schedule.RowHeadersWidth = 51;
            this.dgv_schedule.RowTemplate.Height = 30;
            this.dgv_schedule.Size = new System.Drawing.Size(1097, 411);
            this.dgv_schedule.TabIndex = 29;
            this.dgv_schedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_schedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_schedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_schedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_schedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_schedule.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_schedule.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_schedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgv_schedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_schedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_schedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_schedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_schedule.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_schedule.ThemeStyle.ReadOnly = true;
            this.dgv_schedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_schedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_schedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.dgv_schedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_schedule.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_schedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_schedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.FillWeight = 200F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 71;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Họ tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // LichHen
            // 
            this.LichHen.HeaderText = "Nội dung lịch hẹn";
            this.LichHen.MinimumWidth = 6;
            this.LichHen.Name = "LichHen";
            this.LichHen.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChiTiet.HeaderText = "Hành động";
            this.ChiTiet.Image = global::QLCuaHangNoiThat.Properties.Resources.eye;
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTiet.Width = 138;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.HeaderText = "Hành động";
            this.dataGridViewImageColumn1.Image = global::QLCuaHangNoiThat.Properties.Resources.eye;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(154, 569);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(214, 52);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Lịch hẹn";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbb_time
            // 
            this.cbb_time.AutoRoundedCorners = true;
            this.cbb_time.BackColor = System.Drawing.Color.Transparent;
            this.cbb_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_time.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_time.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_time.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.cbb_time.ForeColor = System.Drawing.Color.Black;
            this.cbb_time.ItemHeight = 40;
            this.cbb_time.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Đầu tuần đến hiện tại",
            "Tháng này",
            "Đầu tháng đến hiện tại",
            "Quý này",
            "Đầu quý đến hiện tại",
            "Năm nay",
            "Đầu năm đến hiện tại",
            "Tuần trước",
            "Tháng trước",
            "Quý trước",
            "Năm trước",
            "Tuần sau",
            "Tháng sau",
            "Năm sau",
            "Tự chọn"});
            this.cbb_time.Location = new System.Drawing.Point(1360, 58);
            this.cbb_time.Name = "cbb_time";
            this.cbb_time.Size = new System.Drawing.Size(257, 46);
            this.cbb_time.TabIndex = 32;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.ItemHeight = 40;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Cá nhân",
            "Quan trọng",
            "Tự chọn"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(1075, 58);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(257, 46);
            this.guna2ComboBox1.TabIndex = 33;
            // 
            // UCSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.cbb_time);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_schedule);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label8);
            this.Name = "UCSupport";
            this.Size = new System.Drawing.Size(1655, 926);
            this.Load += new System.EventHandler(this.UCSupport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Syncfusion.WinForms.Input.SfCalendar calendar;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_schedule;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_time;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewImageColumn ChiTiet;
    }
}
