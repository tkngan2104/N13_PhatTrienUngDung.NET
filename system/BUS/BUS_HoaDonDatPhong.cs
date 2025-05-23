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
            return DAL_HoaDonDatPhong.Instance.TaoMaTuDong();
        }

        //public void DSHDDP(DataGridView dgvDSHDDP, string hddp)
        //{
        //    dgvDSHDDP.DataSource = DAL_HoaDonDatPhong.Instance.DSHDDP(hddp);
        //}

        public IQueryable<ET_HoaDonDatPhong> timSDT(string sdt)
        {
           return DAL_HoaDonDatPhong.Instance.TimKiemTheoSDTKhach(sdt);
        }

        public List<ET_SuDungDichVu> LayDSDichVuTheoMaCTDP(string maCTDP)
        {
            return DAL_HoaDonDatPhong.Instance.LayDSDichVuTheoMaCTDP(maCTDP);
        }


        public float LayGiaPhong(string maCTDP)
        {
            return DAL_HoaDonDatPhong.Instance.LayGiaPhongTheoMaCTDP(maCTDP);
        }
        public string LayMaNhanSuTheoCTDP(string maCTDP)
        {
            return DAL_HoaDonDatPhong.Instance.LayMaNhanSuTheoCTDP(maCTDP);
        }
    }
}
