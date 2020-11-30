using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLcoffee
{
    public class DTO_NhanVien
    {
        private string maNv;
        private string email;
        private string tenNv;
        private string diaChi;
        private int vaiTro;
        private int tinhTrang;
        private string soDt;
        private string matKhau;

        public string MaNV
        {
            get
            {
                return maNv;
            }
            set
            {
                maNv = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string TenNV
        {
            get
            {
                return tenNv;
            }
            set
            {
                tenNv = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int VaiTro
        {
            get
            {
                return vaiTro;
            }
            set
            {
                vaiTro = value;
            }
        }
        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }
            set
            {
                tinhTrang = value;
            }
        }
        public string SoDT
        {
            get
            {
                return soDt;
            }
            set
            {
                soDt = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public DTO_NhanVien(string maNv, string email, string tenNv, string diaChi, int vaiTro, int tinhTrang, string soDt)
        {
            this.maNv = maNv;
            this.email = email;
            this.tenNv = tenNv;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
            this.soDt = soDt;
        }
        public DTO_NhanVien() { }
    }
}
