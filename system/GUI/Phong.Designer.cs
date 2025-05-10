namespace GUI
{
    partial class Phong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.lblTenLH = new System.Windows.Forms.Label();
            this.txtSLNguoi = new System.Windows.Forms.TextBox();
            this.cboLoaiHinh = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblSLNguoi = new System.Windows.Forms.Label();
            this.lblLoaiHinh = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.lblQLPhong = new System.Windows.Forms.Label();
            this.dgvDSLHLT = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHLT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.lblGhiChu);
            this.groupBox1.Controls.Add(this.txtTenLH);
            this.groupBox1.Controls.Add(this.lblTenLH);
            this.groupBox1.Controls.Add(this.txtSLNguoi);
            this.groupBox1.Controls.Add(this.cboLoaiHinh);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.lblGiaPhong);
            this.groupBox1.Controls.Add(this.lblSLNguoi);
            this.groupBox1.Controls.Add(this.lblLoaiHinh);
            this.groupBox1.Controls.Add(this.txtMaLH);
            this.groupBox1.Controls.Add(this.lblMaLH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1415, 400);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hình lưu trú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1051, 105);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(303, 147);
            this.txtGhiChu.TabIndex = 16;
            this.txtGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGhiChu_KeyPress);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(1046, 76);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(87, 26);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(62, 336);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(303, 35);
            this.txtTenLH.TabIndex = 14;
            this.txtTenLH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLH_KeyPress);
            // 
            // lblTenLH
            // 
            this.lblTenLH.AutoSize = true;
            this.lblTenLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLH.Location = new System.Drawing.Point(57, 307);
            this.lblTenLH.Name = "lblTenLH";
            this.lblTenLH.Size = new System.Drawing.Size(135, 26);
            this.lblTenLH.TabIndex = 13;
            this.lblTenLH.Text = "Tên loại hình";
            // 
            // txtSLNguoi
            // 
            this.txtSLNguoi.Location = new System.Drawing.Point(553, 105);
            this.txtSLNguoi.Name = "txtSLNguoi";
            this.txtSLNguoi.Size = new System.Drawing.Size(303, 35);
            this.txtSLNguoi.TabIndex = 12;
            this.txtSLNguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNguoi_KeyPress);
            this.txtSLNguoi.Validated += new System.EventHandler(this.txtSLNguoi_Validated);
            // 
            // cboLoaiHinh
            // 
            this.cboLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHinh.FormattingEnabled = true;
            this.cboLoaiHinh.Location = new System.Drawing.Point(62, 217);
            this.cboLoaiHinh.Name = "cboLoaiHinh";
            this.cboLoaiHinh.Size = new System.Drawing.Size(303, 37);
            this.cboLoaiHinh.TabIndex = 11;
            this.cboLoaiHinh.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHinh_SelectedIndexChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(553, 336);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(303, 37);
            this.cboTrangThai.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(548, 307);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(108, 26);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(553, 217);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(303, 35);
            this.txtGiaTien.TabIndex = 7;
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaPhong.Location = new System.Drawing.Point(548, 188);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(112, 26);
            this.lblGiaPhong.TabIndex = 6;
            this.lblGiaPhong.Text = "Giá phòng";
            // 
            // lblSLNguoi
            // 
            this.lblSLNguoi.AutoSize = true;
            this.lblSLNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNguoi.Location = new System.Drawing.Point(548, 76);
            this.lblSLNguoi.Name = "lblSLNguoi";
            this.lblSLNguoi.Size = new System.Drawing.Size(157, 26);
            this.lblSLNguoi.TabIndex = 4;
            this.lblSLNguoi.Text = "Số lượng người";
            // 
            // lblLoaiHinh
            // 
            this.lblLoaiHinh.AutoSize = true;
            this.lblLoaiHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHinh.Location = new System.Drawing.Point(57, 188);
            this.lblLoaiHinh.Name = "lblLoaiHinh";
            this.lblLoaiHinh.Size = new System.Drawing.Size(100, 26);
            this.lblLoaiHinh.TabIndex = 2;
            this.lblLoaiHinh.Text = "Loại hình";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Enabled = false;
            this.txtMaLH.Location = new System.Drawing.Point(62, 105);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(303, 35);
            this.txtMaLH.TabIndex = 1;
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLH.Location = new System.Drawing.Point(57, 76);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(135, 26);
            this.lblMaLH.TabIndex = 0;
            this.lblMaLH.Text = "Mã loại hình ";
            // 
            // lblQLPhong
            // 
            this.lblQLPhong.AutoSize = true;
            this.lblQLPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhong.Location = new System.Drawing.Point(371, 19);
            this.lblQLPhong.Name = "lblQLPhong";
            this.lblQLPhong.Size = new System.Drawing.Size(759, 58);
            this.lblQLPhong.TabIndex = 1;
            this.lblQLPhong.Text = "QUẢN LÝ LOẠI HÌNH LƯU TRÚ";
            // 
            // dgvDSLHLT
            // 
            this.dgvDSLHLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLHLT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSLHLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLHLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLHLT.Location = new System.Drawing.Point(3, 31);
            this.dgvDSLHLT.Name = "dgvDSLHLT";
            this.dgvDSLHLT.RowHeadersWidth = 62;
            this.dgvDSLHLT.RowTemplate.Height = 28;
            this.dgvDSLHLT.Size = new System.Drawing.Size(1409, 322);
            this.dgvDSLHLT.TabIndex = 0;
            this.dgvDSLHLT.Click += new System.EventHandler(this.dgvDSLHLT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 558);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1415, 123);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1138, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(216, 42);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(864, 48);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(216, 42);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(598, 48);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(216, 42);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(324, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(216, 42);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(62, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(216, 42);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSLHLT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 755);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1415, 356);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách loại hình lưu trú";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblQLPhong);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1472, 100);
            this.pnlTieuDe.TabIndex = 26;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Tan;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(1322, 707);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 41);
            this.btnTim.TabIndex = 39;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimPhong
            // 
            this.txtTimPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhong.Location = new System.Drawing.Point(1000, 707);
            this.txtTimPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimPhong.Multiline = true;
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(307, 43);
            this.txtTimPhong.TabIndex = 37;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 1077);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHLT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLoaiHinh;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.Label lblQLPhong;
        private System.Windows.Forms.DataGridView dgvDSLHLT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblSLNguoi;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboLoaiHinh;
        private System.Windows.Forms.TextBox txtSLNguoi;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label lblTenLH;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimPhong;
    }
}