namespace GUI
{
    partial class ThanhToanDatPhong
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
            this.dgvDSDichVu = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtHDDP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChiTietDP = new System.Windows.Forms.TextBox();
            this.lblMaCTDP = new System.Windows.Forms.Label();
            this.lblMaHDDP = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTTDatPhong = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDichVu
            // 
            this.dgvDSDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDichVu.Location = new System.Drawing.Point(3, 31);
            this.dgvDSDichVu.Name = "dgvDSDichVu";
            this.dgvDSDichVu.RowHeadersWidth = 62;
            this.dgvDSDichVu.RowTemplate.Height = 28;
            this.dgvDSDichVu.Size = new System.Drawing.Size(1401, 408);
            this.dgvDSDichVu.TabIndex = 0;
            this.dgvDSDichVu.Click += new System.EventHandler(this.dgvDSDichVu_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Tan;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(1322, 163);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 42);
            this.btnTim.TabIndex = 44;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(788, 168);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(160, 29);
            this.lblSoDienThoai.TabIndex = 43;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(999, 163);
            this.txtTimKH.Multiline = true;
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(307, 42);
            this.txtTimKH.TabIndex = 42;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(56, 378);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(302, 35);
            this.txtThanhTien.TabIndex = 9;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(51, 349);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(113, 26);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtHDDP
            // 
            this.txtHDDP.Enabled = false;
            this.txtHDDP.Location = new System.Drawing.Point(56, 182);
            this.txtHDDP.Name = "txtHDDP";
            this.txtHDDP.Size = new System.Drawing.Size(302, 35);
            this.txtHDDP.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.txtChiTietDP);
            this.groupBox1.Controls.Add(this.lblMaCTDP);
            this.groupBox1.Controls.Add(this.txtHDDP);
            this.groupBox1.Controls.Add(this.lblMaHDDP);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 458);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // txtChiTietDP
            // 
            this.txtChiTietDP.Enabled = false;
            this.txtChiTietDP.Location = new System.Drawing.Point(56, 282);
            this.txtChiTietDP.Name = "txtChiTietDP";
            this.txtChiTietDP.Size = new System.Drawing.Size(302, 35);
            this.txtChiTietDP.TabIndex = 5;
            // 
            // lblMaCTDP
            // 
            this.lblMaCTDP.AutoSize = true;
            this.lblMaCTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTDP.Location = new System.Drawing.Point(51, 252);
            this.lblMaCTDP.Name = "lblMaCTDP";
            this.lblMaCTDP.Size = new System.Drawing.Size(213, 26);
            this.lblMaCTDP.TabIndex = 4;
            this.lblMaCTDP.Text = "Mã chi tiết đặt phòng";
            // 
            // lblMaHDDP
            // 
            this.lblMaHDDP.AutoSize = true;
            this.lblMaHDDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDDP.Location = new System.Drawing.Point(51, 152);
            this.lblMaHDDP.Name = "lblMaHDDP";
            this.lblMaHDDP.Size = new System.Drawing.Size(228, 26);
            this.lblMaHDDP.TabIndex = 2;
            this.lblMaHDDP.Text = "Mã hóa đơn đặt phòng";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(56, 88);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(302, 35);
            this.txtMaNS.TabIndex = 1;
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNS.Location = new System.Drawing.Point(51, 58);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(125, 26);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(3, 31);
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.RowHeadersWidth = 62;
            this.dgvKetQuaTimKiem.RowTemplate.Height = 28;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(952, 134);
            this.dgvKetQuaTimKiem.TabIndex = 0;
            this.dgvKetQuaTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellClick);
            this.dgvKetQuaTimKiem.Click += new System.EventHandler(this.dgvKetQuaTimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvKetQuaTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(482, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 168);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(56, 86);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(216, 42);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(484, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 194);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Location = new System.Drawing.Point(680, 86);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(216, 42);
            this.btnInHoaDon.TabIndex = 28;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(370, 86);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(216, 42);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTTDatPhong
            // 
            this.lblTTDatPhong.AutoSize = true;
            this.lblTTDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTDatPhong.Location = new System.Drawing.Point(404, 18);
            this.lblTTDatPhong.Name = "lblTTDatPhong";
            this.lblTTDatPhong.Size = new System.Drawing.Size(678, 58);
            this.lblTTDatPhong.TabIndex = 1;
            this.lblTTDatPhong.Text = "THANH TOÁN ĐẶT PHÒNG";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSDichVu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(33, 631);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1407, 442);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách dịch vụ đã sử dụng tại phòng";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblTTDatPhong);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1496, 100);
            this.pnlTieuDe.TabIndex = 38;
            // 
            // ThanhToanDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1522, 788);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThanhToanDatPhong";
            this.Text = "ThanhToanDatPhong";
            this.Load += new System.EventHandler(this.ThanhToanDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDichVu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtHDDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChiTietDP;
        private System.Windows.Forms.Label lblMaCTDP;
        private System.Windows.Forms.Label lblMaHDDP;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTTDatPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}