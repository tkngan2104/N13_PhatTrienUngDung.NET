namespace GUI
{
    partial class DatTiec
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
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDatDV = new System.Windows.Forms.Button();
            this.btnDatTD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblDatTiec = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSDatTiec = new System.Windows.Forms.DataGridView();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtNgayDatTiec = new System.Windows.Forms.TextBox();
            this.btnSanhDT = new System.Windows.Forms.Button();
            this.txtDatCoc = new System.Windows.Forms.TextBox();
            this.lblDatCoc = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cboSanhDT = new System.Windows.Forms.ComboBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblSanhDT = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayDatTiec = new System.Windows.Forms.Label();
            this.txtDatTiec = new System.Windows.Forms.TextBox();
            this.lblMaDT = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDatTiec)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(465, 49);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(191, 42);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDatDV);
            this.groupBox6.Controls.Add(this.btnDatTD);
            this.groupBox6.Controls.Add(this.btnThoat);
            this.groupBox6.Controls.Add(this.btnSua);
            this.groupBox6.Controls.Add(this.btnLamMoi);
            this.groupBox6.Controls.Add(this.btnXoa);
            this.groupBox6.Controls.Add(this.btnThem);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(745, 418);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(680, 232);
            this.groupBox6.TabIndex = 53;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnDatDV
            // 
            this.btnDatDV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDatDV.FlatAppearance.BorderSize = 0;
            this.btnDatDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatDV.ForeColor = System.Drawing.Color.Black;
            this.btnDatDV.Location = new System.Drawing.Point(465, 109);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(191, 42);
            this.btnDatDV.TabIndex = 30;
            this.btnDatDV.Text = "Đặt dịch vụ";
            this.btnDatDV.UseVisualStyleBackColor = false;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // btnDatTD
            // 
            this.btnDatTD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDatTD.FlatAppearance.BorderSize = 0;
            this.btnDatTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTD.ForeColor = System.Drawing.Color.Black;
            this.btnDatTD.Location = new System.Drawing.Point(246, 109);
            this.btnDatTD.Name = "btnDatTD";
            this.btnDatTD.Size = new System.Drawing.Size(191, 42);
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
            this.btnThoat.Location = new System.Drawing.Point(28, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(628, 42);
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
            this.btnLamMoi.Location = new System.Drawing.Point(28, 109);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(191, 42);
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
            this.btnXoa.Location = new System.Drawing.Point(246, 49);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 42);
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
            this.btnThem.Location = new System.Drawing.Point(28, 49);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 42);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtSDTKH);
            this.groupBox2.Controls.Add(this.lblCCCD);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(745, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 255);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(371, 91);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(264, 35);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Enabled = false;
            this.txtSDTKH.Location = new System.Drawing.Point(371, 162);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(264, 35);
            this.txtSDTKH.TabIndex = 11;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(32, 62);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(199, 26);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "Căn cước công dân";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(37, 162);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(264, 35);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(37, 91);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(264, 35);
            this.txtCCCD.TabIndex = 5;
            this.txtCCCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCCD_KeyDown);
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // lblDatTiec
            // 
            this.lblDatTiec.AutoSize = true;
            this.lblDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatTiec.Location = new System.Drawing.Point(602, 20);
            this.lblDatTiec.Name = "lblDatTiec";
            this.lblDatTiec.Size = new System.Drawing.Size(260, 58);
            this.lblDatTiec.TabIndex = 1;
            this.lblDatTiec.Text = "ĐẶT TIỆC";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSDatTiec);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(32, 751);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1393, 430);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách đặt tiệc";
            // 
            // dgvDSDatTiec
            // 
            this.dgvDSDatTiec.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDatTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDatTiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDatTiec.Location = new System.Drawing.Point(3, 31);
            this.dgvDSDatTiec.Name = "dgvDSDatTiec";
            this.dgvDSDatTiec.RowHeadersWidth = 62;
            this.dgvDSDatTiec.RowTemplate.Height = 28;
            this.dgvDSDatTiec.Size = new System.Drawing.Size(1387, 396);
            this.dgvDSDatTiec.TabIndex = 0;
            this.dgvDSDatTiec.Click += new System.EventHandler(this.dgvDSDatTiec_Click);
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblDatTiec);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1448, 100);
            this.pnlTieuDe.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.lblGhiChu);
            this.groupBox1.Controls.Add(this.txtNgayDatTiec);
            this.groupBox1.Controls.Add(this.btnSanhDT);
            this.groupBox1.Controls.Add(this.txtDatCoc);
            this.groupBox1.Controls.Add(this.lblDatCoc);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.cboSanhDT);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.lblSanhDT);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.lblNgayBatDau);
            this.groupBox1.Controls.Add(this.lblNgayKetThuc);
            this.groupBox1.Controls.Add(this.lblNgayDatTiec);
            this.groupBox1.Controls.Add(this.txtDatTiec);
            this.groupBox1.Controls.Add(this.lblMaDT);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 602);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt tiệc";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(22, 512);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(646, 69);
            this.txtGhiChu.TabIndex = 57;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(17, 481);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(87, 26);
            this.lblGhiChu.TabIndex = 56;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtNgayDatTiec
            // 
            this.txtNgayDatTiec.Enabled = false;
            this.txtNgayDatTiec.Location = new System.Drawing.Point(22, 205);
            this.txtNgayDatTiec.Name = "txtNgayDatTiec";
            this.txtNgayDatTiec.Size = new System.Drawing.Size(303, 35);
            this.txtNgayDatTiec.TabIndex = 55;
            // 
            // btnSanhDT
            // 
            this.btnSanhDT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSanhDT.FlatAppearance.BorderSize = 0;
            this.btnSanhDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanhDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanhDT.Location = new System.Drawing.Point(630, 207);
            this.btnSanhDT.Name = "btnSanhDT";
            this.btnSanhDT.Size = new System.Drawing.Size(38, 37);
            this.btnSanhDT.TabIndex = 54;
            this.btnSanhDT.Text = "...";
            this.btnSanhDT.UseVisualStyleBackColor = false;
            this.btnSanhDT.Click += new System.EventHandler(this.btnSanhDT_Click);
            // 
            // txtDatCoc
            // 
            this.txtDatCoc.Enabled = false;
            this.txtDatCoc.Location = new System.Drawing.Point(365, 409);
            this.txtDatCoc.Name = "txtDatCoc";
            this.txtDatCoc.Size = new System.Drawing.Size(303, 35);
            this.txtDatCoc.TabIndex = 48;
            // 
            // lblDatCoc
            // 
            this.lblDatCoc.AutoSize = true;
            this.lblDatCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatCoc.Location = new System.Drawing.Point(360, 380);
            this.lblDatCoc.Name = "lblDatCoc";
            this.lblDatCoc.Size = new System.Drawing.Size(86, 26);
            this.lblDatCoc.TabIndex = 47;
            this.lblDatCoc.Text = "Đặt cọc";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(365, 303);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(303, 35);
            this.txtTongTien.TabIndex = 46;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(360, 274);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(101, 26);
            this.lblTongTien.TabIndex = 45;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // cboSanhDT
            // 
            this.cboSanhDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanhDT.FormattingEnabled = true;
            this.cboSanhDT.Location = new System.Drawing.Point(365, 205);
            this.cboSanhDT.Name = "cboSanhDT";
            this.cboSanhDT.Size = new System.Drawing.Size(244, 37);
            this.cboSanhDT.TabIndex = 44;
            this.cboSanhDT.SelectedIndexChanged += new System.EventHandler(this.cboSanhDT_SelectedIndexChanged);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(22, 411);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(303, 35);
            this.dtpNgayKetThuc.TabIndex = 43;
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // lblSanhDT
            // 
            this.lblSanhDT.AutoSize = true;
            this.lblSanhDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanhDT.Location = new System.Drawing.Point(360, 174);
            this.lblSanhDT.Name = "lblSanhDT";
            this.lblSanhDT.Size = new System.Drawing.Size(139, 26);
            this.lblSanhDT.TabIndex = 41;
            this.lblSanhDT.Text = "Sảnh đặt tiệc";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(22, 305);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(303, 35);
            this.dtpNgayBatDau.TabIndex = 40;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(17, 274);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(141, 26);
            this.lblNgayBatDau.TabIndex = 39;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(17, 380);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(145, 26);
            this.lblNgayKetThuc.TabIndex = 35;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lblNgayDatTiec
            // 
            this.lblNgayDatTiec.AutoSize = true;
            this.lblNgayDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDatTiec.Location = new System.Drawing.Point(17, 174);
            this.lblNgayDatTiec.Name = "lblNgayDatTiec";
            this.lblNgayDatTiec.Size = new System.Drawing.Size(139, 26);
            this.lblNgayDatTiec.TabIndex = 8;
            this.lblNgayDatTiec.Text = "Ngày đặt tiệc";
            // 
            // txtDatTiec
            // 
            this.txtDatTiec.Enabled = false;
            this.txtDatTiec.Location = new System.Drawing.Point(365, 104);
            this.txtDatTiec.Name = "txtDatTiec";
            this.txtDatTiec.Size = new System.Drawing.Size(303, 35);
            this.txtDatTiec.TabIndex = 3;
            // 
            // lblMaDT
            // 
            this.lblMaDT.AutoSize = true;
            this.lblMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDT.Location = new System.Drawing.Point(360, 75);
            this.lblMaDT.Name = "lblMaDT";
            this.lblMaDT.Size = new System.Drawing.Size(118, 26);
            this.lblMaDT.TabIndex = 2;
            this.lblMaDT.Text = "Mã đặt tiệc";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(22, 104);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(303, 35);
            this.txtMaNS.TabIndex = 1;
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNS.Location = new System.Drawing.Point(17, 75);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(125, 26);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // DatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 1106);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatTiec";
            this.Text = "DatTiec";
            this.Load += new System.EventHandler(this.DatTiec_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDatTiec)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblDatTiec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSDatTiec;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSanhDT;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayDatTiec;
        private System.Windows.Forms.TextBox txtDatTiec;
        private System.Windows.Forms.Label lblMaDT;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.ComboBox cboSanhDT;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label lblDatCoc;
        private System.Windows.Forms.Button btnSanhDT;
        private System.Windows.Forms.Button btnDatTD;
        private System.Windows.Forms.Button btnDatDV;
        private System.Windows.Forms.TextBox txtNgayDatTiec;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
    }
}