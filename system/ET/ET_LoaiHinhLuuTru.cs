using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiHinhLuuTru
    {
        private string maLH, tenLH, loaiHinh, trangThai, ghiChu;
        private int slNguoi;
        private float giaTien;

        // Constructor mặc định (không tham số)
        public ET_LoaiHinhLuuTru() { }

        // Constructor có tham số
        public ET_LoaiHinhLuuTru(string maLH, string tenLH, string loaiHinh, string trangThai, string ghiChu, int slNguoi, float giaTien)
        {
            this.maLH = maLH;
            this.tenLH = tenLH;
            this.loaiHinh = loaiHinh;
            this.trangThai = trangThai;
            this.ghiChu = ghiChu;
            this.slNguoi = slNguoi;
            this.giaTien = giaTien;
        }

        // Các thuộc tính
        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
        public string LoaiHinh { get => loaiHinh; set => loaiHinh = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SlNguoi { get => slNguoi; set => slNguoi = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
    }
}
