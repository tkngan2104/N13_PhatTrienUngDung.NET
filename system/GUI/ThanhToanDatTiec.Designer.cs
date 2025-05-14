namespace GUI
{
    partial class ThanhToanDatTiec
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
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTTDatPhong = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtMaHDDT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.lblMaDT = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.lblMaHDDT = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblTTDatPhong);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1287, 80);
            this.pnlTieuDe.TabIndex = 46;
            // 
            // lblTTDatPhong
            // 
            this.lblTTDatPhong.AutoSize = true;
            this.lblTTDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTDatPhong.Location = new System.Drawing.Point(358, 15);
            this.lblTTDatPhong.Name = "lblTTDatPhong";
            this.lblTTDatPhong.Size = new System.Drawing.Size(513, 48);
            this.lblTTDatPhong.TabIndex = 1;
            this.lblTTDatPhong.Text = "THANH TOÁN ĐẶT TIỆC";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Location = new System.Drawing.Point(604, 69);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(192, 34);
            this.btnInHoaDon.TabIndex = 28;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(330, 69);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(192, 34);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(50, 303);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(270, 30);
            this.txtThanhTien.TabIndex = 9;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(45, 280);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(100, 24);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtMaHDDT
            // 
            this.txtMaHDDT.Enabled = false;
            this.txtMaHDDT.Location = new System.Drawing.Point(50, 146);
            this.txtMaHDDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHDDT.Name = "txtMaHDDT";
            this.txtMaHDDT.Size = new System.Drawing.Size(270, 30);
            this.txtMaHDDT.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(431, 385);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(846, 155);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(49, 69);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(192, 34);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Enabled = false;
            this.txtMaDT.Location = new System.Drawing.Point(50, 225);
            this.txtMaDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(270, 30);
            this.txtMaDT.TabIndex = 5;
            // 
            // lblMaDT
            // 
            this.lblMaDT.AutoSize = true;
            this.lblMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDT.Location = new System.Drawing.Point(45, 202);
            this.lblMaDT.Name = "lblMaDT";
            this.lblMaDT.Size = new System.Drawing.Size(101, 24);
            this.lblMaDT.TabIndex = 4;
            this.lblMaDT.Text = "Mã đặt tiệc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvKetQuaTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(428, 174);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(852, 194);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKetQuaTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(3, 25);
            this.dgvKetQuaTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.RowHeadersWidth = 62;
            this.dgvKetQuaTimKiem.RowTemplate.Height = 28;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(846, 167);
            this.dgvKetQuaTimKiem.TabIndex = 0;
            this.dgvKetQuaTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellClick);
            // 
            // lblMaHDDT
            // 
            this.lblMaHDDT.AutoSize = true;
            this.lblMaHDDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDDT.Location = new System.Drawing.Point(45, 122);
            this.lblMaHDDT.Name = "lblMaHDDT";
            this.lblMaHDDT.Size = new System.Drawing.Size(177, 24);
            this.lblMaHDDT.TabIndex = 2;
            this.lblMaHDDT.Text = "Mã hóa đơn đặt tiệc";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(50, 70);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(270, 30);
            this.txtMaNS.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Tan;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(1174, 130);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 34);
            this.btnTim.TabIndex = 52;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(736, 136);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(126, 25);
            this.lblSoDT.TabIndex = 51;
            this.lblSoDT.Text = "Số điện thoại";
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(888, 130);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKH.Multiline = true;
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(273, 34);
            this.txtTimKH.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.txtMaDT);
            this.groupBox1.Controls.Add(this.lblMaDT);
            this.groupBox1.Controls.Add(this.txtMaHDDT);
            this.groupBox1.Controls.Add(this.lblMaHDDT);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(375, 426);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(50, 379);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(270, 30);
            this.txtTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(45, 356);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(94, 24);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNS.Location = new System.Drawing.Point(45, 46);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(109, 24);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSDV);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(27, 564);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1251, 354);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách dịch vụ đã sử dụng tại tiệc";
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDV.Location = new System.Drawing.Point(3, 25);
            this.dgvDSDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.RowHeadersWidth = 62;
            this.dgvDSDV.RowTemplate.Height = 28;
            this.dgvDSDV.Size = new System.Drawing.Size(1245, 327);
            this.dgvDSDV.TabIndex = 0;
            this.dgvDSDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDV_CellClick);
            // 
            // ThanhToanDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 755);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThanhToanDatTiec";
            this.Text = "ThanhToanDatTiec";
            this.Load += new System.EventHandler(this.ThanhToanDatTiec_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTTDatPhong;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtMaHDDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label lblMaDT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.Label lblMaHDDT;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
    }
}