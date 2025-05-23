using ET;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class BUS_MonAn
    {
        private readonly DAL_MonAn dal = new DAL_MonAn();
        public DataTable LayDSLoaiMonAn()
        {
            return dal.LayDSLoaiMonAn();
        }
        public DataTable loadDSMA()
        {
            return dal.loadDSMA();
        }
        public bool themMA(ET_MonAn et)
        {
            return dal.themMA(et);
        }
        public bool xoaMA(string ma)
        {
            return dal.xoaMA(ma);
        }
        public bool SuaMA(ET_MonAn et)
        {
            return dal.suaMA(et);
        }
        public string taoMaMA(string maMA)
        {
            return dal.TaoMaTuDong(maMA);
        }
        public string GetLoaiMonAnFromMaMA(string maMA)
        {
            return dal.GetLoaiMonAnFromMaMA(maMA);
        }

        public List<string> LayMonAnTheoTen()
        {
            return dal.LayMonAnTheoTen();
        }

        public ET_MonAn LayTatCaMonAn(string ten)
        {
            var monAn = dal.LayTatCaMonAn().FirstOrDefault(m => m.TenMA == ten);
            return monAn;
        }
        public List<ET_MonAn> LayTatCaMonAn()
        {
            return dal.LayTatCaMonAn(); // Gọi hàm trong DAL bạn đã viết
        }
    }
}
