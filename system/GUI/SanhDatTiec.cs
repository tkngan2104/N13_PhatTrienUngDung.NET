using BUS;
using ET;
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
    public partial class SanhDatTiec: Form
    {
        public SanhDatTiec()
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

        private void SanhDatTiec_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            BUS_Sanh.Instance.DSSanh(dgvDSSanhDT);
            txtMaSanh.Text = BUS_Sanh.Instance.TaoMaTuDong();
        }

        private void dgvDSSanhDT_Click(object sender, EventArgs e)
        {
            int dong = dgvDSSanhDT.CurrentCell.RowIndex;
            txtMaSanh.Text = dgvDSSanhDT.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenSanh.Text = dgvDSSanhDT.Rows[dong].Cells[1].Value?.ToString() ?? "";
            txtGiaTien.Text = dgvDSSanhDT.Rows[dong].Cells[2].Value?.ToString() ?? "";

            btnSua.Enabled = true;
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSSanhDT.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtTenSanh.Text.Length == 0 || txtGiaTien.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Thêm sảnh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_Sanh.Instance.ThemSanh(new ET_Sanh(txtMaSanh.Text, txtTenSanh.Text, float.Parse(txtGiaTien.Text)));
                    BUS_Sanh.Instance.DSSanh(dgvDSSanhDT);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa sảnh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSSanhDT.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa chọn !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_Sanh.Instance.XoaSanh(dgvDSSanhDT);
                    BUS_Sanh.Instance.DSSanh(dgvDSSanhDT);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSSanhDT.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaSanh.Text) == true)
                        {
                            BUS_Sanh.Instance.SuaSanh(new ET_Sanh(txtMaSanh.Text, txtTenSanh.Text, float.Parse(txtGiaTien.Text)));
                            BUS_Sanh.Instance.DSSanh(dgvDSSanhDT);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDSSanhDT.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaSanh.Text = dgvDSSanhDT.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Làm mới dữ liệu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSanh.Text = BUS_Sanh.Instance.TaoMaTuDong();
            txtTenSanh.Clear();
            txtGiaTien.Clear();

            btnSua.Enabled = false;
        }
    }
}
