using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_SuDungDichVu
    {
        private static DAL_SuDungDichVu instance;

        public static DAL_SuDungDichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_SuDungDichVu();
                }
                return instance;
            }
        }

        QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Mã sử dụng dịch vụ tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            int countMa = db.SuDungDichVus.Count() + 1;

            //Tạo mã mới.
            string newMa;
            do
            {
                if (countMa < 10)
                {
                    newMa = $"SDDV00{countMa}";
                }
                else
                {
                    newMa = $"SDDV0{countMa}";
                }
                countMa++;
            } while (db.SuDungDichVus.Any(dv => dv.maSDDV == newMa));
            return newMa;
        }

        /// <summary>
        /// Danh sách sử dụng dịch vụ.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSSDDV(string sddv)
        {
            IQueryable a = from dv in db.SuDungDichVus
                                join ctdp in db.ChiTietDatPhongs
                                on dv.maCTDP equals ctdp.maCTDP
                                join dvv in db.DichVus
                                on dv.maDV equals dvv.maDV
                                where dv.maCTDP == sddv
                           select new { dv.maSDDV, dvv.tenDV, dv.maCTDP, dv.soLuong, dv.tongTien };
            return a;
        }

        /// <summary>
        /// Thêm sử dụng dịch vụ.
        /// </summary>
        /// <param name="etSDDV"></param>
        /// <returns></returns>
        public bool ThemSDDV(ET_SuDungDichVu etSDDV)
        {
            // Lấy mã dịch vụ từ tên
            var dichVu = db.DichVus.FirstOrDefault(dv => dv.tenDV == etSDDV.MaDV);
            if (dichVu == null)
            {
                return false; // Nếu không tìm thấy dịch vụ theo tên
            }

            // Tiến hành thêm dịch vụ với mã
            if (db.SuDungDichVus.Any(s => s.maSDDV == etSDDV.MaSDDV))
            {
                return false; // Nếu mã SDVD đã tồn tại
            }
            else
            {
                try
                {
                    SuDungDichVu sddv = new SuDungDichVu
                    {
                        maSDDV = etSDDV.MaSDDV,
                        maDV = dichVu.maDV,
                        maCTDP = etSDDV.MaCTDP,
                        soLuong = etSDDV.SoLuong,
                        tongTien = etSDDV.TongTien
                    };

                    db.SuDungDichVus.InsertOnSubmit(sddv);
                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dịch vụ: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Xóa sử dụng dịch vụ.
        /// </summary>
        /// <param name="maSDDV"></param>
        /// <returns></returns>
        public bool XoaSDDV(string maSDDV)
        {
            try
            {
                var xoa = from s in db.SuDungDichVus
                          where s.maSDDV == maSDDV
                          select s;

                foreach (var x in xoa)
                {
                    db.SuDungDichVus.DeleteOnSubmit(x);
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
        /// Sửa sử dụng dịch vụ.
        /// </summary>
        /// <param name="et"></param>
        public bool SuaSDDV(ET_SuDungDichVu et)
        {
            try
            {
                var update = db.SuDungDichVus.Single(s => s.maSDDV == et.MaSDDV);

                // Lấy mã dịch vụ từ tên dịch vụ
                var dichVu = db.DichVus.FirstOrDefault(dv => dv.tenDV == et.MaDV);
                if (dichVu == null)
                {
                    MessageBox.Show("Dịch vụ không tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                update.maDV = dichVu.maDV;
                update.maCTDP = et.MaCTDP;
                update.soLuong = et.SoLuong;
                update.tongTien = et.TongTien;

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
