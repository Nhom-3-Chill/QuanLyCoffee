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
        public frmHoaDon()
        {
            InitializeComponent();
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
            DataTable dskh = bus_Khachhang.DanhSachTenKhach();
            cboTenKH.DataSource = dskh;
            dt.Clear();
            dt.Columns.Add("TenNV");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("TenMon");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dgvHoaDon.DataSource = dt;
        }
        public void loadtongtien()
        {
            txtTongtien.Text = "0";
            txtGiamgia.Text = "0";
        }

        private void btnThemmon_Click(object sender, EventArgs e)
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
                dem += int.Parse(NumSoLuong.Value.ToString()) * int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text));
            }
            catch(Exception x)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin! " + x.Message);
            }
            finally
            {
                txtTongtien.Text = (dem * (float.Parse(txtGiamgia.Text) / 100)).ToString();
                dgvHoaDon.DataSource = dt;
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(bus_Thucdon.ThanhToanTien(cboTenKH.Text, lblTenNV.Text, now, float.Parse(txtTongtien.Text)))
            {
                MessageBox.Show("Thanh toán thành công!");
                loadtongtien();
                loaddata();
            }
        }

        private void frmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
