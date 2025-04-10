using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dal = new DAL_ChucVu();
        public IQueryable loadDSCV()
        {
            return dal.loadDSCV();
        }
        public bool themCV(ET_ChucVu et)
        {
            return dal.themCV(et);
        }
        public bool xoaCV(string ma)
        {
            return dal.xoaCV(ma);
        }
        public bool SuaCV(ET_ChucVu et)
        {
            return dal.suaCV(et);
        }
        public string taoMaCV()
        {
            return dal.taoMaTuDong();
        }
    }
}
