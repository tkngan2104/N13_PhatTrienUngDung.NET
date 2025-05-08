using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietCombo
    {
        private string maCTCB, maCB, maNA;

        public ET_ChiTietCombo(string maCTCB, string maCB, string maNA)
        {
            this.maCTCB = maCTCB;
            this.maCB = maCB;
            this.maNA = maNA;
        }

        public string MaCTCB { get => maCTCB; set => maCTCB = value; }
        public string MaCB { get => maCB; set => maCB = value; }
        public string MaNA { get => maNA; set => maNA = value; }
    }
}
