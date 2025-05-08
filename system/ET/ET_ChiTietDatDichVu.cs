using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietDatDichVu
    {
        private string maCTDDV, maDT, maDV, ghiChu;

        private int soLuong;

        public ET_ChiTietDatDichVu(string maCTDDV, string maDT, string maDV, string ghiChu, int soLuong)
        {
            this.maCTDDV = maCTDDV;
            this.maDT = maDT;
            this.maDV = maDV;
            this.ghiChu = ghiChu;
            this.soLuong = soLuong;
        }

        public string MaCTDDV { get => maCTDDV; set => maCTDDV = value; }
        public string MaDT { get => maDT; set => maDT = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
