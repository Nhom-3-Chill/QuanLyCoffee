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
    public partial class frmThongKe : Form
    {
        BUS_ThucDon busthucdon = new BUS_ThucDon();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void thongkesanpham()
        {
            dgvThongKe.DataSource = busthucdon.XemThongKe(dtpBatDau.Value, dtpKetthuc.Value);
            dgvThongKe.Columns[0].HeaderText = "ngayBD";
            dgvThongKe.Columns[1].HeaderText = "ngayKT";
            dgvThongKe.Columns[2].HeaderText = "MaHD";
            dgvThongKe.Columns[3].HeaderText = "TenTD";
            dgvThongKe.Columns[4].HeaderText = "Soluong";
            dgvThongKe.Columns[5].HeaderText = "Gia";
            dgvThongKe.Columns[6].HeaderText = "TongThanhTien";

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongkesanpham();
        }
    }
}
