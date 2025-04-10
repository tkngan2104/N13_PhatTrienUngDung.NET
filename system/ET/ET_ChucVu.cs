using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChucVu
    {
        private string _MaChucVu;
        private string _TenChucVu;

        public string MaChucVu { get => _MaChucVu; set => _MaChucVu = value; }
        public string TenChucVu { get => _TenChucVu; set => _TenChucVu = value; }
        public ET_ChucVu() { }
        public ET_ChucVu(string ma, string ten)
        {
            _MaChucVu = ma;
            _TenChucVu = ten;
        }
    }
}
