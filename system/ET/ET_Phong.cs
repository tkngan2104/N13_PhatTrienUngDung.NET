using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Phong
    {
        private string maP, tenLP, tenLG, trangThai;
        private float giaP;

        public ET_Phong(string maP, string tenLP, string tenLG, string trangThai, float giaP)
        {
            this.maP = maP;
            this.tenLP = tenLP;
            this.tenLG = tenLG;
            this.trangThai = trangThai;
            this.giaP = giaP;
        }

        public string MaP { get => maP; set => maP = value; }
        public string TenLP { get => tenLP; set => tenLP = value; }
        public string TenLG { get => tenLG; set => tenLG = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public float GiaP { get => giaP; set => giaP = value; }
    }
}
