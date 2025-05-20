using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatPhong
    {
        //Khai báo biến tĩnh
        private static DAL_DatPhong instance;

        public static DAL_DatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_DatPhong();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Mã đặt phòng tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            string dinhdangngay = DateTime.Now.ToString("ddMMyy");
            int countMa = db.DatPhongs.Count() + 1;

            //Tạo mã mới.
            string newMa;
            do
            {
                if (countMa < 10)
                {
                    newMa = $"DP{dinhdangngay}000{countMa}";
                }
                else if (countMa < 100)
                {
                    newMa = $"DP{dinhdangngay}00{countMa}";
                }
                else if (countMa < 1000)
                {
                    newMa = $"DP{dinhdangngay}0{countMa}";
                }
                else
                {
                    newMa = $"DT{dinhdangngay}{countMa}";
                }
                countMa++;
            } while (db.DatPhongs.Any(dp => dp.maDP == newMa));
            return newMa;
        }

        /// <summary>
        /// Danh sách đặt phòng.
        /// </summary>
        /// <param name="dp"></param>
        /// <returns></returns>
        public List<ET_DatPhong> DSDatPhong()
        {
            var datphong = from dp in db.DatPhongs
                           join kh in db.KhachHangs on dp.MaKH equals kh.MaKH
                           orderby dp.maDP descending
                           select new ET_DatPhong(
                               dp.MaNhanSu,
                               dp.maDP,
                               kh.MaKH,
                               dp.ngayDatPhong
                           );

            return datphong.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="etDP"></param>
        /// <returns></returns>
        public bool ThemDatPhong(ET_DatPhong etDP)
        {
            try
            {
                DatPhong nh = new DatPhong
                {
                    MaNhanSu = etDP.MaNS,
                    maDP = etDP.MaDP,
                    MaKH = etDP.MaKH,
                    ngayDatPhong = etDP.NgayDP
                };

                db.DatPhongs.InsertOnSubmit(nh);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
