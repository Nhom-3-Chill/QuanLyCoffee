﻿namespace GUI_QLcoffee
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.gpbThongTin = new System.Windows.Forms.GroupBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.NumSoLuong = new System.Windows.Forms.NumericUpDown();
            this.linkKH = new System.Windows.Forms.LinkLabel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnThemmon = new System.Windows.Forms.Button();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gpbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lblHoaDon);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.lblGiamGia);
            this.groupBox1.Controls.Add(this.btnThanhtoan);
            this.groupBox1.Controls.Add(this.txtGiamgia);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.gpbThongTin);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(911, 630);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(773, 18);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(0, 17);
            this.lblTenNV.TabIndex = 23;
            this.lblTenNV.Visible = false;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Red;
            this.lblHoaDon.Location = new System.Drawing.Point(385, 29);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(149, 38);
            this.lblHoaDon.TabIndex = 22;
            this.lblHoaDon.Text = "Hóa Đơn";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTongTien.Location = new System.Drawing.Point(576, 581);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(98, 20);
            this.lblTongTien.TabIndex = 20;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTongtien.Location = new System.Drawing.Point(695, 570);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongtien.Multiline = true;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(133, 45);
            this.txtTongtien.TabIndex = 21;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblGiamGia.Location = new System.Drawing.Point(87, 584);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(85, 20);
            this.lblGiamGia.TabIndex = 18;
            this.lblGiamGia.Text = "Giảm Giá:";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhtoan.Location = new System.Drawing.Point(392, 565);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(144, 53);
            this.btnThanhtoan.TabIndex = 19;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtGiamgia.Location = new System.Drawing.Point(196, 573);
            this.txtGiamgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamgia.Multiline = true;
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(133, 45);
            this.txtGiamgia.TabIndex = 18;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(71, 251);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(773, 288);
            this.dgvHoaDon.TabIndex = 13;
            // 
            // gpbThongTin
            // 
            this.gpbThongTin.Controls.Add(this.cboTenKH);
            this.gpbThongTin.Controls.Add(this.cboTenMon);
            this.gpbThongTin.Controls.Add(this.NumSoLuong);
            this.gpbThongTin.Controls.Add(this.linkKH);
            this.gpbThongTin.Controls.Add(this.lblSoLuong);
            this.gpbThongTin.Controls.Add(this.btnThemmon);
            this.gpbThongTin.Controls.Add(this.lblTenKH);
            this.gpbThongTin.Controls.Add(this.lblTenMon);
            this.gpbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gpbThongTin.Location = new System.Drawing.Point(70, 79);
            this.gpbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Size = new System.Drawing.Size(773, 134);
            this.gpbThongTin.TabIndex = 2;
            this.gpbThongTin.TabStop = false;
            this.gpbThongTin.Text = "Thông Tin";
            // 
            // cboTenKH
            // 
            this.cboTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Items.AddRange(new object[] {
            "Trần Đức Minh",
            "Phạm Lý Hùng",
            "Mai Thế Anh",
            "Trần Đức Thắng",
            "Trần Ngọc Diễm Quỳnh",
            "Phạm Linh Đan"});
            this.cboTenKH.Location = new System.Drawing.Point(236, 82);
            this.cboTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(207, 28);
            this.cboTenKH.TabIndex = 28;
            // 
            // cboTenMon
            // 
            this.cboTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Items.AddRange(new object[] {
            "Cà phê đá",
            "Cà phê đen nóng",
            "Cà phê sữa đá",
            "Cà phê sữa nóng",
            "Lipton đá",
            "Sinh tố bơ",
            "Sinh tố dâu",
            "Trà chanh",
            "Ya - ua đá",
            "Ya - ua trái cây"});
            this.cboTenMon.Location = new System.Drawing.Point(236, 28);
            this.cboTenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(253, 28);
            this.cboTenMon.TabIndex = 27;
            // 
            // NumSoLuong
            // 
            this.NumSoLuong.Location = new System.Drawing.Point(640, 30);
            this.NumSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumSoLuong.Name = "NumSoLuong";
            this.NumSoLuong.Size = new System.Drawing.Size(51, 26);
            this.NumSoLuong.TabIndex = 25;
            // 
            // linkKH
            // 
            this.linkKH.AutoSize = true;
            this.linkKH.Location = new System.Drawing.Point(465, 90);
            this.linkKH.Name = "linkKH";
            this.linkKH.Size = new System.Drawing.Size(24, 20);
            this.linkKH.TabIndex = 24;
            this.linkKH.TabStop = true;
            this.linkKH.Text = "...";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(560, 32);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 20);
            this.lblSoLuong.TabIndex = 23;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // btnThemmon
            // 
            this.btnThemmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThemmon.Image = global::GUI_QLcoffee.Properties.Resources.iconfinder_Add_27831;
            this.btnThemmon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmon.Location = new System.Drawing.Point(549, 70);
            this.btnThemmon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemmon.Name = "btnThemmon";
            this.btnThemmon.Size = new System.Drawing.Size(196, 60);
            this.btnThemmon.TabIndex = 22;
            this.btnThemmon.Text = "Thêm Món";
            this.btnThemmon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemmon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemmon.UseVisualStyleBackColor = true;
            this.btnThemmon.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(69, 90);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(139, 20);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(69, 34);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(79, 20);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên Món:";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 633);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gpbThongTin.ResumeLayout(false);
            this.gpbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox gpbThongTin;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnThemmon;
        private System.Windows.Forms.LinkLabel linkKH;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown NumSoLuong;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.Label lblTenNV;
    }
}