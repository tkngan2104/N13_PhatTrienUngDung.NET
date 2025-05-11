using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DatTiec
    {
        private string maNS, maDT, maKH, maS, ghiChu;

        private DateTime ngayDT, ngayBatDau, ngayKetThuc;

        private float tongTien, giaTriDC;

        public ET_DatTiec(string maNS, string maDT, string maKH, string maS, string ghiChu, DateTime ngayDT, DateTime ngayBatDau, DateTime ngayKetThuc, float tongTien, float giaTriDC)
        {
            this.maNS = maNS;
            this.maDT = maDT;
            this.maKH = maKH;
            this.maS = maS;
            this.ghiChu = ghiChu;
            this.ngayDT = ngayDT;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.tongTien = tongTien;
            this.giaTriDC = giaTriDC;
        }

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaDT { get => maDT; set => maDT = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaS { get => maS; set => maS = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgayDT { get => ngayDT; set => ngayDT = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float GiaTriDC { get => giaTriDC; set => giaTriDC = value; }
    }
}
