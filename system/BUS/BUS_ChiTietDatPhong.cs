using DAL;
using ET;
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

        public void DSChiTietDatPhongTheoMa(DataGridView dgvDSCTDP, string maDP)
        {
            dgvDSCTDP.DataSource = DAL_ChiTietDatPhong.Instance.LayDSChiTietTheoMaDP(maDP);
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

        /// <summary>
        /// Mã chi tiết đặt phòng tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_p.TaoMaTuDong();
        }

        /// <summary>
        /// Danh sách trống.
        /// </summary>
        /// <param name="cbo"></param>
        public void HienThiPhongTrong(ComboBox cbo, string loaihinh)
        {
            cbo.DataSource = DAL_ChiTietDatPhong.Instance.HienThiPhongTrong(loaihinh);
            cbo.DisplayMember = "tenLH";
            cbo.ValueMember = "maLH";
        }

        /// <summary>
        /// Mã tạm.
        /// </summary>
        /// <param name="danhSachTam"></param>
        /// <returns></returns>
        public string TaoMaTam(List<ET_ChiTietDatPhong> danhSachTam)
        {
            string maCuoiDB = dal_p.TaoMaTuDong(); // Lấy mã mới từ DB như cũ
            string prefix = maCuoiDB.Substring(0, 10);
            int soDB = int.Parse(maCuoiDB.Substring(10));

            int soMax = soDB;

            // Kiểm tra mã trong danh sách tạm
            foreach (var item in danhSachTam)
            {
                if (item.MaCTDP.StartsWith(prefix))
                {
                    string soStr = item.MaCTDP.Substring(10);
                    if (int.TryParse(soStr, out int soTam))
                    {
                        if (soTam >= soMax)
                        {
                            soMax = soTam + 1;
                        }
                    }
                }
            }

            string newMa = $"{prefix}{soMax:D3}";

            return newMa;
        }

        /// <summary>
        /// Hiển thị chi tiết thêm phòng.
        /// </summary>
        /// <param name="dgvDSCTDP"></param>
        /// <param name="v"></param>
        public void DSChiTietDatPhong(DataGridView dgvDSCTDP)
        {
            dgvDSCTDP.DataSource = DAL_ChiTietDatPhong.Instance.DSChiTietDatPhong();
        }

        public void DSChiTietDatPhongTheoMa(DataGridView dgvDSCTDP, string maDP)
        {
            dgvDSCTDP.DataSource = DAL_ChiTietDatPhong.Instance.DSChiTietDatPhongTheoMa(maDP);
        }

        /// <summary>
        /// Thêm chi tiết đặt phòng.
        /// </summary>
        /// <param name="etCT"></param>
        public void ThemCTDP(ET_ChiTietDatPhong etCT)
        {
            if (DAL_ChiTietDatPhong.Instance.ThemCTDP(etCT) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật trạng thái phòng theo ngày.
        /// </summary>
        public void CapNhatTrangThaiPhongTheoNgay()
        {
            DAL_ChiTietDatPhong.Instance.CapNhatTrangThaiPhongTheoNgay();
        }

        /// <summary>
        /// Cập nhật trạng thái phòng.
        /// </summary>
        /// <param name="maLH"></param>
        /// <param name="trangThai"></param>
        public void CapNhatTrangThaiPhong(string maLH, string trangThai)
        {
            DAL_ChiTietDatPhong.Instance.CapNhatTrangThaiPhong(maLH, trangThai);
        }

        public List<string> LayTatCaMaCTDP()
        {
            return DAL_ChiTietDatPhong.Instance.LayTatCaMaCTDP();
        }

       
    }
}
