using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiMonAn
    {
        private string maLMA, tenLMA;
        public ET_LoaiMonAn() { }

        public ET_LoaiMonAn(string maLMA, string tenLMA)
        {
            this.MaLMA = maLMA;
            this.TenLMA = tenLMA;
        }

        public string MaLMA { get => maLMA; set => maLMA = value; }
        public string TenLMA { get => tenLMA; set => tenLMA = value; }
    }
}
