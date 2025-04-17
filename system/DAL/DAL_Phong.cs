using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;

namespace DAL
{
    public class DAL_Phong
    {
        //Khai báo biến tĩnh
        private static DAL_Phong instance;


        public static DAL_Phong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Phong();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Đổ dữ liệu loại phòng.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSPhongCombobox(ComboBox cbo)
        {
            IQueryable dl = from p in db.Phongs
                            group p by p.tenLP into grouped
                            select new { tenLP = grouped.Key };
            return dl;
        }

        /// <summary>
        /// Đổ dữ liệu loại giường.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSGiuongCombobox(ComboBox cbo)
        {
            IQueryable dl = from p in db.Phongs
                            group p by p.tenLG into grouped
                            select new { tenLG = grouped.Key };
            return dl;
        }

        /// <summary>
        /// Đổ dữ liệu trạng thái.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSTrangThaiCombobox(ComboBox cbo)
        {
            IQueryable dl = from p in db.Phongs
                            group p by p.trangThai into grouped
                            select new { trangThai = grouped.Key };
            return dl;
        }

        /// <summary>
        /// Mã phòng tự động.
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns></returns>
        public string TaoMaTuDong(string loaiPhong)
        {
            string phong = loaiPhong.Trim().ToLower() == "vip" ? "PVIP" : "PTHG";
            //string giuong = loaiGiuong.Trim().ToLower().Contains("đôi") ? "DOI" : "DON";

            int countMaMP = db.Phongs.Count(p => p.maPhong.StartsWith(phong)) + 1;

            string newMa;
            do
            {
                if (countMaMP < 10)
                {
                    newMa = $"{phong}00{countMaMP}";
                }
                else if (countMaMP < 100)
                {
                    newMa = $"{phong}{countMaMP}";
                }
                else
                {
                    newMa = $"{phong}{countMaMP}";
                }

                countMaMP++;

            } while (db.Phongs.Any(p => p.maPhong == newMa));

            return newMa;
        }

        /// <summary>
        /// Lấy danh sách phòng.
        /// </summary>
        /// <returns></returns>
        public string LayMaPhong()
        {
            return db.Phongs.FirstOrDefault()?.maPhong;
        }

        /// <summary>
        /// Danh sách phòng.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSPhong(string tenLP, string tenLG)
        {
            var phong = from p in db.Phongs
                        where p.tenLP == tenLP && p.tenLG.Trim().Contains(tenLG.Trim())
                        select p;
            return phong;
        }

        /// <summary>
        /// Thêm phòng.
        /// </summary>
        /// <param name="etP"></param>
        /// <returns></returns>
        public bool ThemPhong(ET_Phong etP)
        {
            if (db.Phongs.Any(p => p.maPhong == etP.MaP))
            {
                return false;
            }
            else
            {
                try
                {
                    Phong p = new Phong
                    {
                        maPhong = etP.MaP,
                        tenLP = etP.TenLP,
                        tenLG = etP.TenLG,
                        giaP = etP.GiaP,
                        trangThai = etP.TrangThai
                    };
                    db.Phongs.InsertOnSubmit(p);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        /// <summary>
        /// Xóa phòng.
        /// </summary>
        /// <param name="maP"></param>
        /// <returns></returns>
        public bool XoaPhong(string maP)
        {
            try
            {
                var xoa = from p in db.Phongs
                          where p.maPhong == maP
                          select p;

                foreach (var x in xoa)
                {
                    db.Phongs.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                return false;
            }
        }

        /// <summary>
        /// Sửa phòng.
        /// </summary>
        /// <param name="etP"></param>
        public void SuaPhong(ET_Phong etP)
        {
            var update = db.Phongs.Single(p => p.maPhong == etP.MaP);

            update.tenLP = etP.TenLP;
            update.tenLG = etP.TenLG;
            update.giaP = etP.GiaP;
            update.trangThai = etP.TrangThai;

            db.SubmitChanges();
        }
    }
}
