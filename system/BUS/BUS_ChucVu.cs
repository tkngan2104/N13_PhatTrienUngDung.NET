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

        //DAL_ChucVu dal = new DAL_ChucVu();
        public IQueryable loadDSCV()
        {
            return dal_nv.loadDSCV();
        }
        public bool themCV(ET_ChucVu et)
        {
            return dal_nv.themCV(et);
        }
        public bool xoaCV(string ma)
        {
            return dal_nv.xoaCV(ma);
        }
        public bool SuaCV(ET_ChucVu et)
        {
            return dal_nv.suaCV(et);
        }
        public string taoMaCV()
        {
            return dal_nv.taoMaTuDong();
        }

        /// <summary>
        /// Đổ dữ liệu chức vu
        /// </summary>
        /// <param name="cbo"></param>
        public void DSChucVuCombobox(ComboBox cbo)
        {
            cbo.DataSource = dal_nv.DSChucVuCombobox(cbo);
            cbo.DisplayMember = "TenChucVu";
            cbo.ValueMember = "MaChucVu";
        }
    }
}
