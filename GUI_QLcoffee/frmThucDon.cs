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
        string stremail = frmMain.mail;
        string fileName;
        string fileSavePath;
        string fileAddress;

        public frmThucDon()
        {
            InitializeComponent();
        }

        private void load_thucdon()
        {
            dgvThucDon.DataSource = busthucdon.DSThucDon();
            dgvThucDon.Columns[0].HeaderText = "Mã Thực Đơn";
            dgvThucDon.Columns[1].HeaderText = "Tên Thực Đơn";
            dgvThucDon.Columns[2].HeaderText = "Giá";
            dgvThucDon.Columns[3].HeaderText = "Hình Ảnh";
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
            picThucDon.BackgroundImage = global::GUI_QLcoffee.Properties.Resources.Menu;
        }

        private void frmThucDon_Load(object sender, EventArgs e)
        {
            ResetValues();
            load_thucdon();
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTD.Text = null;
            txtTenTD.Text = null;
            txtGia.Text = null;
            txtMaTD.Enabled = false;
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
            if (txtTenTD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá của thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải upoad hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DTO_ThucDon dtothucdon = new DTO_ThucDon(txtTenTD.Text, double.Parse(txtGia.Text), txtHinh.Text);
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
            dialog.Filter = "Images files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
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
                txtHinh.Text = "\\Images\\" + fileName;
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
                txtHinh.Text = dgvThucDon.CurrentRow.Cells[3].Value.ToString();
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
                if (busthucdon.XoaThucDon(MaTD))
                {
                    MessageBox.Show("Xóa thực đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DTO_ThucDon dtothucdon = new DTO_ThucDon(int.Parse(txtMaTD.Text), txtTenTD.Text, double.Parse(txtGia.Text), txtHinh.Text);
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.BackColor = Color.LightGray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string TenTD = txtSearch.Text;
            DataTable table = busthucdon.TimKiemThucDon(TenTD);
            if (table.Rows.Count > 0)
            {
                dgvThucDon.DataSource = table;
                dgvThucDon.Columns[0].HeaderText = "Mã Thực Đơn";
                dgvThucDon.Columns[1].HeaderText = "Tên Thực Đơn";
                dgvThucDon.Columns[2].HeaderText = "Giá";
                dgvThucDon.Columns[3].HeaderText = "Hình Ảnh";
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetValues();
            txtSearch.BackColor = Color.White;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGia.Text != "")
                {
                    int phone = Int32.Parse(txtGia.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Giá không được nhập chữ!");
                txtGia.Text = "";
                txtGia.Focus();
                return;
            }
        }
    }
}
