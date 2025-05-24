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
    public partial class SuDungDichVu: Form
    {
        public SuDungDichVu()
        {
            InitializeComponent();
        }

        private BUS_SuDungDichVu sddv = new BUS_SuDungDichVu();
        private BUS_DichVu dv = new BUS_DichVu();
        private BUS_ChiTietDatPhong ctdp = new BUS_ChiTietDatPhong();
        private BUS_ThongKeSuDungDichVu tksddv = new BUS_ThongKeSuDungDichVu();

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

        /// <summary>
        /// Tìm phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenLH = txtTimPhong.Text.Trim();
            var ds = ctdp.TimTheoTenLoaiHinh(tenLH);
            dgvKetQuaTimKiem.DataSource = ds;
            dgvKetQuaTimKiem.Columns[4].Visible = false;
            dgvKetQuaTimKiem.Columns[5].Visible = false;
            //MessageBox.Show(ds + "TimTheoTenLoaiHinh");
        }

        private void dgvKetQuaTimKiem_Click(object sender, EventArgs e)
        {
            int dong = dgvKetQuaTimKiem.CurrentCell.RowIndex;
            txtCTDP.Text = dgvKetQuaTimKiem.Rows[dong].Cells[1].Value?.ToString() ?? "";

            try
            {
                string maCTDP = dgvKetQuaTimKiem.Rows[dong].Cells[1].Value?.ToString() ?? "";
                sddv.DSSDDV(dgvDSDichVu, maCTDP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách dịch vụ: " + ex.Message);
            }
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            txtMaSDDV.Text = sddv.TaoMaTuDong();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            List<string> dsTenDV = dv.LayTatCaTenDichVu();
            collection.AddRange(dsTenDV.ToArray());

            txtDichVu.AutoCompleteCustomSource = collection;
            txtDichVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDichVu.AutoCompleteSource = AutoCompleteSource.CustomSource;

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void TinhThanhTien()
        {
            string tenDV = txtDichVu.Text.Trim();
            int soLuong = (int)numSL.Value;

            int giaTien = dv.LayGiaDichVuTheoTen(tenDV);

            int thanhTien = soLuong * giaTien;

            txtThanhTien.Text = thanhTien.ToString();
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtDichVu_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void dgvDSDichVu_Click(object sender, EventArgs e)
        {
            int dong = dgvDSDichVu.CurrentCell.RowIndex;
            txtMaSDDV.Text = dgvDSDichVu.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtDichVu.Text = dgvDSDichVu.Rows[dong].Cells[1].Value?.ToString() ?? "";
            txtCTDP.Text = dgvDSDichVu.Rows[dong].Cells[2].Value?.ToString() ?? "";
            numSL.Text = dgvDSDichVu.Rows[dong].Cells[3].Value?.ToString() ?? "";
            txtThanhTien.Text = dgvDSDichVu.Rows[dong].Cells[4].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSDichVu.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtCTDP.Text.Length == 0 || txtDichVu.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Thêm sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong())
                {
                    string tenDV = txtDichVu.Text.Trim();
                    ET_SuDungDichVu etSDDV = new ET_SuDungDichVu(
                        txtMaSDDV.Text,
                        tenDV,
                        txtCTDP.Text,
                        (int)numSL.Value,
                        float.Parse(txtThanhTien.Text)
                    );

                    // Gọi BUS để thêm dịch vụ
                    sddv.ThemSDDV(etSDDV);
                    sddv.DSSDDV(dgvDSDichVu, txtCTDP.Text);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDichVu.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa chọn !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    sddv.XoaSDDV(dgvDSDichVu);
                    sddv.DSSDDV(dgvDSDichVu, txtCTDP.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if (KTraMa(txtMaSDDV.Text) == true)
                    {
                        sddv.SuaSDDV(new ET_SuDungDichVu(
                            txtMaSDDV.Text,
                            txtDichVu.Text,
                            txtCTDP.Text,
                            (int)numSL.Value,
                            float.Parse(txtThanhTien.Text)
                        ));
                        sddv.DSSDDV(dgvDSDichVu, txtCTDP.Text);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng không sửa mã " + dgvDSDichVu.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSDDV.Text = dgvDSDichVu.CurrentRow.Cells[0].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kỳ trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Làm mới dữ liệu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSDDV.Text = sddv.TaoMaTuDong();
            txtDichVu.Clear();
            numSL.Value = numSL.Minimum;
            txtThanhTien.Clear();

            dgvDSDichVu.ClearSelection();

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Tìm sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimSDDV_Click(object sender, EventArgs e)
        {
            if (radThang.Checked == true)
            {
                dgvDSSDDV_TK.DataSource = tksddv.ThongKeDichVuTheoThang(dtpThoiGian.Value.Month, dtpThoiGian.Value.Year);
            }
            else if (radNam.Checked == true)
            {
                dgvDSSDDV_TK.DataSource = tksddv.ThongKeDichVuTheoNam(dtpThoiGian.Value.Year);
            }
        }


        /// <summary>
        /// In sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radThang.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeSuDungDichVuTheoThang(dtpThoiGian.Value));
            }
            else if (radNam.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeSuDungDichVuTheoNam(dtpThoiGian.Value));
            }
        }

    }
}
