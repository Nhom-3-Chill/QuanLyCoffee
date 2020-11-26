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
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            btnLuu.Enabled = true;
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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
