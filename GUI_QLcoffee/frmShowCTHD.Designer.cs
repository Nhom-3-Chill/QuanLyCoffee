namespace GUI_QLcoffee
{
    partial class frmShowCTHD
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
            this.dgvShowCTHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowCTHD
            // 
            this.dgvShowCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCTHD.Location = new System.Drawing.Point(0, 0);
            this.dgvShowCTHD.Name = "dgvShowCTHD";
            this.dgvShowCTHD.RowHeadersWidth = 51;
            this.dgvShowCTHD.RowTemplate.Height = 24;
            this.dgvShowCTHD.Size = new System.Drawing.Size(542, 287);
            this.dgvShowCTHD.TabIndex = 0;
            // 
            // frmShowCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 289);
            this.Controls.Add(this.dgvShowCTHD);
            this.Name = "frmShowCTHD";
            this.Text = "frmShowCTHD";
            this.Load += new System.EventHandler(this.frmShowCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowCTHD;
    }
}