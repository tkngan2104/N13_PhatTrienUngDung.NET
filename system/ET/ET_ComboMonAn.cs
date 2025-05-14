using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ComBoMonAn
    {
        private string _MaCB, _TenCB;
        private float _GiaCB;

        public ET_ComBoMonAn() { }
        public ET_ComBoMonAn(string maCB, string tenCB, float giaCB)
        {
            _MaCB = maCB;
            _TenCB = tenCB;
            _GiaCB = giaCB;
        }

        public string MaCB { get => _MaCB; set => _MaCB = value; }
        public string TenCB { get => _TenCB; set => _TenCB = value; }
        public float GiaCB { get => _GiaCB; set => _GiaCB = value; }
    }
}
