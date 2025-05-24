using ET;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_HoaDonDatPhong
    {
        private readonly DAL_HoaDonDatPhong dal = new DAL_HoaDonDatPhong();
        private static BUS_HoaDonDatPhong instance;

        public static BUS_HoaDonDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HoaDonDatPhong();
                }
                return instance;
            }
        }

        // Tạo mã tự động
        public string TaoMaTuDong()
        {
            return dal.TaoMaTuDong();
        }

        //public void DSHDDP(DataGridView dgvDSHDDP, string hddp)
        //{
        //    dgvDSHDDP.DataSource = dal.DSHDDP(hddp);
        //}

        public IQueryable<ET_HoaDonDatPhong> timSDT(string sdt)
        {
           return dal.TimKiemTheoSDTKhach(sdt);
        }

        public List<ET_SuDungDichVu> LayDSDichVuTheoMaCTDP(string maCTDP)
        {
            return dal.LayDSDichVuTheoMaCTDP(maCTDP);
        }


        public float LayGiaPhong(string maCTDP)
        {
            return dal.LayGiaPhongTheoMaCTDP(maCTDP);
        }
        public string LayMaNhanSuTheoCTDP(string maCTDP)
        {
            return dal.LayMaNhanSuTheoCTDP(maCTDP);
        }
    }
}
