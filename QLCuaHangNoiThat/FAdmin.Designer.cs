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
            this.side_bar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_support = new Guna.UI2.WinForms.Guna2Button();
            this.btn_transaction = new Guna.UI2.WinForms.Guna2Button();
            this.btn_coupon = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_detail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_overview = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.top_bar = new System.Windows.Forms.Panel();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.ucCustomer = new QLCuaHangNoiThat.Controller.UCCustomer();
            this.ucTransaction = new QLCuaHangNoiThat.Controller.UCTransaction();
            this.ucSupport = new QLCuaHangNoiThat.Controller.UCSupport();
            this.ucCoupon = new QLCuaHangNoiThat.Controller.UCCoupon();
            this.ucOverview = new QLCuaHangNoiThat.Controller.UCOverview();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.ucProduct = new QLCuaHangNoiThat.Controller.UCProduct();
            this.side_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.top_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_bar
            // 
            this.side_bar.BackColor = System.Drawing.Color.White;
            this.side_bar.BorderColor = System.Drawing.Color.White;
            this.side_bar.Controls.Add(this.btn_product);
            this.side_bar.Controls.Add(this.btn_support);
            this.side_bar.Controls.Add(this.btn_transaction);
            this.side_bar.Controls.Add(this.btn_coupon);
            this.side_bar.Controls.Add(this.btn_logout);
            this.side_bar.Controls.Add(this.guna2CirclePictureBox1);
            this.side_bar.Controls.Add(this.btn_detail);
            this.side_bar.Controls.Add(this.btn_overview);
            this.side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar.Location = new System.Drawing.Point(0, 0);
            this.side_bar.Name = "side_bar";
            this.side_bar.Size = new System.Drawing.Size(349, 1033);
            this.side_bar.TabIndex = 7;
            // 
            // btn_support
            // 
            this.btn_support.Animated = true;
            this.btn_support.AutoRoundedCorners = true;
            this.btn_support.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.btn_support.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_support.CheckedState.Image = global::QLCuaHangNoiThat.Properties.Resources.support2;
            this.btn_support.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_support.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_support.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_support.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_support.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_support.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_support.ForeColor = System.Drawing.Color.Black;
            this.btn_support.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_support.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_support.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_support.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.support2;
            this.btn_support.Image = global::QLCuaHangNoiThat.Properties.Resources.support;
            this.btn_support.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_support.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_support.IndicateFocus = true;
            this.btn_support.Location = new System.Drawing.Point(35, 672);
            this.btn_support.Name = "btn_support";
            this.btn_support.Size = new System.Drawing.Size(278, 63);
            this.btn_support.TabIndex = 8;
            this.btn_support.Text = "CSKH";
            this.btn_support.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_support.Click += new System.EventHandler(this.btn_support_Click);
            // 
            // btn_transaction
            // 
            this.btn_transaction.Animated = true;
            this.btn_transaction.AutoRoundedCorners = true;
            this.btn_transaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_transaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_transaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_transaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_transaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_transaction.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_transaction.ForeColor = System.Drawing.Color.Black;
            this.btn_transaction.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_transaction.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_transaction.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_transaction.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.CM2;
            this.btn_transaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transaction.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_transaction.IndicateFocus = true;
            this.btn_transaction.Location = new System.Drawing.Point(35, 485);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(278, 63);
            this.btn_transaction.TabIndex = 7;
            this.btn_transaction.Text = "Giao dịch";
            this.btn_transaction.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // btn_coupon
            // 
            this.btn_coupon.Animated = true;
            this.btn_coupon.AutoRoundedCorners = true;
            this.btn_coupon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_coupon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_coupon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_coupon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_coupon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_coupon.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_coupon.ForeColor = System.Drawing.Color.Black;
            this.btn_coupon.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_coupon.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_coupon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_coupon.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.CM2;
            this.btn_coupon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_coupon.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_coupon.IndicateFocus = true;
            this.btn_coupon.Location = new System.Drawing.Point(35, 579);
            this.btn_coupon.Name = "btn_coupon";
            this.btn_coupon.Size = new System.Drawing.Size(278, 63);
            this.btn_coupon.TabIndex = 6;
            this.btn_coupon.Text = "Ưu đãi";
            this.btn_coupon.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_coupon.Click += new System.EventHandler(this.btn_coupon_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.AutoRoundedCorners = true;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_logout.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_logout.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_logout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.CM2;
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_logout.IndicateFocus = true;
            this.btn_logout.Location = new System.Drawing.Point(35, 886);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(278, 63);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::QLCuaHangNoiThat.Properties.Resources.logo1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(35, 28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(109, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_detail
            // 
            this.btn_detail.Animated = true;
            this.btn_detail.AutoRoundedCorners = true;
            this.btn_detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_detail.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_detail.ForeColor = System.Drawing.Color.Black;
            this.btn_detail.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_detail.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_detail.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_detail.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.CM2;
            this.btn_detail.Image = global::QLCuaHangNoiThat.Properties.Resources.CM;
            this.btn_detail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_detail.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_detail.IndicateFocus = true;
            this.btn_detail.Location = new System.Drawing.Point(35, 270);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(278, 63);
            this.btn_detail.TabIndex = 2;
            this.btn_detail.Text = "Khách hàng";
            this.btn_detail.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.Animated = true;
            this.btn_overview.AutoRoundedCorners = true;
            this.btn_overview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_overview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_overview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_overview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_overview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_overview.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_overview.ForeColor = System.Drawing.Color.Black;
            this.btn_overview.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_overview.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_overview.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_overview.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.Home2;
            this.btn_overview.Image = global::QLCuaHangNoiThat.Properties.Resources.overview;
            this.btn_overview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_overview.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_overview.IndicateFocus = true;
            this.btn_overview.Location = new System.Drawing.Point(35, 177);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(278, 63);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Tổng quan";
            this.btn_overview.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1235, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào, ";
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.White;
            this.top_bar.Controls.Add(this.lbl_hoten);
            this.top_bar.Controls.Add(this.label1);
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.Location = new System.Drawing.Point(349, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(1553, 84);
            this.top_bar.TabIndex = 13;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(1389, 28);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(126, 32);
            this.lbl_hoten.TabIndex = 10;
            this.lbl_hoten.Text = "lbl_hoten";
            // 
            // ucCustomer
            // 
            this.ucCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomer.Location = new System.Drawing.Point(0, 0);
            this.ucCustomer.Name = "ucCustomer";
            this.ucCustomer.Size = new System.Drawing.Size(1902, 1033);
            this.ucCustomer.TabIndex = 8;
            // 
            // ucTransaction
            // 
            this.ucTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransaction.Location = new System.Drawing.Point(0, 0);
            this.ucTransaction.Name = "ucTransaction";
            this.ucTransaction.Size = new System.Drawing.Size(1902, 1033);
            this.ucTransaction.TabIndex = 14;
            // 
            // ucSupport
            // 
            this.ucSupport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSupport.Location = new System.Drawing.Point(0, 0);
            this.ucSupport.Name = "ucSupport";
            this.ucSupport.Size = new System.Drawing.Size(1902, 1033);
            this.ucSupport.TabIndex = 12;
            // 
            // ucCoupon
            // 
            this.ucCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCoupon.Location = new System.Drawing.Point(0, 0);
            this.ucCoupon.Name = "ucCoupon";
            this.ucCoupon.Size = new System.Drawing.Size(1902, 1033);
            this.ucCoupon.TabIndex = 10;
            // 
            // ucOverview
            // 
            this.ucOverview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOverview.Location = new System.Drawing.Point(0, 0);
            this.ucOverview.Name = "ucOverview";
            this.ucOverview.Size = new System.Drawing.Size(1902, 1033);
            this.ucOverview.TabIndex = 9;
            // 
            // btn_product
            // 
            this.btn_product.Animated = true;
            this.btn_product.AutoRoundedCorners = true;
            this.btn_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_product.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_product.ForeColor = System.Drawing.Color.Black;
            this.btn_product.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btn_product.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_product.HoverState.Image = global::QLCuaHangNoiThat.Properties.Resources.CM2;
            this.btn_product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_product.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_product.IndicateFocus = true;
            this.btn_product.Location = new System.Drawing.Point(35, 386);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(278, 63);
            this.btn_product.TabIndex = 9;
            this.btn_product.Text = "Sản phẩm";
            this.btn_product.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // ucProduct
            // 
            this.ucProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProduct.Location = new System.Drawing.Point(349, 84);
            this.ucProduct.Name = "ucProduct";
            this.ucProduct.Size = new System.Drawing.Size(1553, 949);
            this.ucProduct.TabIndex = 15;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ucProduct);
            this.Controls.Add(this.top_bar);
            this.Controls.Add(this.side_bar);
            this.Controls.Add(this.ucOverview);
            this.Controls.Add(this.ucCustomer);
            this.Controls.Add(this.ucTransaction);
            this.Controls.Add(this.ucSupport);
            this.Controls.Add(this.ucCoupon);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.side_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.top_bar.ResumeLayout(false);
            this.top_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel side_bar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_detail;
        private Guna.UI2.WinForms.Guna2Button btn_overview;
        private Guna.UI2.WinForms.Guna2Button btn_transaction;
        private Guna.UI2.WinForms.Guna2Button btn_coupon;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_support;
        private Controller.UCCustomer ucCustomer;
        private Controller.UCCoupon ucCoupon;
        private Controller.UCSupport ucSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.Label lbl_hoten;
        private Controller.UCTransaction ucTransaction;
        private Controller.UCOverview ucOverview;
        private Guna.UI2.WinForms.Guna2Button btn_product;
        private Controller.UCProduct ucProduct;
    }
}