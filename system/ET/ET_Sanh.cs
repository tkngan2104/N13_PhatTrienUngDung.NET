using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Sanh
    {
        private string maS, tenS;
        private float giaSDT;

        public ET_Sanh(string maS, string tenS, float giaSDT)
        {
            this.maS = maS;
            this.tenS = tenS;
            this.giaSDT = giaSDT;
        }

        public string MaS { get => maS; set => maS = value; }
        public string TenS { get => tenS; set => tenS = value; }
        public float GiaSDT { get => giaSDT; set => giaSDT = value; }
    }
}
