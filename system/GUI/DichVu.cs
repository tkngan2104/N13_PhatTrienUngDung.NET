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
    public partial class DichVu: Form
    {
        private BUS_DichVu bus = new BUS_DichVu();
        public DichVu()
        {
            InitializeComponent();
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

        /// <summary>
        /// Lấy danh sách dịch vụ
        /// </summary>
        public void layDSSV()
        {
            dgvDSDV.DataSource = bus.layDSSV();
        }

        /// <summary>
        /// Load danh sách dịch vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DichVu_Load(object sender, EventArgs e)
        {
            layDSSV();
        }
    }
}
