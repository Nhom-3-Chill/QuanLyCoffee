namespace GUI_QLcoffee
{
    partial class frmReportHoaDon
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
            this.rpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporthoadon1 = new GUI_QLcoffee.reporthoadon();
            this.SuspendLayout();
            // 
            // rpHoaDon
            // 
            this.rpHoaDon.ActiveViewIndex = 0;
            this.rpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpHoaDon.DisplayStatusBar = false;
            this.rpHoaDon.DisplayToolbar = false;
            this.rpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ReportSource = this.reporthoadon1;
            this.rpHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rpHoaDon.TabIndex = 0;
            this.rpHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpHoaDon);
            this.Name = "frmReportHoaDon";
            this.Text = "frmReportHoaDon";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpHoaDon;
        private reporthoadon reporthoadon1;
    }
}