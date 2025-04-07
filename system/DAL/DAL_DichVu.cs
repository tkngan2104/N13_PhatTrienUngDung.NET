using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DichVu
    {
        QLResortDataContext db= new QLResortDataContext();
        // Lấy danh sách dịch vụ
        public List<ET_DichVu> layDSDV()
        {
            var dv = from el in db.DichVus
                     select new ET_DichVu(el.maDV, el.tenDV, el.giaTien); // Chuyển đổi thành đối tượng ET_DichVu
            return dv.ToList(); // Trả về danh sách
        }
    }
}
