namespace GUI_QLcoffee
{
    partial class frmReportThongKe
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
            this.rpThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportthongke1 = new GUI_QLcoffee.reportthongke();
            this.SuspendLayout();
            // 
            // rpThongKe
            // 
            this.rpThongKe.ActiveViewIndex = 0;
            this.rpThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpThongKe.DisplayStatusBar = false;
            this.rpThongKe.DisplayToolbar = false;
            this.rpThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpThongKe.Location = new System.Drawing.Point(0, 0);
            this.rpThongKe.Name = "rpThongKe";
            this.rpThongKe.ReportSource = this.reportthongke1;
            this.rpThongKe.Size = new System.Drawing.Size(800, 450);
            this.rpThongKe.TabIndex = 0;
            this.rpThongKe.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpThongKe);
            this.Name = "frmReportThongKe";
            this.Text = "frmReportThongKe";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpThongKe;
        private reportthongke reportthongke1;
    }
}