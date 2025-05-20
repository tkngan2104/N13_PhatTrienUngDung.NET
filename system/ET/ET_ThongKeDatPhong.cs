using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ThongKeDatPhong
    {
        // Khai báo các thuộc tính
        public string maDP { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string maCTDP { get; set; }
        public DateTime ngayDatPhong { get; set; }
        public DateTime ngayTraPhong { get; set; }
        public string maLH { get; set; }
        public string MaNhanSu { get; set; }

        public ET_ThongKeDatPhong(string maDP, string maKH, string tenKH, string maCTDP,
                             DateTime ngayDP, DateTime ngayTP, string maLH, string maNhanSu)
        {
            this.maDP = maDP;
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.maCTDP = maCTDP;
            this.ngayDatPhong = ngayDP;
            this.ngayTraPhong = ngayTP;
            this.maLH = maLH;
            this.MaNhanSu = maNhanSu;
        }

    }
}
