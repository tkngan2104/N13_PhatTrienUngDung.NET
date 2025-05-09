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
        //Khai báo biến tĩnh
        private static DAL_DichVu instance;


        public static DAL_DichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_DichVu();
                }
                return instance;
            }
        }

        QLResortDataContext db= new QLResortDataContext();
        public List<ET_DichVu> layDSDV()
        {
            var dv = from el in db.DichVus
                     select new ET_DichVu(el.maDV, el.tenDV, el.giaTien); // Chuyển đổi thành đối tượng ET_DichVu
            return dv.ToList(); // Trả về danh sách
        }
        

        // Thêm dịch vụ
        public bool themDichVu(ET_DichVu et)
        {
            var tonTai = db.DichVus.SingleOrDefault(d => d.maDV == et.MaDV);
            if (tonTai != null) return false;

            DichVu dv = new DichVu
            {
                maDV = et.MaDV,
                tenDV = et.TenDV,
                giaTien = et.GiaTien
            };

            db.DichVus.InsertOnSubmit(dv);
            db.SubmitChanges();
            return true;
        }
        // Tạo mã DV tự động
        public string taoMaTuDong()
        {
            var maCuoi = db.DichVus
                .OrderByDescending(d => d.maDV)
                .Select(d => d.maDV)
                .FirstOrDefault();

            if (maCuoi == null)
                return "DV001";

            int so = int.Parse(maCuoi.Substring(2)) + 1;
            return "DV" + so.ToString("D3");
        }

        // Sửa dịch vụ
        public bool suaDichVu(ET_DichVu et)
        {
            var sua = db.DichVus.SingleOrDefault(d => d.maDV == et.MaDV);
            if (sua == null) return false;

            sua.tenDV = et.TenDV;
            sua.giaTien = et.GiaTien;

            db.SubmitChanges();
            return true;
        }

        // Xoá dịch vụ
        public bool xoaDichVu(string ma)
        {
            var xoa = db.DichVus.SingleOrDefault(d => d.maDV == ma);
            if (xoa == null) return false;

            db.DichVus.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Lấy gợi ý dịch vụ.
        /// </summary>
        /// <returns></returns>
        public List<string> LayTatCaTenDichVu()
        {
            return db.DichVus.Select(dv => dv.tenDV).ToList();
        }

        /// <summary>
        /// Lấy giá dịch vụ theo tên.
        /// </summary>
        /// <param name="tenDV"></param>
        /// <returns></returns>
        public int LayGiaDichVuTheoTen(string tenDV)
        {
            var dv = db.DichVus.FirstOrDefault(d => d.tenDV == tenDV);
            return dv?.giaTien ?? 0;
        }

        /// <summary>
        /// Lấy mã dịch vụ theo tên.
        /// </summary>
        /// <param name="tenDV"></param>
        /// <returns></returns>
        public List<DichVu> LayMaDichVuTheoTen(string tenDV)
        {
            var dv = db.DichVus.Where(d => d.tenDV.Contains(tenDV)).ToList();  // Lọc theo tên dịch vụ
            return dv;
        }
    }
}
