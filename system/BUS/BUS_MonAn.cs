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
        public string taoMaMA()
        {
            return dal.taoMaTuDong();
        }
    }
}
