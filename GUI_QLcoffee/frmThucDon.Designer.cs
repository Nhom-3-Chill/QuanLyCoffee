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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.gpbThongTin = new System.Windows.Forms.GroupBox();
            this.picThucDon = new System.Windows.Forms.PictureBox();
            this.btnHinhAnh = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenTD = new System.Windows.Forms.Label();
            this.lblMaTD = new System.Windows.Forms.Label();
            this.lblThucDon = new System.Windows.Forms.Label();
            this.gpbThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.gpbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbThucDon
            // 
            this.gpbThucDon.Controls.Add(this.btnSearch);
            this.gpbThucDon.Controls.Add(this.txtSearch);
            this.gpbThucDon.Controls.Add(this.dgvThucDon);
            this.gpbThucDon.Controls.Add(this.gpbThongTin);
            this.gpbThucDon.Controls.Add(this.lblThucDon);
<<<<<<< Updated upstream
            this.gpbThucDon.Location = new System.Drawing.Point(3, 0);
            this.gpbThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThucDon.Name = "gpbThucDon";
            this.gpbThucDon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThucDon.Size = new System.Drawing.Size(913, 683);
=======
            this.gpbThucDon.Location = new System.Drawing.Point(2, 2);
            this.gpbThucDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThucDon.Name = "gpbThucDon";
            this.gpbThucDon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThucDon.Size = new System.Drawing.Size(658, 529);
>>>>>>> Stashed changes
            this.gpbThucDon.TabIndex = 2;
            this.gpbThucDon.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = global::GUI_QLcoffee.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< Updated upstream
            this.btnXoa.Location = new System.Drawing.Point(273, 211);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnXoa.Location = new System.Drawing.Point(351, 217);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 39);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThoat.Image = global::GUI_QLcoffee.Properties.Resources.Thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< Updated upstream
            this.btnThoat.Location = new System.Drawing.Point(674, 210);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnThoat.Location = new System.Drawing.Point(524, 217);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.btnBoqua.Location = new System.Drawing.Point(541, 211);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnBoqua.Location = new System.Drawing.Point(435, 217);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(85, 39);
            this.btnBoqua.TabIndex = 32;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSua.Image = global::GUI_QLcoffee.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< Updated upstream
            this.btnSua.Location = new System.Drawing.Point(401, 211);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnSua.Location = new System.Drawing.Point(255, 217);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.btnLuu.Location = new System.Drawing.Point(152, 211);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnLuu.Location = new System.Drawing.Point(173, 217);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 39);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = global::GUI_QLcoffee.Properties.Resources.Them1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< Updated upstream
            this.btnThem.Location = new System.Drawing.Point(27, 211);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnThem.Location = new System.Drawing.Point(88, 217);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.btnSearch.Location = new System.Drawing.Point(478, 379);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnSearch.Location = new System.Drawing.Point(386, 259);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 35);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "        Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.txtSearch.Location = new System.Drawing.Point(213, 378);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtSearch.Location = new System.Drawing.Point(173, 259);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 36);
            this.txtSearch.TabIndex = 27;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            this.dgvThucDon.Location = new System.Drawing.Point(45, 441);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.Size = new System.Drawing.Size(818, 235);
=======
            this.dgvThucDon.Location = new System.Drawing.Point(34, 303);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.Size = new System.Drawing.Size(580, 191);
>>>>>>> Stashed changes
            this.dgvThucDon.TabIndex = 13;
            this.dgvThucDon.Click += new System.EventHandler(this.dgvThucDon_Click);
            // 
            // gpbThongTin
            // 
            this.gpbThongTin.Controls.Add(this.btnThem);
            this.gpbThongTin.Controls.Add(this.btnLuu);
            this.gpbThongTin.Controls.Add(this.btnXoa);
            this.gpbThongTin.Controls.Add(this.picThucDon);
            this.gpbThongTin.Controls.Add(this.btnSua);
            this.gpbThongTin.Controls.Add(this.btnBoqua);
            this.gpbThongTin.Controls.Add(this.btnThoat);
            this.gpbThongTin.Controls.Add(this.btnHinhAnh);
            this.gpbThongTin.Controls.Add(this.txtGia);
            this.gpbThongTin.Controls.Add(this.txtTenTD);
            this.gpbThongTin.Controls.Add(this.txtMaTD);
            this.gpbThongTin.Controls.Add(this.lblGia);
            this.gpbThongTin.Controls.Add(this.lblTenTD);
            this.gpbThongTin.Controls.Add(this.lblMaTD);
            this.gpbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.gpbThongTin.Location = new System.Drawing.Point(45, 74);
            this.gpbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbThongTin.Size = new System.Drawing.Size(818, 280);
=======
            this.gpbThongTin.Location = new System.Drawing.Point(45, 59);
            this.gpbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThongTin.Size = new System.Drawing.Size(580, 145);
>>>>>>> Stashed changes
            this.gpbThongTin.TabIndex = 2;
            this.gpbThongTin.TabStop = false;
            this.gpbThongTin.Text = "Thông Tin";
            // 
            // picThucDon
            // 
            this.picThucDon.Image = global::GUI_QLcoffee.Properties.Resources.avtkhung;
<<<<<<< Updated upstream
            this.picThucDon.Location = new System.Drawing.Point(588, 23);
            this.picThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.picThucDon.Location = new System.Drawing.Point(430, 11);
            this.picThucDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.picThucDon.Name = "picThucDon";
            this.picThucDon.Size = new System.Drawing.Size(127, 130);
            this.picThucDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThucDon.TabIndex = 14;
            this.picThucDon.TabStop = false;
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.btnHinhAnh.Location = new System.Drawing.Point(452, 23);
            this.btnHinhAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.btnHinhAnh.Location = new System.Drawing.Point(322, 51);
            this.btnHinhAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.txtGia.Location = new System.Drawing.Point(193, 139);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtGia.Location = new System.Drawing.Point(137, 100);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(156, 26);
            this.txtGia.TabIndex = 12;
            // 
            // txtTenTD
            // 
            this.txtTenTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.txtTenTD.Location = new System.Drawing.Point(193, 89);
            this.txtTenTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtTenTD.Location = new System.Drawing.Point(137, 63);
            this.txtTenTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.txtTenTD.Multiline = true;
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(156, 26);
            this.txtTenTD.TabIndex = 5;
            // 
            // txtMaTD
            // 
            this.txtMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.txtMaTD.Location = new System.Drawing.Point(193, 39);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtMaTD.Location = new System.Drawing.Point(137, 25);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.txtMaTD.Multiline = true;
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(156, 26);
            this.txtMaTD.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.lblGia.Location = new System.Drawing.Point(40, 144);
=======
            this.lblGia.Location = new System.Drawing.Point(30, 109);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> Stashed changes
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 17);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá:";
            // 
            // lblTenTD
            // 
            this.lblTenTD.AutoSize = true;
            this.lblTenTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
<<<<<<< Updated upstream
            this.lblTenTD.Location = new System.Drawing.Point(40, 91);
=======
            this.lblTenTD.Location = new System.Drawing.Point(30, 72);
            this.lblTenTD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> Stashed changes
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
            this.lblThucDon.Location = new System.Drawing.Point(274, 15);
            this.lblThucDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThucDon.Name = "lblThucDon";
            this.lblThucDon.Size = new System.Drawing.Size(140, 31);
            this.lblThucDon.TabIndex = 0;
            this.lblThucDon.Text = "Thực Đơn";
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(919, 689);
=======
            this.ClientSize = new System.Drawing.Size(689, 542);
>>>>>>> Stashed changes
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
    }
}