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

        private void NhanSu_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            BUS_NhanVien.Instance.DSNhanVien(dgvDSNS);
            txtMaNS.Text = BUS_NhanVien.Instance.TaoMaTuDong();
            BUS_NhanVien.Instance.DSChucVuCombobox(cboChucVu);
        }

        private void dgvDSNS_Click(object sender, EventArgs e)
        {
            int dong = dgvDSNS.CurrentCell.RowIndex;
            txtMaNS.Text = dgvDSNS.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenNS.Text = dgvDSNS.Rows[dong].Cells[1].Value?.ToString() ?? "";

            if (DateTime.TryParse(dgvDSNS.Rows[dong].Cells[2].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgaySinh.MinDate || birthDate > dtpNgaySinh.MaxDate)
                {
                    dtpNgaySinh.Value = DateTime.Today; // Set to current date or any valid date
                }
                else
                {
                    dtpNgaySinh.Value = birthDate; // Only set this if within valid range
                }
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Today; // or any default value if parsing fails
            }

            txtSDT.Text = dgvDSNS.Rows[dong].Cells[3].Value?.ToString() ?? "";
            txtCCCD.Text = dgvDSNS.Rows[dong].Cells[4].Value?.ToString() ?? "";
            txtEmail.Text = dgvDSNS.Rows[dong].Cells[5].Value?.ToString() ?? "";
            txtDiaChi.Text = dgvDSNS.Rows[dong].Cells[6].Value?.ToString() ?? "";
            cboChucVu.Text = dgvDSNS.Rows[dong].Cells[7].Value?.ToString() ?? "";
        }
    }
}
