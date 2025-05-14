using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTiecDatTiec
    {
        private string maCTDT, maDT, maCB, maMA;

        private int soLuong;

        public ET_ChiTiecDatTiec()
        {

        }
        public ET_ChiTiecDatTiec(string maCTDT, string maDT, string maCB, string maMA, int soLuong)
        {
            this.maCTDT = maCTDT;
            this.maDT = maDT;
            this.maCB = maCB;
            this.maMA = maMA;
            this.soLuong = soLuong;
        }

        public string MaCTDT { get => maCTDT; set => maCTDT = value; }
        public string MaDT { get => maDT; set => maDT = value; }
        public string MaCB { get => maCB; set => maCB = value; }
        public string MaMA { get => maMA; set => maMA = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
