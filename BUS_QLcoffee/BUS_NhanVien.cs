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
    public class BUS_NhanVien
    {
        DAL_NhanVien dAL_nhanvien = new DAL_NhanVien();
        public bool NVDangNhap(DTO_NhanVien nv)
        {
            return dAL_nhanvien.DangNhap(nv);
        }
        public bool NVQuenMatKhau(DTO_NhanVien nv)
        {
            return dAL_nhanvien.QuenMatKhau(nv);
        }
        public bool NVDoiMatKhau(DTO_NhanVien nv, string matkhaucu, string matkhaumoi)
        {
            return dAL_nhanvien.DoiMatKhau(nv,matkhaucu,matkhaumoi);
        }
        public DataTable DSNhanVien()
        {
            return dAL_nhanvien.DSNhanVien();
        }
        public bool LuuNhanVien(DTO_NhanVien nv)
        {
            return dAL_nhanvien.LuuNhanVien(nv);
        }
        public bool XoaNhanVien(string Manv)
        {
            return dAL_nhanvien.XoaNhanVien(Manv);
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return dAL_nhanvien.SuaNhanVien(nv);
        }
        public DataTable TimKiemNhanVien(string nv)
        {
            return dAL_nhanvien.TimKiemNhanVien(nv);
        }

    }
}
