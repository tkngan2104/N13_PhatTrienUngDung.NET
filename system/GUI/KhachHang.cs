using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class KhachHang: Form
    {
        BUS_KhachHang bus = new BUS_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load danh sách khách hàng lên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KhachHang_Load(object sender, EventArgs e)
        {
            layDSKH();
        }
        //Lấy danh sách khách hàng
        public void layDSKH()
        {
            dgvDSKH.DataSource = bus.layDSKH();
        }



        /// <summary>
        /// Btn thoát.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn đang thoát màn hình ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
