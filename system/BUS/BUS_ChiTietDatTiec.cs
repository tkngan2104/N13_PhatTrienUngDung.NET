using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietDatTiec
    {
        private readonly DAL_ChiTietDatTiec dal = new DAL_ChiTietDatTiec();
        public IQueryable layDSCTDT()
        {
            return dal.layDSCTDT();
        }

        // Thêm chi tiết đặt tiệc
        public bool themChiTietDatTiec(ET_ChiTiecDatTiec et)
        {
            return dal.themChiTietDatTiec(et);
        }

        // Xoá chi tiết đặt tiệc
        public bool xoaChiTietDatTiec(string maCTDT)
        {
            return dal.XoaChiTietDatTiec(maCTDT);
        }

        // Sửa chi tiết đặt tiệc
        public bool suaChiTietDatTiec(ET_ChiTiecDatTiec et)
        {
            return dal.suaChiTietDatTiec(et);
        }

        public string taoMaCTDT()
        {
            return dal.TaoMaCTDT();
        }
    }
}
