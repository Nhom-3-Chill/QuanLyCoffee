namespace GUI_QLcoffee
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.lblThongKe = new System.Windows.Forms.Label();
            this.gpbNhanvien = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.gpbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpKetthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.gpbNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.gpbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblThongKe.ForeColor = System.Drawing.Color.Red;
            this.lblThongKe.Location = new System.Drawing.Point(277, 22);
            this.lblThongKe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(127, 29);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống Kê";
            // 
            // gpbNhanvien
            // 
            this.gpbNhanvien.Controls.Add(this.dgvThongKe);
            this.gpbNhanvien.Controls.Add(this.btnThongKe);
            this.gpbNhanvien.Controls.Add(this.gpbThongTin);
            this.gpbNhanvien.Controls.Add(this.lblThongKe);
            this.gpbNhanvien.Location = new System.Drawing.Point(11, 11);
            this.gpbNhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNhanvien.Name = "gpbNhanvien";
            this.gpbNhanvien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNhanvien.Size = new System.Drawing.Size(676, 494);
            this.gpbNhanvien.TabIndex = 3;
            this.gpbNhanvien.TabStop = false;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(24, 246);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.Size = new System.Drawing.Size(629, 223);
            this.dgvThongKe.TabIndex = 21;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(243, 188);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(171, 35);
            this.btnThongKe.TabIndex = 20;
            this.btnThongKe.Text = "Xem thống kê doanh thu";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // gpbThongTin
            // 
            this.gpbThongTin.Controls.Add(this.dtpKetthuc);
            this.gpbThongTin.Controls.Add(this.dtpBatDau);
            this.gpbThongTin.Controls.Add(this.lblKetThuc);
            this.gpbThongTin.Controls.Add(this.lblBatDau);
            this.gpbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gpbThongTin.Location = new System.Drawing.Point(119, 68);
            this.gpbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThongTin.Name = "gpbThongTin";
            this.gpbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbThongTin.Size = new System.Drawing.Size(419, 99);
            this.gpbThongTin.TabIndex = 3;
            this.gpbThongTin.TabStop = false;
            this.gpbThongTin.Text = "Thông Tin";
            // 
            // dtpKetthuc
            // 
            this.dtpKetthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetthuc.Location = new System.Drawing.Point(153, 59);
            this.dtpKetthuc.Name = "dtpKetthuc";
            this.dtpKetthuc.Size = new System.Drawing.Size(217, 23);
            this.dtpKetthuc.TabIndex = 3;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(153, 25);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(217, 23);
            this.dtpBatDau.TabIndex = 2;
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblKetThuc.Location = new System.Drawing.Point(14, 64);
            this.lblKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(134, 17);
            this.lblKetThuc.TabIndex = 1;
            this.lblKetThuc.Text = "Chọn ngày kết thúc:";
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = true;
            this.lblBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblBatDau.Location = new System.Drawing.Point(14, 30);
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(132, 17);
            this.lblBatDau.TabIndex = 1;
            this.lblBatDau.Text = "Chọn ngày bắt đầu:";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.gpbNhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thống Kê";
            this.gpbNhanvien.ResumeLayout(false);
            this.gpbNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.gpbThongTin.ResumeLayout(false);
            this.gpbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.GroupBox gpbNhanvien;
        private System.Windows.Forms.GroupBox gpbThongTin;
        private System.Windows.Forms.DateTimePicker dtpKetthuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
    }
}