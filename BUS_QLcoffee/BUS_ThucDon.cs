using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLcoffee;
using DTO_QLcoffee;

namespace BUS_QLcoffee
{
    public class BUS_ThucDon
    {
        DAL_ThucDon dal_ThucDon = new DAL_ThucDon();
        public DataTable DSThucDon()
        {
            return dal_ThucDon.DSThucDon();
        }

        public bool LuuThucDon(DTO_ThucDon td)
        {
            return dal_ThucDon.LuuThucDon(td);
        }

        public bool SuaThucDon(DTO_ThucDon td)
        {
            return dal_ThucDon.SuaThucDon(td);
        }

        public bool XoaThucDon(string MaTD)
        {
            return dal_ThucDon.XoaThucDon(MaTD);
        }

        public DataTable TimKiemThucDon(string tenTD)
        {
            return dal_ThucDon.TimKiemThucDon(tenTD);
        }

        public DataTable XemThongKe(DateTime ngayBT, DateTime ngayKT)
        {
            return dal_ThucDon.XemThongKe(ngayBT, ngayKT);
        }

        public DataTable DanhSachTenMon()
        {
            return dal_ThucDon.DanhSachTenMon();
        }

        public string DonGiaMon(string tenmon)
        {
            return dal_ThucDon.DonGiaMon(tenmon);
        }

        public bool ThanhToanTien(string tenkh, string tennv, DateTime ngaylap, float tongtien)
        {
            return dal_ThucDon.ThanhToanTien(tenkh, tennv, ngaylap, tongtien);
        }
        //BoSungThongKe
        public DataTable XemTopMon(DateTime ngayBD, DateTime ngayKT)
        {
            return dal_ThucDon.XemTopMon(ngayBD, ngayKT);
        }
        public string LayMaHD()
        {
            return dal_ThucDon.LayMaHD();
        }
        public bool LuuHD(int mahd, string tentd, int soluong)
        {
            return dal_ThucDon.LuuHD(mahd, tentd, soluong);
        }
    }
}
