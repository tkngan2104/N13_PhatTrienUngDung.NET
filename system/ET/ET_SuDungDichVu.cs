using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_SuDungDichVu
    {
        private string maSDDV, maDV, maCTDP;

        private int soLuong;

        private float tongTien;

        public ET_SuDungDichVu(string maSDDV, string maDV, string maCTDP, int soLuong, float tongTien)
        {
            this.maSDDV = maSDDV;
            this.maDV = maDV;
            this.maCTDP = maCTDP;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }

        public string MaSDDV { get => maSDDV; set => maSDDV = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public string MaCTDP { get => maCTDP; set => maCTDP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
