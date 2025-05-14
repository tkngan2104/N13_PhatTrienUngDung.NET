using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThanhToanDatTiec
    {
        private readonly DAL_ThanhToanDatTiec dal = new DAL_ThanhToanDatTiec();
        public IQueryable<ET_HoaDonDatTiec> timSDT(string sdt)
        {
            return dal.TimKiemTheoSDTKhach(sdt);
        }
        public IQueryable<ET_DatTiec> LayDTTheoMa(string maDT)
        {
            return dal.LayDatTiecTheoMaDT(maDT);
        }
        public string taoMTD()
        {
            return dal.TaoMaHDDT_TuDong();
        }

        //public List<ChiTietSuDungDTO> LayChiTietSuDung(string maDT)
        //{
        //    var ketQua = new List<ChiTietSuDungDTO>();

        //    var danhSachMonAn = dal.LayDatTiecTheoMaDT(maDT); // Lấy từ DAL
        //    foreach (var mon in danhSachMonAn)
        //    {
        //        ketQua.Add(new ChiTietSuDungDTO
        //        {
        //            Ten = mon.TenMon,
        //            SoLuong = mon.SoLuong,
        //            DonGia = mon.DonGia,
        //            Loai = "Món Ăn"
        //        });
        //    }

        //    var danhSachDichVu = dal.LayDanhSachDichVu(maDT); // Từ DAL
        //    foreach (var dv in danhSachDichVu)
        //    {
        //        ketQua.Add(new ChiTietSuDungDTO
        //        {
        //            Ten = dv.TenDichVu,
        //            SoLuong = dv.SoLuong,
        //            DonGia = dv.DonGia,
        //            Loai = "Dịch Vụ"
        //        });
        //    }

        //    return ketQua;
        //}

    }
}
