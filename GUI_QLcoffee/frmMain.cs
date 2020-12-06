﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLcoffee;

namespace GUI_QLcoffee
{
    public partial class frmMain : Form
    {
        public static string mail;
        public static int vaitro = 0;
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frmMain()
        {
            InitializeComponent();
            //testcommitt
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        public void Hidencontrol()
        {
            lblNameLogin.Visible = false;
            lblTenDN.Visible = false;
            lblTextMain.Visible = false;
            lblUserName.Visible = false;
            lblUser.Visible = false;
            picMain.Visible = false;
        }

        public void ResetValues()
        {
            lblNameLogin.Text = "Chào " + frmMain.mail;
            lblUserName.Text = bus_NhanVien.getTenNV(frmMain.mail);
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
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
                
            }
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDoiMK"))
            {
                this.IsMdiContainer = true;
                frmDoiMK profilenv = new frmDoiMK();
                profilenv.MdiParent = this;
                profilenv.FormClosed += new FormClosedEventHandler(frmDoiMK_FormClosed);
                profilenv.Show();
                Hidencontrol();
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

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHoaDon"))
            {
                this.IsMdiContainer = true;
                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.FormClosed += new FormClosedEventHandler(frmHoaDon_FormClosed);
                hoaDon.Show();
                Hidencontrol();
            }
            else
            {
                ActiveChildForm("frmHoaDon");
            }
        }
        void frmHoaDon_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmKhachHang"))
            {
                this.IsMdiContainer = true;
                frmKhachHang khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.FormClosed += new FormClosedEventHandler(frmKhachHang_FormClosed);
                khachHang.Show();
                Hidencontrol();
            }
            else
            {
                ActiveChildForm("frmKhachHang");
            }
        }
        void frmKhachHang_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhanVien"))
            {
                this.IsMdiContainer = true;
                frmNhanVien nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.FormClosed += new FormClosedEventHandler(frmNhanVien_FormClosed);
                nhanVien.Show();
                Hidencontrol();
            }
            else
            {
                ActiveChildForm("frmNhanVien");
            }
        }

        void frmNhanVien_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void thucDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThucDon"))
            {
                this.IsMdiContainer = true;
                frmThucDon thongKe = new frmThucDon();
                thongKe.MdiParent = this;
                thongKe.FormClosed += new FormClosedEventHandler(frmThucDon_FormClosed);
                thongKe.Show();
                Hidencontrol();
            }
            else
            {
                ActiveChildForm("frmThucDon");
            }
        }

        void frmThucDon_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThongKe"))
            {
                this.IsMdiContainer = true;
                frmThongKe thongKe = new frmThongKe();
                thongKe.MdiParent = this;
                thongKe.FormClosed += new FormClosedEventHandler(frmThongKe_FormClosed);
                thongKe.Show();
                Hidencontrol();
            }
            else
            {
                ActiveChildForm("frmThongKe");
            }
        }
        void frmThongKe_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            frmMain_Load(sender, e);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
