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
    public partial class frmThucDon : Form
    {
        BUS_ThucDon busthucdon = new BUS_ThucDon();

        public frmThucDon()
        {
            InitializeComponent();
        }

        private void load_thucdon()
        {
            dgvThucDon.DataSource = busthucdon.DSThucDon();
            dgvThucDon.Columns[0].HeaderText = "MaTD";
            dgvThucDon.Columns[1].HeaderText = "TenTD";
            dgvThucDon.Columns[2].HeaderText = "Gia";
            dgvThucDon.Columns[3].HeaderText = "HinhAnh";
        }

        public void ResetValues()
        {
            txtMaTD.Text = null;
            txtTenTD.Text = null;
            txtGia.Text = null;
            txtMaTD.Enabled = false;
            txtTenTD.Enabled = false;
            txtGia.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnThoat.Enabled = true;
            btnHinhAnh.Enabled = false;
        }

        private void frmThucDon_Load(object sender, EventArgs e)
        {
            ResetValues();
            load_thucdon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTD.Text = null;
            txtTenTD.Text = null;
            txtGia.Text = null;
            txtMaTD.Enabled = true;
            txtTenTD.Enabled = true;
            txtGia.Enabled = true;
            btnHinhAnh.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenTD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá của thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (btnHinhAnh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập hình ảnh của thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaTD.Text != "" && txtTenTD.Text != "" && txtGia.Text != "")
            {
                DTO_ThucDon dtothucdon = new DTO_ThucDon(int.Parse(txtMaTD.Text), txtTenTD.Text, double.Parse(txtGia.Text), btnHinhAnh.Text);
                if (busthucdon.LuuThucDon(dtothucdon))
                {
                    MessageBox.Show("Thêm thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    load_thucdon();
                }
                else
                {
                    MessageBox.Show("Thêm thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
