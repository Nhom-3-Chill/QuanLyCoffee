using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLcoffee;
using DTO_QLcoffee;

namespace GUI_QLcoffee
{
    public partial class frmDoiMK : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Refresh();
            }
            else
            {
                txtMkCu.Text = txtMkCu.Text;
                txtMkMoi.Text = txtMkMoi.Text;
                txtNhapLaiMkMoi.Text = txtNhapLaiMkMoi.Text;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMkCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không để trống mật khẩu cũ","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMkCu.Focus();
                return;
            }
            else if (txtMkMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không để trống mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMkMoi.Focus();
                return;
            }
            else if (txtNhapLaiMkMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không để trống nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMkMoi.Focus();
                return;
            }
            else if (txtMkMoi.Text.Trim() != txtNhapLaiMkMoi.Text.Trim())
            {
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới phải giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMkMoi.Focus();
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.Email = frmMain.mail;
                    string matKhauCu = bus_NhanVien.encryption(txtMkCu.Text);
                    string matKhauMoi = bus_NhanVien.encryption(txtMkMoi.Text);
                    if(bus_NhanVien.NVDoiMatKhau(nv, matKhauCu, matKhauMoi))
                    {
                        bus_NhanVien.SendEmail(frmMain.mail, txtNhapLaiMkMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công, bạn cần phải đăng nhập lại!");
                        this.Close();
                        frmMain main = new frmMain();
                        main.Hide();
                        frmLogin login = new frmLogin();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, đổi mật khẩu không thành công!");
                        txtMkCu.Text = null;
                        txtMkMoi.Text = null;
                        txtNhapLaiMkMoi.Text = null;
                    }
                }
                else
                {
                    txtMkCu.Text = null;
                    txtMkMoi.Text = null;
                    txtNhapLaiMkMoi.Text = null;
                }
            }
        }
    }
}
