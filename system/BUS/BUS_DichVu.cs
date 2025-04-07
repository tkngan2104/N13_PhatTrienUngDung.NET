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
    }
}
