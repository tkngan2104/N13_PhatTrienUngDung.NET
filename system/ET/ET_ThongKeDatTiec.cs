using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ThongKeDatTiec
    {
        public ET_ThongKeDatTiec(string maNhanSu, string maDT, string maKH, DateTime ngayDT, string maS, string ghiChu, DateTime ngayBatDau, DateTime ngayKetThuc, float tongTien, float giaTriDC)
        {
            MaNhanSu = maNhanSu;
            this.maDT = maDT;
            MaKH = maKH;
            this.ngayDT = ngayDT;
            this.maS = maS;
            this.ghiChu = ghiChu;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.tongTien = tongTien;
            this.giaTriDC = giaTriDC;
        }

        public string MaNhanSu { get; set; }
        public string maDT { get; set; }
        public string MaKH { get; set; }
        public DateTime ngayDT { get; set; }
        public string maS { get; set; }
        public string ghiChu { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public float tongTien { get; set; }
        public float giaTriDC { get; set; }
    }
}
