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
    public partial class DatPhong: Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn thoát.
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

        private void btnSDDV_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Đi tới màn hình sử dụng dịch vụ ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new SuDungDichVu());
            }
        }
    }
}
