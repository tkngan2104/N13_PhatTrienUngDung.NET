using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_MonAn
    {
        private string _MaMA;
        private string _MaLMA;
        private string _TenMA;
        private float _GiaTien;
        private string _MieuTa;

        public string MaMA { get => _MaMA; set => _MaMA = value; }
        public string MaLMA { get => _MaLMA; set => _MaLMA = value; }
        public string TenMA { get => _TenMA; set => _TenMA = value; }
        public float GiaTien { get => _GiaTien; set => _GiaTien = value; }
        public string MieuTa { get => _MieuTa; set => _MieuTa = value; }
        public ET_MonAn() { }
        public ET_MonAn(string maMA, string maLMA, string tenMA, float giaTien, string mieuTa)
        {
            MaMA = maMA;
            MaLMA = maLMA;
            TenMA = tenMA;
            GiaTien = giaTien;
            MieuTa = mieuTa;
        }
    }
}
