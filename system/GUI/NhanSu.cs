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
    public partial class NhanSu: Form
    {
        public NhanSu()
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
        /// Btn chức vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private Menu mainForm;

        public NhanSu(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new ChucVu());
        }

       
    }
}
