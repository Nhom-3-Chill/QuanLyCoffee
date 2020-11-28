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
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void Load_khachhang()
        {
            dgvKhachHang.DataSource = bus_khachhang.DSKhachHang();
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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

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
    }
}
