namespace GUI
{
    partial class ChiTietDatTiec
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSThucDon = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaDT = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDatTD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaCTDT = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblDatThucDon = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMA = new System.Windows.Forms.ComboBox();
            this.cboMaDatTiec = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboComboMA = new System.Windows.Forms.ComboBox();
            this.lblComboMA = new System.Windows.Forms.Label();
            this.lblMonAn = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSThucDon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(29, 446);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1238, 381);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách thực đơn đã đặt";
            // 
            // dgvDSThucDon
            // 
            this.dgvDSThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThucDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSThucDon.Location = new System.Drawing.Point(3, 30);
            this.dgvDSThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSThucDon.Name = "dgvDSThucDon";
            this.dgvDSThucDon.ReadOnly = true;
            this.dgvDSThucDon.RowHeadersWidth = 62;
            this.dgvDSThucDon.RowTemplate.Height = 28;
            this.dgvDSThucDon.Size = new System.Drawing.Size(1232, 349);
            this.dgvDSThucDon.TabIndex = 0;
            this.dgvDSThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSThucDon_CellClick);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(416, 222);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(98, 26);
            this.lblSoLuong.TabIndex = 45;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblMaDT
            // 
            this.lblMaDT.AutoSize = true;
            this.lblMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDT.Location = new System.Drawing.Point(39, 139);
            this.lblMaDT.Name = "lblMaDT";
            this.lblMaDT.Size = new System.Drawing.Size(118, 26);
            this.lblMaDT.TabIndex = 2;
            this.lblMaDT.Text = "Mã đặt tiệc";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDatTD);
            this.groupBox6.Controls.Add(this.btnThoat);
            this.groupBox6.Controls.Add(this.btnSua);
            this.groupBox6.Controls.Add(this.btnLamMoi);
            this.groupBox6.Controls.Add(this.btnXoa);
            this.groupBox6.Controls.Add(this.btnThem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(821, 114);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(444, 311);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnDatTD
            // 
            this.btnDatTD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDatTD.FlatAppearance.BorderSize = 0;
            this.btnDatTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTD.ForeColor = System.Drawing.Color.Black;
            this.btnDatTD.Location = new System.Drawing.Point(44, 233);
            this.btnDatTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatTD.Name = "btnDatTD";
            this.btnDatTD.Size = new System.Drawing.Size(170, 34);
            this.btnDatTD.TabIndex = 29;
            this.btnDatTD.Text = "Đặt thực đơn";
            this.btnDatTD.UseVisualStyleBackColor = false;
            this.btnDatTD.Click += new System.EventHandler(this.btnDatTD_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(237, 233);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 34);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(44, 149);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 34);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(237, 149);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(170, 34);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(237, 60);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 34);
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
            this.btnThem.Location = new System.Drawing.Point(44, 60);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 34);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaCTDT
            // 
            this.lblMaCTDT.AutoSize = true;
            this.lblMaCTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTDT.Location = new System.Drawing.Point(39, 60);
            this.lblMaCTDT.Name = "lblMaCTDT";
            this.lblMaCTDT.Size = new System.Drawing.Size(167, 26);
            this.lblMaCTDT.TabIndex = 0;
            this.lblMaCTDT.Text = "Mã đặt thực đơn";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblDatThucDon);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1310, 80);
            this.pnlTieuDe.TabIndex = 54;
            // 
            // lblDatThucDon
            // 
            this.lblDatThucDon.AutoSize = true;
            this.lblDatThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatThucDon.Location = new System.Drawing.Point(452, 16);
            this.lblDatThucDon.Name = "lblDatThucDon";
            this.lblDatThucDon.Size = new System.Drawing.Size(413, 58);
            this.lblDatThucDon.TabIndex = 1;
            this.lblDatThucDon.Text = "ĐẶT THỰC ĐƠN";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(44, 83);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(270, 35);
            this.txtMaNS.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMA);
            this.groupBox1.Controls.Add(this.cboMaDatTiec);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.cboComboMA);
            this.groupBox1.Controls.Add(this.lblComboMA);
            this.groupBox1.Controls.Add(this.lblMonAn);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblMaDT);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaCTDT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(749, 311);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt tiệc";
            // 
            // cboMA
            // 
            this.cboMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMA.FormattingEnabled = true;
            this.cboMA.Location = new System.Drawing.Point(419, 87);
            this.cboMA.Name = "cboMA";
            this.cboMA.Size = new System.Drawing.Size(270, 37);
            this.cboMA.TabIndex = 82;
            // 
            // cboMaDatTiec
            // 
            this.cboMaDatTiec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDatTiec.FormattingEnabled = true;
            this.cboMaDatTiec.Location = new System.Drawing.Point(43, 161);
            this.cboMaDatTiec.Name = "cboMaDatTiec";
            this.cboMaDatTiec.Size = new System.Drawing.Size(270, 37);
            this.cboMaDatTiec.TabIndex = 81;
            this.cboMaDatTiec.SelectedIndexChanged += new System.EventHandler(this.cboMaDatTiec_SelectedIndexChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(420, 247);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(269, 35);
            this.numSoLuong.TabIndex = 80;
            // 
            // cboComboMA
            // 
            this.cboComboMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComboMA.FormattingEnabled = true;
            this.cboComboMA.Location = new System.Drawing.Point(420, 161);
            this.cboComboMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboComboMA.Name = "cboComboMA";
            this.cboComboMA.Size = new System.Drawing.Size(270, 37);
            this.cboComboMA.TabIndex = 58;
            this.cboComboMA.SelectedIndexChanged += new System.EventHandler(this.cboComboMA_SelectedIndexChanged);
            // 
            // lblComboMA
            // 
            this.lblComboMA.AutoSize = true;
            this.lblComboMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboMA.Location = new System.Drawing.Point(416, 139);
            this.lblComboMA.Name = "lblComboMA";
            this.lblComboMA.Size = new System.Drawing.Size(162, 26);
            this.lblComboMA.TabIndex = 57;
            this.lblComboMA.Text = "Combo món ăn";
            // 
            // lblMonAn
            // 
            this.lblMonAn.AutoSize = true;
            this.lblMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonAn.Location = new System.Drawing.Point(416, 60);
            this.lblMonAn.Name = "lblMonAn";
            this.lblMonAn.Size = new System.Drawing.Size(107, 26);
            this.lblMonAn.TabIndex = 55;
            this.lblMonAn.Text = "Món ăn lẻ";
            // 
            // ChiTietDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 882);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietDatTiec";
            this.Text = "ChiTietDatTiec";
            this.Load += new System.EventHandler(this.ChiTietDatTiec_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSThucDon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaDT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDatTD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaCTDT;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblDatThucDon;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComboMA;
        private System.Windows.Forms.Label lblMonAn;
        private System.Windows.Forms.ComboBox cboComboMA;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cboMaDatTiec;
        private System.Windows.Forms.ComboBox cboMA;
    }
}