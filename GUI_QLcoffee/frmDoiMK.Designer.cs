namespace GUI_QLcoffee
{
    partial class frmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMK));
            this.lblDoiMK = new System.Windows.Forms.Label();
            this.lblMkCu = new System.Windows.Forms.Label();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.lblMkMoi = new System.Windows.Forms.Label();
            this.lblNhaplaiMkMoi = new System.Windows.Forms.Label();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMkMoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.picDoiMK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDoiMK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoiMK
            // 
            this.lblDoiMK.AutoSize = true;
            this.lblDoiMK.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMK.ForeColor = System.Drawing.Color.Red;
            this.lblDoiMK.Location = new System.Drawing.Point(303, 53);
            this.lblDoiMK.Name = "lblDoiMK";
            this.lblDoiMK.Size = new System.Drawing.Size(206, 37);
            this.lblDoiMK.TabIndex = 1;
            this.lblDoiMK.Text = "Đổi mật khẩu";
            // 
            // lblMkCu
            // 
            this.lblMkCu.AutoSize = true;
            this.lblMkCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMkCu.Location = new System.Drawing.Point(40, 165);
            this.lblMkCu.Name = "lblMkCu";
            this.lblMkCu.Size = new System.Drawing.Size(105, 20);
            this.lblMkCu.TabIndex = 1;
            this.lblMkCu.Text = "Mật khẩu cũ:";
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(239, 163);
            this.txtMkCu.Multiline = true;
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.Size = new System.Drawing.Size(391, 33);
            this.txtMkCu.TabIndex = 2;
            // 
            // lblMkMoi
            // 
            this.lblMkMoi.AutoSize = true;
            this.lblMkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMkMoi.Location = new System.Drawing.Point(39, 217);
            this.lblMkMoi.Name = "lblMkMoi";
            this.lblMkMoi.Size = new System.Drawing.Size(114, 20);
            this.lblMkMoi.TabIndex = 1;
            this.lblMkMoi.Text = "Mật khẩu mới:";
            // 
            // lblNhaplaiMkMoi
            // 
            this.lblNhaplaiMkMoi.AutoSize = true;
            this.lblNhaplaiMkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaplaiMkMoi.Location = new System.Drawing.Point(39, 268);
            this.lblNhaplaiMkMoi.Name = "lblNhaplaiMkMoi";
            this.lblNhaplaiMkMoi.Size = new System.Drawing.Size(180, 20);
            this.lblNhaplaiMkMoi.TabIndex = 1;
            this.lblNhaplaiMkMoi.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(239, 211);
            this.txtMkMoi.Multiline = true;
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.Size = new System.Drawing.Size(391, 33);
            this.txtMkMoi.TabIndex = 2;
            // 
            // txtNhapLaiMkMoi
            // 
            this.txtNhapLaiMkMoi.Location = new System.Drawing.Point(239, 261);
            this.txtNhapLaiMkMoi.Multiline = true;
            this.txtNhapLaiMkMoi.Name = "txtNhapLaiMkMoi";
            this.txtNhapLaiMkMoi.Size = new System.Drawing.Size(391, 33);
            this.txtNhapLaiMkMoi.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::GUI_QLcoffee.Properties.Resources.Exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(436, 320);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(194, 74);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoiMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Image = global::GUI_QLcoffee.Properties.Resources.DoiMK;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(239, 320);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(191, 74);
            this.btnDoiMK.TabIndex = 3;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // picDoiMK
            // 
            this.picDoiMK.BackgroundImage = global::GUI_QLcoffee.Properties.Resources.ly_coffee1;
            this.picDoiMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDoiMK.Location = new System.Drawing.Point(43, 40);
            this.picDoiMK.Name = "picDoiMK";
            this.picDoiMK.Size = new System.Drawing.Size(131, 81);
            this.picDoiMK.TabIndex = 0;
            this.picDoiMK.TabStop = false;
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 440);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtNhapLaiMkMoi);
            this.Controls.Add(this.txtMkMoi);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.lblNhaplaiMkMoi);
            this.Controls.Add(this.lblMkMoi);
            this.Controls.Add(this.lblMkCu);
            this.Controls.Add(this.lblDoiMK);
            this.Controls.Add(this.picDoiMK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.picDoiMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDoiMK;
        private System.Windows.Forms.Label lblDoiMK;
        private System.Windows.Forms.Label lblMkCu;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.Label lblMkMoi;
        private System.Windows.Forms.Label lblNhaplaiMkMoi;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMkMoi;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnThoat;
    }
}