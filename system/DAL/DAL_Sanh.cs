using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
namespace DAL
{
    public class DAL_Sanh
    {
        //Khai báo biến tĩnh
       // private static DAL_Phong instance;

        //public static DAL_Phong Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new DAL_Phong();
        //        }
        //        return instance;
        //    }
        //}

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Mã sảnh tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            int countMaS = db.SanhDatTiecs.Count();

            string newMaS;
            do
            {
                char letter = (char)('A' + countMaS);
                newMaS = $"SANH{letter}";

                countMaS++;
            } while (db.SanhDatTiecs.Any(s => s.maS == newMaS));

            return newMaS;
        }

        /// <summary>
        /// Danh sách sảnh.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSSanh()
        {
            IQueryable sanh = from s in db.SanhDatTiecs
                              select s;
            return sanh;
        }

        /// <summary>
        /// Thêm sảnh.
        /// </summary>
        /// <param name="etS"></param>
        /// <returns></returns>
        public bool ThemSanh(ET_Sanh etS)
        {
            if (db.SanhDatTiecs.Any(s => s.maS == etS.MaS))
            {
                return false;
            }
            else
            {
                try
                {
                    SanhDatTiec s = new SanhDatTiec
                    {
                        maS = etS.MaS,
                        tenS = etS.TenS,
                        giaSDT = etS.GiaSDT
                    };
                    db.SanhDatTiecs.InsertOnSubmit(s);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        /// <summary>
        /// Xóa sảnh.
        /// </summary>
        /// <param name="maS"></param>
        /// <returns></returns>
        public bool XoaSanh(string maS)
        {
            try
            {
                var xoa = from s in db.SanhDatTiecs
                          where s.maS == maS
                          select s;

                foreach (var x in xoa)
                {
                    db.SanhDatTiecs.DeleteOnSubmit(x);
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
        /// Sửa sảnh.
        /// </summary>
        /// <param name="etS"></param>
        public void SuaSanh(ET_Sanh etS)
        {
            var update = db.SanhDatTiecs.Single(s => s.maS == etS.MaS);

            update.tenS = etS.TenS;
            update.giaSDT = etS.GiaSDT;

            db.SubmitChanges();
        }
    }
}
