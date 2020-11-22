using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLcoffee
{
    public class DTO_KhachHang
    {
        private string maKh;
        private string tenKh;
        private string soDt;
        private string email;
        private string diaChi;

        public string MaKh
        {
            get
            {
                return maKh;
            }
            set
            {
                maKh = value;
            }
        }
        public string TenKh
        {
            get
            {
                return tenKh;
            }
            set
            {
                tenKh = value;
            }
        }
        public string SoDt
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
        public DTO_KhachHang(string maKh, string tenKh, string soDt, string email, string diaChi)
        {
            this.maKh = maKh;
            this.tenKh = tenKh;
            this.soDt = soDt;
            this.email = email;
            this.diaChi = diaChi;
        }
        public DTO_KhachHang() { }
    }
}
