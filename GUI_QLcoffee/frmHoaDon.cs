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
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            DataTable dsmon = bus_Thucdon.DanhSachTenMon();
            cboTenMon.DataSource = dsmon;
            DataTable dskh = bus_Khachhang.DanhSachTenKhach();
            cboTenKH.DataSource = dskh;
            dt.Clear();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("TenMon");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dgvHoaDon.DataSource = dt;
        }

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            DataRow adddt = dt.NewRow();
            adddt["MaNV"] = "";
            adddt["TenKH"] = cboTenKH.Text;
            adddt["TenMon"] = cboTenMon.Text;
            adddt["SoLuong"] = int.Parse(NumSoLuong.Value.ToString());
            adddt["DonGia"] = int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text));
            adddt["ThanhTien"] = (int.Parse(NumSoLuong.Value.ToString()) * int.Parse(bus_Thucdon.DonGiaMon(cboTenMon.Text)));
            dt.Rows.Add(adddt);
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {

        }
    }
}
