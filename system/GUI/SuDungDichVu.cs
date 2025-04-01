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
    public partial class SuDungDichVu: Form
    {
        public SuDungDichVu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Btn dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new DichVu());
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
        /// Btn trả phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xác nhận phòng đang được thanh toán ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThanhToanDatPhong());
            }
        }
    }
}
