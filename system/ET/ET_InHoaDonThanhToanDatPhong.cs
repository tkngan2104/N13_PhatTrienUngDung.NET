using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_InHoaDonThanhToanDatPhong
    {
        public ET_InHoaDonThanhToanDatPhong(string maHDDP, string maNhanSu, string trangThai, string maCTDP, 
            DateTime ngayLap, string maSDDV, int soLuong, float tongTien)
        {
            this.maHDDP = maHDDP;
            this.MaNhanSu = maNhanSu;
            this.trangThai = trangThai;
            this.maCTDP = maCTDP;
            this.ngayLap = ngayLap;
            this.maSDDV = maSDDV;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }

        // Khai báo các thuộc tính
        public string maHDDP { get; set; }
        public string MaNhanSu { get; set; }
        public string trangThai { get; set; }
        public string maCTDP { get; set; }
        public DateTime ngayLap { get; set; }
        public string maSDDV { get; set; }
        public int soLuong { get; set; }
        public float tongTien { get; set; }


    }
}
