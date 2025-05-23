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
    public class BUS_LoaiHinhLuuTru
    {
        //Khai báo biến tĩnh.
        private static BUS_LoaiHinhLuuTru instance;
        private DAL_LoaiHinhLuuTru dal_p = new DAL_LoaiHinhLuuTru();

        public static BUS_LoaiHinhLuuTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LoaiHinhLuuTru();
                }
                return instance;
            }
        }

        /// <summary>
        /// Đổ dữ liệu loại hình lưu trú.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSLoaiHinhLuuTruCombobox(ComboBox cbo)
        {
            
            cbo.DataSource = DAL_LoaiHinhLuuTru.Instance.DSLoaiHinhLuuTruCombobox(cbo);
            cbo.DisplayMember = "loaiHinh";
            cbo.ValueMember = "loaiHinh";
        }

        /// <summary>
        /// Đổ dữ liệu trạng thái.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSTrangThaiCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_LoaiHinhLuuTru.Instance.DSTrangThaiCombobox(cbo);
            cbo.DisplayMember = "trangThai";
            cbo.ValueMember = "trangThai";
        }

        /// <summary>
        /// Mã loại hình tự động.
        /// </summary>
        /// <param name="loaiHinh"></param>
        /// <returns></returns>
        public string TaoMaTuDong(string loaiHinh)
        {
            return dal_p.TaoMaTuDong(loaiHinh);
        }

        /// <summary>
        /// Lấy danh sách loại hình lưu trú.
        /// </summary>
        /// <returns></returns>
        public string LayMaLoaiHinh()
        {
            return dal_p.LayMaLoaiHinh();
        }

        /// <summary>
        /// Danh sách loại hình lưu trú.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void DSLoaiHinh(DataGridView dgvDSP, string lh)
        {
            // Gán DataSource cho DataGridView
            dgvDSP.DataSource = dal_p.DSLoaiHinh(lh);
        }

        /// <summary>
        /// Thêm loại hình lưu trú.
        /// </summary>
        /// <param name="etLH"></param>
        public void ThemLoaiHinh(ET_LoaiHinhLuuTru etLH)
        {
            if (dal_p.ThemLoaiHinh(etLH) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa loại hình lưu trú.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void XoaLoaiHinh(DataGridView dgvDSP)
        {
            if (dal_p.XoaLoaiHinh(dgvDSP.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa loại hình lưu trú.
        /// </summary>
        /// <param name="etLH"></param>
        public void SuaLoaiHinh(ET_LoaiHinhLuuTru etLH)
        {
            dal_p.SuaLoaiHinh(etLH);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Tìm kiếm loại hình lưu trú.
        /// </summary>
        /// <param name="tenLH"></param>
        /// <returns></returns>
        public List<sp_TimKiemLoaiHinhLuuTruResult> TimKiemLoaiHinhLuuTru(string tenLH)
        {
            return dal_p.TimKiemLoaiHinhLuuTru(tenLH);
        }

        /// <summary>
        /// Tìm kiếm loại hình lưu trú theo tên.
        /// </summary>
        /// <param name="tenCanTim"></param>
        /// <returns></returns>
        public List<ET_LoaiHinhLuuTru> TimTheoTen(string tenCanTim)
        {
            return dal_p.TimTheoTen(tenCanTim);
        }

        /// <summary>
        /// Lấy thông tin loại hình theo loại hình.
        /// </summary>
        /// <param name="loaiHinh"></param>
        /// <returns></returns>
        public List<ET_LoaiHinhLuuTru> LayLoaiHinhTrongTheoLoai(string loaiHinh)
        {
            return DAL_LoaiHinhLuuTru.Instance.LayLoaiHinhTrongTheoLoai(loaiHinh);
        }

    }
}
