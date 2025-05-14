using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ThongKeSuDungDichVu
    {
        public ET_ThongKeSuDungDichVu(string tenDV, int tongSoLanSuDung, float tongTien)
        {
            this.tenDV = tenDV;
            this.TongSoLanSuDung = tongSoLanSuDung;
            this.TongTien = tongTien;
        }

        public string tenDV { get; set; }
        public int TongSoLanSuDung { get; set; }
        public float TongTien { get; set; }
    }
}
