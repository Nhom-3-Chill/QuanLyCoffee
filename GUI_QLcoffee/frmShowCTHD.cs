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
    public partial class frmShowCTHD : Form
    {
        BUS_ThucDon bus_ThucDon = new BUS_ThucDon();
        public frmShowCTHD(int mahd)
        {
            InitializeComponent();
            DataTable chitiethd = bus_ThucDon.XemchitietHD(mahd);
            dgvShowCTHD.DataSource = chitiethd;
        }

        private void frmShowCTHD_Load(object sender, EventArgs e)
        {

        }
    }
}
