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
using System.Data.SqlClient;

namespace GUI_QLcoffee
{
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang buskhachhang = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
            //testcommitt
        }

        private void Load_khachhang()
        {
            dgvKhachHang.DataSource = buskhachhang.DSKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "MaKH";
            dgvKhachHang.Columns[1].HeaderText = "TenKhach";
            dgvKhachHang.Columns[2].HeaderText = "SoDT";
            dgvKhachHang.Columns[3].HeaderText = "Email";
            dgvKhachHang.Columns[4].HeaderText = "DiaChi";
        }

        public void ResetValues()
        {
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            txtSearch.Text = "Bạn hãy nhập tên khách hàng";
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Email của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDienThoai.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
                DTO_KhachHang dtokhachhang = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text,txtDienThoai.Text,txtEmail.Text,txtDiaChi.Text);
                if (buskhachhang.LuuKhachHang(dtokhachhang))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_khachhang();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaKH = txtMaKH.Text;
                if (buskhachhang.XoaKhachHang(MaKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_khachhang();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_KhachHang dtokhachhang = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text);
            if (MessageBox.Show("Bạn có muốn sửa khách hàng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (buskhachhang.SuaKhachHang(dtokhachhang))
                {
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_khachhang();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            Load_khachhang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ResetValues();
            Load_khachhang();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 1)
            {
                txtMaKH.Enabled = true;
                txtTenKH.Enabled = true;
                txtDienThoai.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoqua.Enabled = true;
                btnThoat.Enabled = true;
                txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Không có thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string TenKH = txtSearch.Text;
            DataTable table = buskhachhang.TimKiemKhachHang(TenKH);
            if (table.Rows.Count > 0)
            {
                dgvKhachHang.DataSource = table;
                dgvKhachHang.Columns[0].HeaderText = "MaKH";
                dgvKhachHang.Columns[1].HeaderText = "TenKH";
                dgvKhachHang.Columns[2].HeaderText = "DienThoai";
                dgvKhachHang.Columns[3].HeaderText = "Email";
                dgvKhachHang.Columns[4].HeaderText = "DiaChi";
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetValues();
            txtSearch.BackColor = Color.White;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.LightGray;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text != "")
            {
                try
                {
                    int phone = Int32.Parse(txtDienThoai.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Số điện thoại không được nhập chữ!!");
                    txtDienThoai.Text = "";
                    txtDienThoai.Focus();
                    return;
                }
            }
        }
    }
}
