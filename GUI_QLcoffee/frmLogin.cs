using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLcoffee;
using BUS_QLcoffee;

namespace GUI_QLcoffee
{
    public partial class frmLogin : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public int tinhtrang { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            //testcommitt
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                frmMain frm = new frmMain();
                frm.Close();
                this.Close();
            }
            else
            {
                txtEmail.Text = txtEmail.Text;
                txtMK.Text = txtMK.Text;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
            txtEmail.Text = Properties.Settings.Default.email;
            txtMK.Text = Properties.Settings.Default.pass;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Không được để trống email!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                }
                else if(txtMK.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Không được để trống mật khẩu!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMK.Focus();
                }
                else if(txtEmail.Text.Trim().Length != 0&& txtMK.Text.Trim().Length != 0)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.Email = txtEmail.Text;
                    nv.MatKhau = bus_NhanVien.encryption(txtMK.Text);
                    if (bus_NhanVien.NVDangNhap(nv))
                    {
                        tinhtrang = bus_NhanVien.NVTinhTrang(nv);
                        if (tinhtrang == 1)
                        {
                            frmMain.mail = txtEmail.Text;
                            frmMain.vaitro = bus_NhanVien.NVVaiTro(nv);
                            MessageBox.Show("Đăng nhập thành công!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmMain frm = new frmMain();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã dừng hoạt động vui lòng liên hệ quản lý!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra email hoặc mật khẩu!");
                        txtEmail.Text = null;
                        txtMK.Text = null;
                        txtEmail.Focus();
                        chkLogin.Checked = false;
                    }
                }                
            }
            catch { MessageBox.Show("Lỗi kết nối dữ liệu!", "Thông báo"); }
            
            if (chkLogin.Checked)
            {
                Properties.Settings.Default.email = txtEmail.Text;
                Properties.Settings.Default.pass = txtMK.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.email = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            if (txtEmail.Text != "")
            {
                nv.Email = txtEmail.Text;
                if (bus_NhanVien.NVQuenMatKhau(nv))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(bus_NhanVien.RandomString(4, true));
                    builder.Append(bus_NhanVien.RamdomNumber(1000, 9999));
                    builder.Append(bus_NhanVien.RandomString(2, false));
                    string matKhauMoi = bus_NhanVien.encryption(builder.ToString());
                    bus_NhanVien.NVTaoMatKhau(txtEmail.Text, matKhauMoi);
                    bus_NhanVien.SendEmail(txtEmail.Text, builder.ToString());
                    MessageBox.Show(matKhauMoi);
                }
                else
                {
                    MessageBox.Show("Email không tồn tại vui lòng nhập lại email!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email, để nhận thông tin phục hồi mật khẩu!");
                txtEmail.Focus();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
