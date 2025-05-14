using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ThongKeDatTiec
    {
        public ET_ThongKeDatTiec(string maDT, string maKH, string tenKH, string maS,
                             DateTime ngayDT, DateTime ngayBatDau, DateTime ngayKetThuc,
                             float tongTien, float giaTriDC, string ghiChu, string maNhanSu)
        {
            this.maDT = maDT;
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.maS = maS;
            this.ngayDT = ngayDT;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.tongTien = tongTien;
            this.giaTriDC = giaTriDC;
            this.ghiChu = ghiChu;
            this.MaNhanSu = maNhanSu;
        }

        public string MaNhanSu { get; set; }
        public string maDT { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime ngayDT { get; set; }
        public string maS { get; set; }
        public string ghiChu { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public float tongTien { get; set; }
        public float giaTriDC { get; set; }
    }
}
