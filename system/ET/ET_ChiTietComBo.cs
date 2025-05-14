using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietComBo
    {
        private string _MaCTCB, _MaCB, _MaMA;
        public ET_ChiTietComBo() { }
        public ET_ChiTietComBo(string maCTCB, string maCB, string maMA)
        {
            _MaCTCB = maCTCB;
            _MaCB = maCB;
            _MaMA = maMA;
        }

        public string MaCTCB { get => _MaCTCB; set => _MaCTCB = value; }
        public string MaCB { get => _MaCB; set => _MaCB = value; }
        public string MaMA { get => _MaMA; set => _MaMA = value; }
    }
}
