using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_DichVu
    {
        //Khai báo biến tĩnh.
        private static BUS_DichVu instance;
        //private DAL_DichVu dal_dv = new DAL_DichVu();

        public static BUS_DichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DichVu();
                }
                return instance;
            }
        }

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

        /// <summary>
        /// Lấy gợi ý dịch vụ.
        /// </summary>
        /// <returns></returns>
        public List<string> LayTatCaTenDichVu()
        {
            return dal.LayTatCaTenDichVu();
        }

        /// <summary>
        /// Lấy giá dịch vụ theo tên.
        /// </summary>
        /// <param name="tenDV"></param>
        /// <returns></returns>
        public int LayGiaDichVuTheoTen(string tenDV)
        {
            return dal.LayGiaDichVuTheoTen(tenDV);
        }

        /// <summary>
        /// Lấy mã dịch vụ theo tên.
        /// </summary>
        /// <param name="tenDV"></param>
        /// <returns></returns>
        public List<DichVu> LayMaDichVuTheoTen(string tenDV)
        {
            return dal.LayMaDichVuTheoTen(tenDV);
        }
    }
}
