﻿namespace GUI_QLcoffee
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.rdbtnNgungHD = new System.Windows.Forms.RadioButton();
            this.gpbVaiTro = new System.Windows.Forms.GroupBox();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdbtnNV = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbtnHD = new System.Windows.Forms.RadioButton();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.gpbNhanvien = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gpbThongTin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbVaiTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.gpbNhanvien.SuspendLayout();
            this.gpbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblNhanVien.Location = new System.Drawing.Point(269, 16);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(133, 29);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân Viên";
            // 
            // rdbtnNgungHD
            // 
            this.rdbtnNgungHD.AutoSize = true;
            this.rdbtnNgungHD.Location = new System.Drawing.Point(215, 117);
            this.rdbtnNgungHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnNgungHD.Name = "rdbtnNgungHD";
            this.rdbtnNgungHD.Size = new System.Drawing.Size(129, 20);
            this.rdbtnNgungHD.TabIndex = 17;
            this.rdbtnNgungHD.TabStop = true;
            this.rdbtnNgungHD.Text = "Ngừng hoạt động";
            this.rdbtnNgungHD.UseVisualStyleBackColor = true;
            // 
            // gpbVaiTro
            // 
            this.gpbVaiTro.Controls.Add(this.rdbtnAdmin);
            this.gpbVaiTro.Controls.Add(this.rdbtnNV);
            this.gpbVaiTro.Controls.Add(this.groupBox4);
            this.gpbVaiTro.Location = new System.Drawing.Point(104, 79);
            this.gpbVaiTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbVaiTro.Name = "gpbVaiTro";
            this.gpbVaiTro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbVaiTro.Size = new System.Drawing.Size(175, 32);
            this.gpbVaiTro.TabIndex = 12;
            this.gpbVaiTro.TabStop = false;
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(111, 11);
            this.rdbtnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(64, 20);
            this.rdbtnAdmin.TabIndex = 15;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Admin";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbtnNV
            // 
            this.rdbtnNV.AutoSize = true;
            this.rdbtnNV.Location = new System.Drawing.Point(10, 11);
            this.rdbtnNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnNV.Name = "rdbtnNV";
            this.rdbtnNV.Size = new System.Drawing.Size(88, 20);
            this.rdbtnNV.TabIndex = 14;
            this.rdbtnNV.TabStop = true;
            this.rdbtnNV.Text = "Nhân Viên";
            this.rdbtnNV.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(4, 30);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(175, 32);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // rdbtnHD
            // 
            this.rdbtnHD.AutoSize = true;
            this.rdbtnHD.Location = new System.Drawing.Point(113, 120);
            this.rdbtnHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnHD.Name = "rdbtnHD";
            this.rdbtnHD.Size = new System.Drawing.Size(90, 20);
            this.rdbtnHD.TabIndex = 16;
            this.rdbtnHD.TabStop = true;
            this.rdbtnHD.Text = "Hoạt Động";
            this.rdbtnHD.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDienThoai.Location = new System.Drawing.Point(436, 86);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(184, 26);
            this.txtDienThoai.TabIndex = 11;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDienThoai.Location = new System.Drawing.Point(352, 95);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(81, 17);
            this.lblDienThoai.TabIndex = 10;
            this.lblDienThoai.Text = "Điện Thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtEmail.Location = new System.Drawing.Point(436, 12);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDiaChi.Location = new System.Drawing.Point(436, 49);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(184, 26);
            this.txtDiaChi.TabIndex = 8;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDiaChi.Location = new System.Drawing.Point(352, 57);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 17);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblEmail.Location = new System.Drawing.Point(352, 20);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTenNV.Location = new System.Drawing.Point(127, 49);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(184, 26);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaNV.Location = new System.Drawing.Point(127, 12);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(184, 26);
            this.txtMaNV.TabIndex = 4;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTinhTrang.Location = new System.Drawing.Point(20, 119);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(82, 17);
            this.lblTinhTrang.TabIndex = 3;
            this.lblTinhTrang.Text = "Tình Trạng:";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblVaiTro.Location = new System.Drawing.Point(20, 91);
            this.lblVaiTro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(58, 17);
            this.lblVaiTro.TabIndex = 2;
            this.lblVaiTro.Text = "Vai Trò:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTenNV.Location = new System.Drawing.Point(20, 57);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(107, 17);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMaNV.Location = new System.Drawing.Point(20, 20);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(101, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(23, 307);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(580, 191);
            this.dgvNhanVien.TabIndex = 13;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanvien);
            // 
            // gpbNhanvien
            // 
            this.gpbNhanvien.Controls.Add(this.btnXoa);
            this.gpbNhanvien.Controls.Add(this.gpbThongTin);
            this.gpbNhanvien.Controls.Add(this.btnThoat);
            this.gpbNhanvien.Controls.Add(this.dgvNhanVien);
            this.gpbNhanvien.Controls.Add(this.btnBoqua);
            this.gpbNhanvien.Controls.Add(this.lblNhanVien);
            this.gpbNhanvien.Controls.Add(this.btnSua);
            this.gpbNhanvien.Controls.Add(this.btnLuu);
            this.gpbNhanvien.Controls.Add(this.txtSearch);
            this.gpbNhanvien.Controls.Add(this.btnThem);
            this.gpbNhanvien.Controls.Add(this.btnSearch);
            this.gpbNhanvien.Location = new System.Drawing.Point(9, 6);
            this.gpbNhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNhanvien.Name = "gpbNhanvien";
            this.gpbNhanvien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNhanvien.Size = new System.Drawing.Size(678, 502);
            this.gpbNhanvien.TabIndex = 1;
            this.gpbNhanvien.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = global::GUI_QLcoffee.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(217, 205);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 39);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gpbThongTin
            // 
            this.gpbThongTin.Controls.Add(this.rdbtnNgungHD);
            this.gpbThongTin.Controls.Add(this.txtDiaChi);
            this.gpbThongTin.Controls.Add(this.gpbVaiTro);
            this.gpbThongTin.Controls.Add(this.lblMaNV);
            this.gpbThongTin.Controls.Add(this.rdbtnHD);
            this.gpbThongTin.Controls.Add(this.lblTenNV);
            this.gpbThongTin.Controls.Add(this.txtDienThoai);
            this.gpbThongTin.Controls.Add(this.lblVaiTro);
            this.gpbThongTin.Controls.Add(this.lblDienThoai);
            this.gpbThongTin.Controls.Add(this.lblTinhTrang);
            this.gpbThongTin.Controls.Add(this.txtEmail);
            this.gpbThongTin.Controls.Add(this.txtMaNV);
            this.gpbThongTin.Controls.Add(this.txtTenNV);
            this.gpbThongTin.Controls.Add(this.lblDiaChi);
            this.gpbThongTin.Controls.Add(this.lblEmail);
            this.gpbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbThongTin.Location = new System.Drawing.Point(23, 49);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Size = new System.Drawing.Size(634, 144);
            this.gpbThongTin.TabIndex = 27;
            this.gpbThongTin.TabStop = false;
            this.gpbThongTin.Text = "Thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThoat.Image = global::GUI_QLcoffee.Properties.Resources.Thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(486, 205);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 39);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBoqua.Image = global::GUI_QLcoffee.Properties.Resources.iconfinder_Remove_27874;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(397, 205);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(85, 39);
            this.btnBoqua.TabIndex = 32;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSua.Image = global::GUI_QLcoffee.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(301, 205);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "        Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLuu.Image = global::GUI_QLcoffee.Properties.Resources.iconfinder_Save_27876;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(135, 205);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 39);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSearch.Location = new System.Drawing.Point(150, 258);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 36);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_QLcoffee.Properties.Resources.Them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(50, 205);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 39);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::GUI_QLcoffee.Properties.Resources.icons8_search_32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(377, 258);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 35);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "        Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.gpbNhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.gpbVaiTro.ResumeLayout(false);
            this.gpbVaiTro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.gpbNhanvien.ResumeLayout(false);
            this.gpbNhanvien.PerformLayout();
            this.gpbThongTin.ResumeLayout(false);
            this.gpbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.RadioButton rdbtnNgungHD;
        private System.Windows.Forms.GroupBox gpbVaiTro;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnNV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbtnHD;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox gpbNhanvien;
        private System.Windows.Forms.GroupBox gpbThongTin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSearch;
    }
}