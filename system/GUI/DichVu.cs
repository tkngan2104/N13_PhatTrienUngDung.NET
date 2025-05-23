﻿using BUS;
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
            txtMaDV.Text = bus.taoMaDV();
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

        /// <summary>
        /// Thêm dịch vụ vào danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDV.Text) || string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập dịch vụ cần thêm!");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm dịch vụ mới?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                ET_DichVu dv = new ET_DichVu
                {
                    MaDV = bus.taoMaDV(),
                    TenDV = txtTenDV.Text.Trim(),
                    GiaTien = int.Parse(txtGiaTien.Text.Trim())
                };

                if (bus.themDichVu(dv))
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    layDSSV();
                    LamMoi();
                }
                else
                    MessageBox.Show("Thêm thất bại. Kiểm tra lại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// xoá dịch vụ khỏi danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string maDV = txtMaDV.Text.Trim();

                if (bus.xoaDichVu(maDV))
                {
                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo");
                    layDSSV(); 
                    LamMoi(); 
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// sửa dịch vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật dịch vụ này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            ET_DichVu dv = new ET_DichVu
            {
                MaDV = txtMaDV.Text,
                TenDV = txtTenDV.Text.Trim(),
                GiaTien = int.TryParse(txtGiaTien.Text, out int gia) ? gia : 0
            };

            if (bus.suaDichVu(dv))
            {
                MessageBox.Show("Cập nhật thành công!");
                layDSSV();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        /// <summary>
        /// làm mới
        /// </summary>
        private void LamMoi()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaTien.Clear();
            txtMaDV.Text = bus.taoMaDV();
        }


        /// <summary>
        /// click hiển thị dữ liệu lên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDSDV_Click(object sender, EventArgs e)
        {
            if (dgvDSDV.CurrentRow != null)
            {
                int i = dgvDSDV.CurrentRow.Index;
                txtMaDV.Text = dgvDSDV.Rows[i].Cells[0].Value?.ToString();
                txtTenDV.Text = dgvDSDV.Rows[i].Cells[1].Value?.ToString();
                txtGiaTien.Text = dgvDSDV.Rows[i].Cells[2].Value?.ToString();
            }
        }
        /// <summary>
        /// làm mới textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        /// <summary>
        /// kiểm tra rỗng
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="tenTruong"></param>
        private void KiemTraRong(TextBox txt, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, $"{tenTruong} không được để trống");
            }
            else
            {
                errorProvider1.SetError(txt, ""); // Xóa lỗi nếu hợp lệ
            }
        }



        private void txtTenDV_Leave(object sender, EventArgs e)
        {
            KiemTraRong(txtTenDV, "Tên dịch vụ");
            this.Focus();
        }

        private void txtGiaTien_Leave(object sender, EventArgs e)
        {
            KiemTraRong(txtGiaTien, "Giá tiền");
            this.Focus();
        }
    }
}
