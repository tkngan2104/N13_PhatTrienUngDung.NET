using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DichVu
    {
        private string maDV, tenDV;
        private int giaTien;

        public ET_DichVu() { }
        public ET_DichVu(string maDV, string tenDV, int giaTien)
        {
            this.MaDV = maDV;
            this.TenDV = tenDV;
            this.GiaTien = giaTien;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
    }
}
