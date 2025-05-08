using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ComboMonAn
    {
        private string maCB, tenCB;

        private float giaCB;

        public ET_ComboMonAn(string maCB, string tenCB, float giaCB)
        {
            this.maCB = maCB;
            this.tenCB = tenCB;
            this.giaCB = giaCB;
        }

        public string MaCB { get => maCB; set => maCB = value; }
        public string TenCB { get => tenCB; set => tenCB = value; }
        public float GiaCB { get => giaCB; set => giaCB = value; }
    }
}
