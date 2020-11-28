using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLcoffee
{
    public partial class frmMain : Form
    {
        public static string mail;
        public static int vaitro = 0;
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        public void ResetValues()
        {
            lblNameLogin.Text = "Chào" + frmMain.mail;
            lblUserName.Text = "Chào";
            dangXuatToolStripMenuItem.Visible = true;
            doiMatKhauToolStripMenuItem.Visible = true;
            thoatToolStripMenuItem.Visible = true;
            hoaDonToolStripMenuItem.Visible = true;
            khachHangToolStripMenuItem.Visible = true;
            nhanVienToolStripMenuItem.Visible = true;
            thongKeToolStripMenuItem.Visible = true;
            if (vaitro == 0)
            {
                VaiTroNV();
            }
        }

        public void VaiTroNV()
        {
            thongKeToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
        }

        public bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDoiMK"))
            {
                frmDoiMK profilenv = new frmDoiMK(frmMain.mail);
                profilenv.MdiParent = this;
                profilenv.FormClosed += new FormClosedEventHandler(frmDoiMK_FormClosed);
                profilenv.Show();
            }
            else
            {
                ActiveChildForm("frmDoiMK");
            }
        }
        void frmDoiMK_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }
    }
}
