using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiMonAn
    {
        DAL_LoaiMonAn dal = new DAL_LoaiMonAn();

        //Lấy danh sách loại món ăn
        public IQueryable<ET.LoaiMonAn> layDSLMA()
        {
            return dal.layDSLMA();
        }

        //Thêm loại món ăn vào danh sách
        public bool themLMA(ET_LoaiMonAn et)
        {
            return dal.themLoaiMonAn(et);
        }
        //Tạo mã tự động tăng
        public string taoMaLMA()
        {
            return dal.TaoMaLMA();
        } 

        //Xoá loại món ăn
        public bool xoaLMA(string et)
        {
            return dal.xoaLoaiMonAn(et);
        }

        //Sửa loại món ăn
        public bool suaLMA(ET_LoaiMonAn et)
        {
            return dal.SuaLoaiMonAn(et);
        }
    }
}
