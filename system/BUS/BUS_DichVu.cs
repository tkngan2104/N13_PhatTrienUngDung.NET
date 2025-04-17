using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DichVu
    {
        DAL_DichVu dal = new DAL_DichVu();
        // Lấy danh sách dịch vụ
        public List<ET_DichVu> layDSSV()
        {
            return dal.layDSDV();
        }
      

        //thêm dịch vụ
        public bool themDichVu(ET_DichVu et)
        {
            return dal.themDichVu(et);
        }

        //sua dịch vụ
        public bool suaDichVu(ET_DichVu et)
        {
            return dal.suaDichVu(et);
        }

        //xoá dịch vụ
        public bool xoaDichVu(string ma)
        {
            return dal.xoaDichVu(ma);
        }

        //tạo mã dịch vụ tự động
        public string taoMaDV()
        {
            return dal.taoMaTuDong();
        }
    }
}
