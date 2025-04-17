using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        private string maNhanSu, hoTen, soDT, cccdNS, emailNS, diaChi, maCV;
        private DateTime ngaySinh, ngayVaoLam;
        private float luongNS;

        public ET_NhanVien(string maNhanSu, string hoTen, string soDT, string cccdNS, string emailNS, string diaChi, string maCV, DateTime ngaySinh, DateTime ngayVaoLam, float luongNS)
        {
            this.maNhanSu = maNhanSu;
            this.hoTen = hoTen;
            this.soDT = soDT;
            this.cccdNS = cccdNS;
            this.emailNS = emailNS;
            this.diaChi = diaChi;
            this.maCV = maCV;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
            this.luongNS = luongNS;
        }

        public string MaNhanSu { get => maNhanSu; set => maNhanSu = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string CccdNS { get => cccdNS; set => cccdNS = value; }
        public string EmailNS { get => emailNS; set => emailNS = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public float LuongNS { get => luongNS; set => luongNS = value; }
    }
}
