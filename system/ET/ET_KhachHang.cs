using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhachHang
    {
        private string maKH, tenKH, soDT, gioiTinh, diaChi, email, cccd, quocTich;
        private DateTime ngaySinh;

        public ET_KhachHang(string maKH, string tenKH, string soDT, string gioiTinh, string diaChi, string email, string cccd, string quocTich, DateTime ngaySinh)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.SoDT = soDT;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Email = email;
            this.Cccd = cccd;
            this.QuocTich = quocTich;
            this.NgaySinh = ngaySinh;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
