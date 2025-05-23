using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoaDonDatPhong
    {
        private string maNS, maHDDP, maCTDP, maSDDV, trangThai;

        private DateTime ngayLap;

        private float tongTien;
        public ET_HoaDonDatPhong() { }
        public ET_HoaDonDatPhong(string maNS, string maHDDP, string maCTDP, string maSDDV, string trangThai, DateTime ngayLap, float tongTien)
        {
            this.maNS = maNS;
            this.maHDDP = maHDDP;
            this.maCTDP = maCTDP;
            this.maSDDV = maSDDV;
            this.trangThai = trangThai;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaHDDP { get => maHDDP; set => maHDDP = value; }
        public string MaCTDP { get => maCTDP; set => maCTDP = value; }
        public string MaSDDV { get => maSDDV; set => maSDDV = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
