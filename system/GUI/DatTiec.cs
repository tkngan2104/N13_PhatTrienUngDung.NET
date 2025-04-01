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
    public partial class DatTiec: Form
    {
        public DatTiec()
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
        /// Btn đặt thực đơn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatTD_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xác nhận đặt thực đơn cho buổi tiệc ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ChiTietDatTiec());
            }
        }

        private void btnDatDV_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xác nhận đặt dịch vụ cho buổi tiệc ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new DatDichVu());
            }
        }

        /// <summary>
        /// BtnSanhDT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSanhDT_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new SanhDatTiec());
        }
    }
}
