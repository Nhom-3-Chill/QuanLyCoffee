﻿namespace GUI_QLcoffee
{
    partial class frmThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucDon));
            this.gpbThucDon = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.gpbThongTin = new System.Windows.Forms.GroupBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnHinhAnh = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenTD = new System.Windows.Forms.Label();
            this.lblMaTD = new System.Windows.Forms.Label();
            this.lblThucDon = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.picThucDon = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gpbThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.gpbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbThucDon
            // 
            this.gpbThucDon.Controls.Add(this.btnThem);
            this.gpbThucDon.Controls.Add(this.btnSearch);
            this.gpbThucDon.Controls.Add(this.btnLuu);
            this.gpbThucDon.Controls.Add(this.txtSearch);
            this.gpbThucDon.Controls.Add(this.btnXoa);
            this.gpbThucDon.Controls.Add(this.dgvThucDon);
            this.gpbThucDon.Controls.Add(this.gpbThongTin);
            this.gpbThucDon.Controls.Add(this.btnSua);
            this.gpbThucDon.Controls.Add(this.btnBoqua);
            this.gpbThucDon.Controls.Add(this.lblThucDon);
            this.gpbThucDon.Controls.Add(this.btnThoat);
            this.gpbThucDon.Location = new System.Drawing.Point(3, 0);
            this.gpbThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThucDon.Name = "gpbThucDon";
            this.gpbThucDon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThucDon.Size = new System.Drawing.Size(683, 526);
            this.gpbThucDon.TabIndex = 2;
            this.gpbThucDon.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSearch.Location = new System.Drawing.Point(184, 305);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 24);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Location = new System.Drawing.Point(45, 348);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.Size = new System.Drawing.Size(600, 162);
            this.dgvThucDon.TabIndex = 13;
            this.dgvThucDon.Click += new System.EventHandler(this.dgvThucDon_Click);
            // 
            // gpbThongTin
            // 
            this.gpbThongTin.Controls.Add(this.txtHinh);
            this.gpbThongTin.Controls.Add(this.picThucDon);
            this.gpbThongTin.Controls.Add(this.btnHinhAnh);
            this.gpbThongTin.Controls.Add(this.txtGia);
            this.gpbThongTin.Controls.Add(this.txtTenTD);
            this.gpbThongTin.Controls.Add(this.txtMaTD);
            this.gpbThongTin.Controls.Add(this.lblGia);
            this.gpbThongTin.Controls.Add(this.lblTenTD);
            this.gpbThongTin.Controls.Add(this.lblMaTD);
            this.gpbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gpbThongTin.Location = new System.Drawing.Point(45, 65);
            this.gpbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Size = new System.Drawing.Size(600, 161);
            this.gpbThongTin.TabIndex = 2;
            this.gpbThongTin.TabStop = false;
            this.gpbThongTin.Text = "Thông Tin";
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(348, 101);
            this.txtHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(8, 23);
            this.txtHinh.TabIndex = 15;
            this.txtHinh.Visible = false;
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnHinhAnh.Location = new System.Drawing.Point(348, 50);
            this.btnHinhAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.Size = new System.Drawing.Size(80, 38);
            this.btnHinhAnh.TabIndex = 13;
            this.btnHinhAnh.Text = "Hình Ảnh";
            this.btnHinhAnh.UseVisualStyleBackColor = true;
            this.btnHinhAnh.Click += new System.EventHandler(this.btnHinhAnh_Click);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtGia.Location = new System.Drawing.Point(139, 119);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.MaxLength = 6;
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(185, 26);
            this.txtGia.TabIndex = 12;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtTenTD
            // 
            this.txtTenTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTenTD.Location = new System.Drawing.Point(139, 76);
            this.txtTenTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTD.Multiline = true;
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(185, 26);
            this.txtTenTD.TabIndex = 5;
            // 
            // txtMaTD
            // 
            this.txtMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaTD.Location = new System.Drawing.Point(139, 25);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTD.Multiline = true;
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(185, 26);
            this.txtMaTD.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblGia.Location = new System.Drawing.Point(30, 127);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 17);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá:";
            // 
            // lblTenTD
            // 
            this.lblTenTD.AutoSize = true;
            this.lblTenTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTenTD.Location = new System.Drawing.Point(27, 84);
            this.lblTenTD.Name = "lblTenTD";
            this.lblTenTD.Size = new System.Drawing.Size(103, 17);
            this.lblTenTD.TabIndex = 1;
            this.lblTenTD.Text = "Tên Thực Đơn:";
            // 
            // lblMaTD
            // 
            this.lblMaTD.AutoSize = true;
            this.lblMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMaTD.Location = new System.Drawing.Point(30, 34);
            this.lblMaTD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTD.Name = "lblMaTD";
            this.lblMaTD.Size = new System.Drawing.Size(97, 17);
            this.lblMaTD.TabIndex = 0;
            this.lblMaTD.Text = "Mã Thực Đơn:";
            // 
            // lblThucDon
            // 
            this.lblThucDon.AutoSize = true;
            this.lblThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblThucDon.ForeColor = System.Drawing.Color.Red;
            this.lblThucDon.Location = new System.Drawing.Point(277, 17);
            this.lblThucDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThucDon.Name = "lblThucDon";
            this.lblThucDon.Size = new System.Drawing.Size(140, 31);
            this.lblThucDon.TabIndex = 0;
            this.lblThucDon.Text = "Thực Đơn";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Image = global::GUI_QLcoffee.Properties.Resources.Them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(67, 244);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnSearch.Location = new System.Drawing.Point(422, 296);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 35);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "        Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLuu.Image = global::GUI_QLcoffee.Properties.Resources.iconfinder_Save_27876;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(154, 244);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 39);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = global::GUI_QLcoffee.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(238, 244);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 39);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // picThucDon
            // 
            this.picThucDon.BackgroundImage = global::GUI_QLcoffee.Properties.Resources.Menu;
            this.picThucDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThucDon.Location = new System.Drawing.Point(456, 20);
            this.picThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picThucDon.Name = "picThucDon";
            this.picThucDon.Size = new System.Drawing.Size(127, 130);
            this.picThucDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThucDon.TabIndex = 14;
            this.picThucDon.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSua.Image = global::GUI_QLcoffee.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(324, 244);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "        Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBoqua.Image = global::GUI_QLcoffee.Properties.Resources.iconfinder_Remove_27874;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(422, 244);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(85, 39);
            this.btnBoqua.TabIndex = 32;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThoat.Image = global::GUI_QLcoffee.Properties.Resources.Thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(513, 244);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 39);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 522);
            this.Controls.Add(this.gpbThucDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thực Đơn";
            this.Load += new System.EventHandler(this.frmThucDon_Load);
            this.gpbThucDon.ResumeLayout(false);
            this.gpbThucDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.gpbThongTin.ResumeLayout(false);
            this.gpbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbThucDon;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.GroupBox gpbThongTin;
        private System.Windows.Forms.TextBox txtTenTD;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenTD;
        private System.Windows.Forms.Label lblMaTD;
        private System.Windows.Forms.Label lblThucDon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnHinhAnh;
        private System.Windows.Forms.PictureBox picThucDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtHinh;
    }
}