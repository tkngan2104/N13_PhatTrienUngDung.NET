using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietDatPhong
    {
        private string maDP, maCTDP, maLH;

        private DateTime ngayTraPhong;

        public ET_ChiTietDatPhong(string maDP, string maCTDP, string maLH, DateTime ngayTraPhong)
        {
            this.maDP = maDP;
            this.maCTDP = maCTDP;
            this.maLH = maLH;
            this.ngayTraPhong = ngayTraPhong;
        }

        public string MaDP { get => maDP; set => maDP = value; }
        public string MaCTDP { get => maCTDP; set => maCTDP = value; }
        public string MaLH { get => maLH; set => maLH = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
    }
}
