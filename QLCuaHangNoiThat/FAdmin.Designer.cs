namespace QLCuaHangNoiThat
{
    partial class FAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chamsoc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_detail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_overview = new Guna.UI2.WinForms.Guna2Button();
            this.ucCustomer = new QLCuaHangNoiThat.Controller.UCCustomer();
            this.ucOverview = new QLCuaHangNoiThat.Controller.UCOverview();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Controls.Add(this.btn_chamsoc);
            this.guna2Panel1.Controls.Add(this.btn_detail);
            this.guna2Panel1.Controls.Add(this.btn_overview);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(275, 649);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(35, 561);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(180, 45);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Đăng xuất";
            // 
            // btn_chamsoc
            // 
            this.btn_chamsoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chamsoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chamsoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chamsoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chamsoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chamsoc.ForeColor = System.Drawing.Color.White;
            this.btn_chamsoc.Location = new System.Drawing.Point(35, 262);
            this.btn_chamsoc.Name = "btn_chamsoc";
            this.btn_chamsoc.Size = new System.Drawing.Size(180, 45);
            this.btn_chamsoc.TabIndex = 1;
            this.btn_chamsoc.Text = "Chăm sóc khách hàng";
            // 
            // btn_detail
            // 
            this.btn_detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_detail.ForeColor = System.Drawing.Color.White;
            this.btn_detail.Location = new System.Drawing.Point(35, 184);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(180, 45);
            this.btn_detail.TabIndex = 2;
            this.btn_detail.Text = "Chi tiết khách hàng";
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_overview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_overview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_overview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_overview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_overview.ForeColor = System.Drawing.Color.White;
            this.btn_overview.Location = new System.Drawing.Point(35, 101);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(180, 45);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Tổng quan";
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // ucCustomer
            // 
            this.ucCustomer.Location = new System.Drawing.Point(293, 12);
            this.ucCustomer.Name = "ucCustomer";
            this.ucCustomer.Size = new System.Drawing.Size(1569, 954);
            this.ucCustomer.TabIndex = 6;
            // 
            // ucOverview
            // 
            this.ucOverview.Location = new System.Drawing.Point(305, 36);
            this.ucOverview.Name = "ucOverview";
            this.ucOverview.Size = new System.Drawing.Size(1519, 939);
            this.ucOverview.TabIndex = 7;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ucOverview);
            this.Controls.Add(this.ucCustomer);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_chamsoc;
        private Guna.UI2.WinForms.Guna2Button btn_detail;
        private Guna.UI2.WinForms.Guna2Button btn_overview;
        private Controller.UCCustomer ucCustomer;
        private Controller.UCOverview ucOverview;
    }
}