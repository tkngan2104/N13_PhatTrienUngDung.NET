using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DatPhong
    {
        private string maNS, maDP, maKH;

        private DateTime ngayDP;

        public ET_DatPhong(string maNS, string maDP, string maKH, DateTime ngayDP)
        {
            this.maNS = maNS;
            this.maDP = maDP;
            this.maKH = maKH;
            this.ngayDP = ngayDP;
        }

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaDP { get => maDP; set => maDP = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayDP { get => ngayDP; set => ngayDP = value; }
    }
}