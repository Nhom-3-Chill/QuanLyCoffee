namespace GUI_QLcoffee
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNameLogin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTextMain = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thucDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.thongKeToolStripMenuItem,
            this.huongDanSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "alo";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.doiMatKhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoaDonToolStripMenuItem,
            this.khachHangToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.thucDonToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            this.thongKeToolStripMenuItem.Click += new System.EventHandler(this.thongKeToolStripMenuItem_Click);
            // 
            // huongDanSửDụngToolStripMenuItem
            // 
            this.huongDanSửDụngToolStripMenuItem.Name = "huongDanSửDụngToolStripMenuItem";
            this.huongDanSửDụngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.huongDanSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(9, 33);
            this.lblTenDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(109, 17);
            this.lblTenDN.TabIndex = 1;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(404, 33);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(104, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Người sử dụng:";
            // 
            // lblNameLogin
            // 
            this.lblNameLogin.AutoSize = true;
            this.lblNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLogin.Location = new System.Drawing.Point(112, 34);
            this.lblNameLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameLogin.Name = "lblNameLogin";
            this.lblNameLogin.Size = new System.Drawing.Size(0, 17);
            this.lblNameLogin.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(509, 34);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 17);
            this.lblUserName.TabIndex = 3;
            // 
            // lblTextMain
            // 
            this.lblTextMain.AutoSize = true;
            this.lblTextMain.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextMain.ForeColor = System.Drawing.Color.Red;
            this.lblTextMain.Location = new System.Drawing.Point(230, 66);
            this.lblTextMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextMain.Name = "lblTextMain";
            this.lblTextMain.Size = new System.Drawing.Size(307, 31);
            this.lblTextMain.TabIndex = 4;
            this.lblTextMain.Text = "Phần mềm quản lý coffee";
            this.lblTextMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picMain
            // 
            this.picMain.BackgroundImage = global::GUI_QLcoffee.Properties.Resources.ly_coffee;
            this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMain.Location = new System.Drawing.Point(0, 113);
            this.picMain.Margin = new System.Windows.Forms.Padding(2);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(772, 500);
            this.picMain.TabIndex = 5;
            this.picMain.TabStop = false;
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Dang_xuat1;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.DoiMK1;
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Exit2;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Hoa_Don;
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.hoaDonToolStripMenuItem.Text = "Hóa Đơn";
            this.hoaDonToolStripMenuItem.Click += new System.EventHandler(this.hoaDonToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Khach_hang;
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.khachHangToolStripMenuItem.Text = "Khách Hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Nhan_vien1;
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // thucDonToolStripMenuItem
            // 
            this.thucDonToolStripMenuItem.Image = global::GUI_QLcoffee.Properties.Resources.Thuc_don1;
            this.thucDonToolStripMenuItem.Name = "thucDonToolStripMenuItem";
            this.thucDonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.thucDonToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.thucDonToolStripMenuItem.Text = "Thực Đơn";
            this.thucDonToolStripMenuItem.Click += new System.EventHandler(this.thucDonToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 609);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.lblTextMain);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblNameLogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mếm Quản Lý Coffee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSửDụngToolStripMenuItem;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNameLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTextMain;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thucDonToolStripMenuItem;
    }
}