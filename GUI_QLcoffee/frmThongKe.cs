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
    }
}
