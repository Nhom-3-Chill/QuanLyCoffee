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
            //testcommitt
        }

        private void thongkesanpham()
        {
            //dgvThongKe.DataSource = busthucdon.XemThongKe();
            ////dgvThongKe.DataSource = busthucdon.XemThongKe();
            //dgvThongKe.Columns[0].HeaderText = "ngayBD";
            //dgvThongKe.Columns[1].HeaderText = "ngayKT";
            //dgvThongKe.Columns[2].HeaderText = "TenTD";
            //dgvThongKe.Columns[3].HeaderText = "Soluong";
            //dgvThongKe.Columns[4].HeaderText = "TongThanhTien";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongkesanpham();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
