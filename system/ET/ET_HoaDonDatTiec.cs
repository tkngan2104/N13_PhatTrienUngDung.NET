using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoaDonDatTiec
    {
        private string maNS, maHDDT, maDT, trangThai;

        private DateTime ngayLap;

        private float tongTien;

        public ET_HoaDonDatTiec(string maNS, string maHDDT, string maDT, string trangThai, DateTime ngayLap, float tongTien)
        {
            this.maNS = maNS;
            this.maHDDT = maHDDT;
            this.maDT = maDT;
            this.trangThai = trangThai;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaHDDT { get => maHDDT; set => maHDDT = value; }
        public string MaDT { get => maDT; set => maDT = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
