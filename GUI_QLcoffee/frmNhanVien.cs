using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLcoffee;
using BUS_QLcoffee;

namespace GUI_QLcoffee
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            //testcommit
        }

        private void gpbNhanvien_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            resetvalue();
            loaddata();
        }
        public void loaddata()
        {
            dgvNhanVien.DataSource = busNhanvien.DSNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "MaNV";
            dgvNhanVien.Columns[1].HeaderText = "Email";
            dgvNhanVien.Columns[2].HeaderText = "TenNV";
            dgvNhanVien.Columns[3].HeaderText = "DiaChi";
            dgvNhanVien.Columns[4].HeaderText = "VaiTro";
            dgvNhanVien.Columns[5].HeaderText = "TinhTrang";
            dgvNhanVien.Columns[6].HeaderText = "SoDT";
        }
        public void resetvalue()
        {
            txtMaNV.Text = null;
            txtMaNV.Enabled = false;
            txtEmail.Text = null;
            txtEmail.Enabled = false;
            txtTenNV.Text = null;
            txtTenNV.Enabled = false;
            txtDienThoai.Text = null;
            txtDienThoai.Enabled = false;
            txtDiaChi.Text = null;
            txtDiaChi.Enabled = false;
            txtSearch.Text = "Nhập tên nhân viên";
            txtSearch.BackColor = Color.DarkGray;
            rdbtnAdmin.Checked = false;
            rdbtnHD.Checked = false;
            rdbtnNgungHD.Checked = false;
            rdbtnNV.Checked = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvNhanvien(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 1)
            {
                txtMaNV.Text = null;
                txtMaNV.Enabled = true;
                txtEmail.Text = null;
                txtEmail.Enabled = true;
                txtTenNV.Text = null;
                txtTenNV.Enabled = true;
                txtDienThoai.Text = null;
                txtDienThoai.Enabled = true;
                txtDiaChi.Text = null;
                txtDiaChi.Enabled = true;
                rdbtnAdmin.Checked = false;
                rdbtnHD.Checked = false;
                rdbtnNgungHD.Checked = false;
                rdbtnNV.Checked = false;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                try
                {
                    if (int.Parse(dgvNhanVien.CurrentRow.Cells[4].Value.ToString()) == 0)
                    {
                        rdbtnNV.Checked = true;
                        rdbtnAdmin.Checked = false;
                    }
                    else { rdbtnAdmin.Checked = true; rdbtnNV.Checked = false; }
                    if (int.Parse(dgvNhanVien.CurrentRow.Cells[5].Value.ToString()) == 0)
                    {
                        rdbtnHD.Checked = true;
                        rdbtnNgungHD.Checked = false;
                    }
                    else { rdbtnNgungHD.Checked = true; rdbtnHD.Checked = false; }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Không tồn tại dữ liệu! " + x.Message);
                }
            }
            else
            {
                MessageBox.Show("Hàng không tồn tại dữ liệu!");
            }
        }
        BUS_NhanVien busNhanvien = new BUS_NhanVien();

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = null;
            txtMaNV.Enabled = true;
            txtEmail.Text = null;
            txtEmail.Enabled = true;
            txtTenNV.Text = null;
            txtTenNV.Enabled = true;
            txtDienThoai.Text = null;
            txtDienThoai.Enabled = true;
            txtDiaChi.Text = null;
            txtDiaChi.Enabled = true;
            rdbtnAdmin.Checked = false;
            rdbtnHD.Checked = false;
            rdbtnNgungHD.Checked = false;
            rdbtnNV.Checked = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int role = 1;
            if (rdbtnNV.Checked) role = 0;
            int tt = 1;
            if (rdbtnHD.Checked) tt = 0;
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email!");
                txtEmail.Focus();
                return;
            }
            else if (!checkmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ");
                txtEmail.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên!");
                txtTenNV.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!");
                txtDiaChi.Focus();
                return;
            }
            if (rdbtnAdmin.Checked == false && rdbtnNV.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn chức vụ!");
                return;
            }
            if (rdbtnHD.Checked == false && rdbtnNgungHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn trạng thái!");
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text,txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tt,txtDienThoai.Text);
                if (busNhanvien.LuuNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    resetvalue();
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (busNhanvien.XoaNhanVien(txtEmail.Text))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    resetvalue();
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại Email nhân viên");
                }
            }
            else
            {
                resetvalue();
                loaddata();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int role = 1;
            if (rdbtnNV.Checked) role = 0;
            int tt = 1;
            if (rdbtnHD.Checked) tt = 0;
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email!");
                txtEmail.Focus();
                return;
            }
            else if (!checkmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ");
                txtEmail.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên!");
                txtTenNV.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!");
                txtDiaChi.Focus();
                return;
            }
            if (rdbtnAdmin.Checked == false && rdbtnNV.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn chức vụ!");
                return;
            }
            if (rdbtnHD.Checked == false && rdbtnNgungHD.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn trạng thái!");
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtEmail.Text, txtTenNV.Text, txtDiaChi.Text, role, tt, txtDienThoai.Text);
                if (busNhanvien.SuaNhanVien(nv))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    resetvalue();
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource = busNhanvien.TimKiemNhanVien(txtSearch.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Vui long kiem tra lai thong tin tim kiem!"+ x.Message);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.White;
        }
    }
}
