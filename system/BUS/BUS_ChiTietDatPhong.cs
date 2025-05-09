using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiTietDatPhong
    {
        //Khai báo biến tĩnh.
        private static BUS_ChiTietDatPhong instance;
        private DAL_ChiTietDatPhong dal_p = new DAL_ChiTietDatPhong();

        public static BUS_ChiTietDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietDatPhong();
                }
                return instance;
            }
        }

        /// <summary>
        /// Tìm kiếm loại hình trong chi tiết đặt phòng.
        /// </summary>
        /// <param name="tenLH"></param>
        /// <returns></returns>
        public List<ChiTietDatPhong> TimTheoTenLoaiHinh(string tenLH)
        {
            return dal_p.TimTheoTenLoaiHinh(tenLH);
        }
    }
}
