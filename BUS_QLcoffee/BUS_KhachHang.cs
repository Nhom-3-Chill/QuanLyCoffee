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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkhachhang = new DAL_KhachHang();

        public DataTable DSKhachHang()
        {
            return dalkhachhang.DSKhachHang();
        }

        public bool LuuKhachHang(DTO_KhachHang kh)
        {
            return dalkhachhang.LuuKhachHang(kh);
        }

        public bool XoaKhachHang(string MaKhachHang)
        {
            return dalkhachhang.XoaKhachHang(MaKhachHang);
        }

        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            return dalkhachhang.SuaKhachHang(kh);
        }

        public DataTable TimKiemKhachHang(string TenKH)
        {
            return dalkhachhang.TimKiemKhachHang(TenKH);
        }
        public DataTable DanhSachTenKhach()
        {
            return dalkhachhang.DanhSachTenKhach();
        }
    }
}
