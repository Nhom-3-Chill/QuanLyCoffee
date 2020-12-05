using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string fileName;
        string fileSavePath;
        string fileAddress;

        public frmThucDon()
        {
            InitializeComponent();
            //testcommitt
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
            if (txtTenTD.Text != "" && txtGia.Text != "")
            {
                DTO_ThucDon dtothucdon = new DTO_ThucDon(int.Parse(txtMaTD.Text),txtTenTD.Text, double.Parse(txtGia.Text), btnHinhAnh.Text);
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

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.Title = "Chọn ảnh cho thực đơn";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dialog.FileName;
                picThucDon.BackgroundImage = Image.FromFile(fileAddress);
                picThucDon.BackgroundImageLayout = ImageLayout.Stretch;
                fileName = Path.GetFileName(dialog.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
            }
        }

        private void dgvThucDon_Click(object sender, EventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvThucDon.Rows.Count > 1)
            {
                txtTenTD.Enabled = true;
                txtGia.Enabled = true;
                btnHinhAnh.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoqua.Enabled = true;
                btnThoat.Enabled = true;
                txtMaTD.Text = dgvThucDon.CurrentRow.Cells[0].Value.ToString();
                txtTenTD.Text = dgvThucDon.CurrentRow.Cells[1].Value.ToString();
                txtGia.Text = dgvThucDon.CurrentRow.Cells[2].Value.ToString();
                picThucDon.BackgroundImage = Image.FromFile(saveDirectory + dgvThucDon.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thực đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaTD = txtMaTD.Text;
                if (busthucdon.XoaThucDon(int.Parse(MaTD)))
                {
                    MessageBox.Show("Xóa thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    load_thucdon();
                }
                else
                {
                    MessageBox.Show("Xóa thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_ThucDon dtothucdon = new DTO_ThucDon(int.Parse(txtMaTD.Text), txtTenTD.Text, double.Parse(txtGia.Text), btnHinhAnh.Text);
            if (MessageBox.Show("Bạn có muốn sửa thực đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busthucdon.SuaThucDon(dtothucdon))
                {
                    MessageBox.Show("Sửa thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    load_thucdon();
                }
                else
                {
                    MessageBox.Show("Sửa thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ResetValues();
            }
        }
    }
}
