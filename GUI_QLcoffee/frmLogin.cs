using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLcoffee;
using BUS_QLcoffee;
using System.Net.Mail;

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

        public void writeRememberAP()
        {
            try
            {
                string startupPath = Environment.CurrentDirectory;
                string file = startupPath + @"\Remember.txt";
                using (FileStream fstr = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fstr))
                    {
                        if (chkLogin.Checked == true)
                        {
                            sw.WriteLine(txtEmail.Text);
                            sw.WriteLine(txtMK.Text);// dòng "1" để kiểm tra có checked hay không
                            sw.WriteLine("1");// ghi từng dòng vào file Remember.txt
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("0");// dòng "0" là không check vào checkbox
                            sw.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void readRememberAP()
        {
            try
            {
                string startupPath = Environment.CurrentDirectory;
                string file = startupPath + @"\Remember.txt";
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    string[] lines = File.ReadAllLines(file);
                    if (lines[lines.Length - 1] == "1")
                    {
                        txtEmail.Text = lines[lines.Length - 3];
                        txtMK.Text = lines[lines.Length - 2];
                        chkLogin.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            readRememberAP();
        }

        public bool checkmail(string emailadd)
        {
            try
            {
                MailAddress m = new MailAddress(emailadd);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không được để trống email!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (!checkmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email bạn nhập không hợp lệ!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if(txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không được để trống mật khẩu!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }
            else if(txtEmail.Text.Trim().Length != 0&& txtMK.Text.Trim().Length != 0)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.Email = txtEmail.Text;
                nv.MatKhau = bus_NhanVien.encryption(txtMK.Text);
                if (bus_NhanVien.NVDangNhap(nv))
                {
                    tinhtrang = bus_NhanVien.NVTinhTrang(nv);
                    if (tinhtrang == 0)
                    {
                        frmMain.mail = txtEmail.Text;
                        frmMain.vaitro = bus_NhanVien.NVVaiTro(nv);
                        MessageBox.Show("Đăng nhập thành công!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.Show();
                        writeRememberAP();
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
