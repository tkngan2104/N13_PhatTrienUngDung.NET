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
    public class BUS_ChucVu
    {
        //Khai báo biến tĩnh.
        private static BUS_ChucVu instance;
        private DAL_ChucVu dal_nv = new DAL_ChucVu();

        public static BUS_ChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChucVu();
                }
                return instance;
            }
        }

        DAL_ChucVu dal = new DAL_ChucVu();
        public IQueryable loadDSCV()
        {
            return dal.loadDSCV();
        }
        public bool themCV(ET_ChucVu et)
        {
            return dal.themCV(et);
        }
        public bool xoaCV(string ma)
        {
            return dal.xoaCV(ma);
        }
        public bool SuaCV(ET_ChucVu et)
        {
            return dal.suaCV(et);
        }
        public string taoMaCV()
        {
            return dal.taoMaTuDong();
        }

        public void DSChucVuCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_ChucVu.Instance.DSChucVuCombobox(cbo);
            cbo.DisplayMember = "TenChucVu";
            cbo.ValueMember = "MaChucVu";
        }
    }
}
