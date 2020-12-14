using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLcoffee;
using DTO_QLcoffee;

namespace GUI_QLcoffee
{
    public partial class frmThongKe : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyCoffeeFull.mdf;Integrated Security=True");
        BUS_ThucDon busthucdon = new BUS_ThucDon();

        public frmThongKe()
        {
            InitializeComponent();
            //testcommit
        }        

        private void thongkesanpham()
        {
            dgvThongKe.DataSource = busthucdon.XemThongKe(dtpBatDau.Value, dtpKetthuc.Value);
            dgvThongKe.Columns[0].HeaderText = "Mã hóa đơn";
            dgvThongKe.Columns[1].HeaderText = "Ngày lập hóa đơn";
            dgvThongKe.Columns[2].HeaderText = "Tổng thành tiền";
            dgvThongKe.Columns[3].HeaderText = "Mã khách hàng";
            dgvThongKe.Columns[4].HeaderText = "Mã nhân viên";
        }
        private void thongkemonan()
        {
            dgvThongKe.DataSource = busthucdon.XemTopMon(dtpBatDau.Value, dtpKetthuc.Value);
            dgvThongKe.Columns[0].HeaderText = "Tên món ăn";
            dgvThongKe.Columns[1].HeaderText = "Tổng số lượng";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongkesanpham();
            btnXem.Enabled = false;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            btnXem.Enabled = false;
        }

        private void btnTKMon_Click(object sender, EventArgs e)
        {
            thongkemonan();
            btnXem.Enabled = false;
        }

        private void dgvThongKe_Click(object sender, EventArgs e)
        {
            btnXem.Enabled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count > 1)
            {
                try
                {
                    frmShowCTHD frmshow = new frmShowCTHD(int.Parse(dgvThongKe.CurrentRow.Cells[0].Value.ToString()));
                    frmshow.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tính năng này chỉ áp dụng khi xem thống kê doanh thu!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frmReportThongKe frm = new frmReportThongKe();
            frm.Show();
            connection.Open();
            //string s = "select hd.MaHD, nv.MaNV, kh.TenKhach, td.TenTD, ct.SoLuong, td.Gia, (ct.SoLuong * td.Gia) as 'ThanhTien' from THUCDON td inner join CHITIETHOADON ct on td.MaTD = ct.MaTD inner join HOADON hd on ct.MaHD = hd.MaHD inner join NHANVIEN nv on nv.MaNV = hd.MaNV inner join KHACHHANG kh on kh.MaKH = hd.MaKH group by hd.MaHD, nv.MaNV, kh.TenKhach, td.TenTD, ct.SoLuong, td.Gia having hd.MaHD='" + int.Parse(busthucdon.LayMaHD()) + "'";
            string s = "select * from hoadon group by MaHD, NgayLapHD, TongThanhTien, MaKH, MaNV having NgayLapHD between '" + dtpBatDau.Value + "' and '" + dtpKetthuc.Value + "'";
            string a = "select sum(TongThanhTien) as 'doanhthu' from hoadon";
            SqlDataAdapter adapter = new SqlDataAdapter(s, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(a, connection);
            DataSet set = new DataSet();
            adapter.Fill(set, "HOADON");
            sqlData.Fill(set, "HOADON");
            reportthongke report = new reportthongke();
            report.SetDataSource(set);
            frm.rpThongKe.ReportSource = report;
            connection.Close();
            frm.rpThongKe.Refresh();
        }
    }
}
