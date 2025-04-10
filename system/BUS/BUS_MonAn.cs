using ET;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_MonAn
    {
        private readonly DAL_MonAn dal = new DAL_MonAn();
        public IQueryable loadDSMA()
        {
            return dal.loadDSMA();
        }
        public bool themMA(ET_MonAn et)
        {
            return dal.themMA(et);
        }
        public bool xoaMA(ET_MonAn et)
        {
            return dal.xoaMA(et);
        }
        public bool SuaMA(ET_MonAn et)
        {
            return dal.suaMA(et);
        }
    }
}
