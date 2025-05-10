using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietDatPhong
    {
        //Khai báo biến tĩnh
        private static DAL_ChiTietDatPhong instance;


        public static DAL_ChiTietDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietDatPhong();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Tìm kiếm loại hình trong chi tiết đặt phòng.
        /// </summary>
        /// <param name="tenLH"></param>
        /// <returns></returns>
        public List<ChiTietDatPhong> TimTheoTenLoaiHinh(string tenLH)
        {
            List<ChiTietDatPhong> ds = new List<ChiTietDatPhong>();

            var result = db.sp_TimChiTietDatPhongTheoTenLH(tenLH);

            foreach (var item in result)
            {
                ChiTietDatPhong ctdp = new ChiTietDatPhong();
                ctdp.maCTDP = item.maCTDP;
                ctdp.maDP = item.maDP;
                ctdp.maLH = item.maLH;
                ctdp.ngayTraPhong = item.ngayTraPhong;

                ds.Add(ctdp);
            }

            return ds;
        }

        /// <summary>
        /// Mã tự động chi tiết đặt phòng.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            string dinhdangngay = DateTime.Now.ToString("ddMMyy");
            int countMa = db.ChiTietDatPhongs.Count() + 1;

            //Tạo mã mới.
            string newMa;
            do
            {
                if (countMa < 10)
                {
                    newMa = $"CTDP{dinhdangngay}00{countMa}";
                }
                else if (countMa < 100)
                {
                    newMa = $"CTDP{dinhdangngay}0{countMa}";
                }
                else
                {
                    newMa = $"CTDP{dinhdangngay}{countMa}";
                }
                countMa++;
            } while (db.ChiTietDatPhongs.Any(dv => dv.maCTDP == newMa));
            return newMa;
        }

        /// <summary>
        /// Hiển thị loại hình trống
        /// </summary>
        /// <param name="maLH"></param>
        /// <returns></returns>
        public IQueryable HienThiPhongTrong(string maLH)
        {
            IQueryable loaihinh1 = from gb in db.LoaiHinhLuuTrus
                                    where gb.loaiHinh == maLH && gb.trangThai == "Trống"
                                    select gb;
            return loaihinh1;
        }

       

        /// <summary>
        /// Hiển thị chi tiết thêm phòng.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSChiTietDatPhong()
        {
            IQueryable chitiet = from ctdp in db.ChiTietDatPhongs
                                 join lh in db.LoaiHinhLuuTrus on ctdp.maLH equals lh.maLH
                                 select new
                                 {
                                     MaDP = ctdp.maDP,
                                     MaCTDP = ctdp.maCTDP,
                                     MaLH = ctdp.maLH,
                                     NgayTraPhong = ctdp.ngayTraPhong
                                 };
            return chitiet;
        }

        /// <summary>
        /// Thêm chi tiết đặt phòng.
        /// </summary>
        /// <param name="etCT"></param>
        /// <returns></returns>
        public bool ThemCTDP(ET_ChiTietDatPhong etCT)
        {
            try
            {
                //Tạo một đối tượng mới.
                ChiTietDatPhong ct = new ChiTietDatPhong
                {
                    maDP = etCT.MaDP,
                    maCTDP = etCT.MaCTDP,
                    maLH = etCT.MaLH,
                    ngayTraPhong = etCT.NgayTraPhong
                };
                //Thêm loại hàng vào cơ sở dữ liệu
                db.ChiTietDatPhongs.InsertOnSubmit(ct);
            }
            finally
            {
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
            // Trả về true để báo hiệu việc thêm mới thành công
            return true;
        }

        /// <summary>
        /// Cập nhật trạng thái theo ngày.
        /// </summary>
        public void CapNhatTrangThaiPhongTheoNgay()
        {
            using (var context = new QLResortDataContext())
            {
                DateTime ngayHienTai = DateTime.Now.Date;

                // Lấy danh sách phòng có ngày trả phòng đúng ngày hôm nay
                var phongCanCapNhat = context.ChiTietDatPhongs
                    .Where(p => p.ngayTraPhong.HasValue && p.ngayTraPhong.Value.Date == ngayHienTai)
                    .ToList();
                
                // Cập nhật trạng thái
                foreach (var phong in phongCanCapNhat)
                {
                    var loaiHinh = context.LoaiHinhLuuTrus
                .FirstOrDefault(l => l.maLH == phong.maLH);

                    if (loaiHinh != null)
                    {
                        loaiHinh.trangThai = "Trống";
                    }

                }

                // Lưu thay đổi vào CSDL
                context.SubmitChanges();
            }
        }

        /// <summary>
        /// Cập nhật trạng thái phòng.
        /// </summary>
        /// <param name="maLH"></param>
        /// <param name="trangThai"></param>
        public void CapNhatTrangThaiPhong(string maLH, string trangThai)
        {
            var phong = db.LoaiHinhLuuTrus.SingleOrDefault(p => p.maLH == maLH);
            if (phong != null)
            {
                phong.trangThai = trangThai;
                db.SubmitChanges();
            }
        }
    }
}
