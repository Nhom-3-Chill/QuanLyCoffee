using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLcoffee
{
    public class DTO_ThucDon
    {
        private string maTD;
        private string tenTD;
        private double gia;
        private string hinhAnh;

        public string MaTD
        {
            get
            {
                return maTD;
            }
            set
            {
                maTD = value;
            }
        }

        public string TenTD
        {
            get
            {
                return tenTD;
            }
            set
            {
                tenTD = value;
            }
        }
        public double Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }
        public string HinhAnh
        {
            get
            {
                return hinhAnh;
            }
            set
            {
                hinhAnh = value;
            }
        }
        public DTO_ThucDon(string maTD, string tenTD, double gia, string hinhAnh)
        {
            this.maTD = maTD;
            this.tenTD = tenTD;
            this.gia = gia;
            this.hinhAnh = hinhAnh;
        }
        //public DTO_ThucDon(string tenTD, double gia, string hinhAnh)
        //{
        //    this.tenTD = tenTD;
        //    this.gia = gia;
        //    this.hinhAnh = hinhAnh;
        //}
        public DTO_ThucDon() { }
    }
}
