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

namespace GUI_QLcoffee
{
    public partial class frmHoaDon : Form
    {
        BUS_KhachHang bus_Khachhang = new BUS_KhachHang();
        BUS_ThucDon bus_Thucdon = new BUS_ThucDon();
        DataTable dt = new DataTable();
        float dem = 0;
        DateTime now = DateTime.Now;
        public frmHoaDon(string tennv)
        {
            InitializeComponent();
            lblTenNV.Text = tennv;
            //testcommitt
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
            loadtongtien();
        }
        public void loaddata()
        {
            DataTable dsmon = bus_Thucdon.DanhSachTenMon();
            cboTenMon.DataSource = dsmon;
            cboTenMon.DisplayMember = "TenTD";
            cboTenMon.ValueMember = "TenTD";
            cboTenMon.Text = "Vui lòng chọn tên món!";
            DataTable dskh = bus_Khachhang.DanhSachTenKhach();
            cboTenKH.DataSource = dskh;
            cboTenKH.DisplayMember = "TenKhach";
            cboTenKH.ValueMember = "TenKhach";
            NumSoLuong.Value = 0;
            lblDatetime.Text = now.ToString();
            dt.Clear();
            try
            {
                dt.Columns.Add("TenNV");
                dt.Columns.Add("TenKH");
                dt.Columns.Add("TenMon");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("DonGia");
                dt.Columns.Add("ThanhTien");
            }
            catch (Exception)
            { }
            dgvHoaDon.DataSource = dt;
        }
        public void loadtongtien()
        {
            txtTongtien.Text = "0";
        }

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            if (cboTenMon.Text != "Vui lòng chọn tên món!" && NumSoLuong.Value != 0) 
            {
                try
                {
                    DataRow adddt = dt.NewRow();
                    adddt["TenNV"] = lblTenNV.Text;
                    adddt["TenKH"] = cboTenKH.Text;
                    adddt["TenMon"] = cboTenMon.Text;
                    adddt["SoLuong"] = int.Parse(NumSoLuong.Value.ToString());
                    adddt["DonGia"] = int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text));
                    adddt["ThanhTien"] = (int.Parse(NumSoLuong.Value.ToString()) * int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text)));
                    dt.Rows.Add(adddt);
                    dem += (int.Parse(NumSoLuong.Value.ToString()) * int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text)));
                }
                catch (Exception x)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin! " + x.Message);
                }
                finally
                {
                    txtTongtien.Text = dem.ToString();
                    dgvHoaDon.DataSource = dt;
                }
            }
            else { MessageBox.Show("Vui lòng chọn số lượng hoặc tên món!", "Thông Báo", MessageBoxButtons.OK); }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (bus_Thucdon.ThanhToanTien(cboTenKH.Text, lblTenNV.Text, now, float.Parse(txtTongtien.Text)))
            {
                MessageBox.Show("Thanh toán thành công!");
                loadtongtien();
                loaddata();
            }
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void linkKH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }
        private void picboxRes_Click_1(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }
    }
}
