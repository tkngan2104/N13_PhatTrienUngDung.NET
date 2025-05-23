namespace GUI
{
    partial class DatPhong
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
            this.lblNgayDatPhong = new System.Windows.Forms.Label();
            this.txtDatPhong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenLH = new System.Windows.Forms.ComboBox();
            this.cboLoaiHinh = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.txtMaCTDP = new System.Windows.Forms.TextBox();
            this.lblMaCTDP = new System.Windows.Forms.Label();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.dtpNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblDatPhong = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSDDV = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDichVu
            // 
            this.dgvDSDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDichVu.Location = new System.Drawing.Point(2, 21);
            this.dgvDSDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSDichVu.Name = "dgvDSDichVu";
            this.dgvDSDichVu.RowHeadersWidth = 62;
            this.dgvDSDichVu.RowTemplate.Height = 28;
            this.dgvDSDichVu.Size = new System.Drawing.Size(934, 264);
            this.dgvDSDichVu.TabIndex = 0;
            this.dgvDSDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDichVu_CellClick);
            this.dgvDSDichVu.Click += new System.EventHandler(this.dgvDSDichVu_Click);
            // 
            // lblNgayDatPhong
            // 
            this.lblNgayDatPhong.AutoSize = true;
            this.lblNgayDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDatPhong.Location = new System.Drawing.Point(241, 159);
            this.lblNgayDatPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayDatPhong.Name = "lblNgayDatPhong";
            this.lblNgayDatPhong.Size = new System.Drawing.Size(111, 18);
            this.lblNgayDatPhong.TabIndex = 8;
            this.lblNgayDatPhong.Text = "Ngày đặt phòng";
            // 
            // txtDatPhong
            // 
            this.txtDatPhong.Enabled = false;
            this.txtDatPhong.Location = new System.Drawing.Point(244, 60);
            this.txtDatPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatPhong.Name = "txtDatPhong";
            this.txtDatPhong.Size = new System.Drawing.Size(203, 26);
            this.txtDatPhong.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenLH);
            this.groupBox1.Controls.Add(this.cboLoaiHinh);
            this.groupBox1.Controls.Add(this.lblLoaiPhong);
            this.groupBox1.Controls.Add(this.txtMaCTDP);
            this.groupBox1.Controls.Add(this.lblMaCTDP);
            this.groupBox1.Controls.Add(this.dtpNgayTraPhong);
            this.groupBox1.Controls.Add(this.lblNgayTraPhong);
            this.groupBox1.Controls.Add(this.dtpNgayDatPhong);
            this.groupBox1.Controls.Add(this.lblNgayDatPhong);
            this.groupBox1.Controls.Add(this.txtDatPhong);
            this.groupBox1.Controls.Add(this.lblMaDP);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(462, 296);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // cboTenLH
            // 
            this.cboTenLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenLH.FormattingEnabled = true;
            this.cboTenLH.Location = new System.Drawing.Point(15, 156);
            this.cboTenLH.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenLH.Name = "cboTenLH";
            this.cboTenLH.Size = new System.Drawing.Size(203, 28);
            this.cboTenLH.TabIndex = 46;
            // 
            // cboLoaiHinh
            // 
            this.cboLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHinh.FormattingEnabled = true;
            this.cboLoaiHinh.Location = new System.Drawing.Point(15, 116);
            this.cboLoaiHinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiHinh.Name = "cboLoaiHinh";
            this.cboLoaiHinh.Size = new System.Drawing.Size(203, 28);
            this.cboLoaiHinh.TabIndex = 45;
            this.cboLoaiHinh.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHinh_SelectedIndexChanged);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(12, 99);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(67, 18);
            this.lblLoaiPhong.TabIndex = 44;
            this.lblLoaiPhong.Text = "Loại hình";
            // 
            // txtMaCTDP
            // 
            this.txtMaCTDP.Enabled = false;
            this.txtMaCTDP.Location = new System.Drawing.Point(244, 118);
            this.txtMaCTDP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCTDP.Name = "txtMaCTDP";
            this.txtMaCTDP.Size = new System.Drawing.Size(203, 26);
            this.txtMaCTDP.TabIndex = 42;
            // 
            // lblMaCTDP
            // 
            this.lblMaCTDP.AutoSize = true;
            this.lblMaCTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTDP.Location = new System.Drawing.Point(241, 99);
            this.lblMaCTDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCTDP.Name = "lblMaCTDP";
            this.lblMaCTDP.Size = new System.Drawing.Size(144, 18);
            this.lblMaCTDP.TabIndex = 41;
            this.lblMaCTDP.Text = "Mã chi tiết đặt phòng";
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(244, 239);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(203, 26);
            this.dtpNgayTraPhong.TabIndex = 40;
            this.dtpNgayTraPhong.ValueChanged += new System.EventHandler(this.dtpNgayTraPhong_ValueChanged);
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraPhong.Location = new System.Drawing.Point(241, 218);
            this.lblNgayTraPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(108, 18);
            this.lblNgayTraPhong.TabIndex = 39;
            this.lblNgayTraPhong.Text = "Ngày trả phòng";
            // 
            // dtpNgayDatPhong
            // 
            this.dtpNgayDatPhong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatPhong.Location = new System.Drawing.Point(244, 179);
            this.dtpNgayDatPhong.Name = "dtpNgayDatPhong";
            this.dtpNgayDatPhong.Size = new System.Drawing.Size(203, 26);
            this.dtpNgayDatPhong.TabIndex = 32;
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDP.Location = new System.Drawing.Point(241, 41);
            this.lblMaDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(98, 18);
            this.lblMaDP.TabIndex = 2;
            this.lblMaDP.Text = "Mã đặt phòng";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(15, 60);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(203, 26);
            this.txtMaNS.TabIndex = 1;
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNS.Location = new System.Drawing.Point(12, 41);
            this.lblMaNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(85, 18);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(15, 61);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(177, 26);
            this.txtCCCD.TabIndex = 5;
            this.txtCCCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCCD_KeyDown);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(12, 42);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(137, 18);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "Căn cước công dân";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhong.Location = new System.Drawing.Point(2, 21);
            this.dgvDSPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.RowHeadersWidth = 62;
            this.dgvDSPhong.RowTemplate.Height = 28;
            this.dgvDSPhong.Size = new System.Drawing.Size(449, 273);
            this.dgvDSPhong.TabIndex = 0;
            this.dgvDSPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellClick);
            this.dgvDSPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellContentClick);
            this.dgvDSPhong.Click += new System.EventHandler(this.dgvDSPhong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(506, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(453, 296);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtSDTKH);
            this.groupBox2.Controls.Add(this.lblCCCD);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(462, 166);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(244, 61);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(177, 26);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Enabled = false;
            this.txtSDTKH.Location = new System.Drawing.Point(244, 107);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(177, 26);
            this.txtSDTKH.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(15, 107);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(177, 26);
            this.txtTenKH.TabIndex = 10;
            // 
            // lblDatPhong
            // 
            this.lblDatPhong.AutoSize = true;
            this.lblDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatPhong.Location = new System.Drawing.Point(383, 12);
            this.lblDatPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatPhong.Name = "lblDatPhong";
            this.lblDatPhong.Size = new System.Drawing.Size(229, 39);
            this.lblDatPhong.TabIndex = 1;
            this.lblDatPhong.Text = "ĐẶT PHÒNG";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSDichVu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 655);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(938, 287);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phòng đã đặt";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblDatPhong);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(982, 65);
            this.pnlTieuDe.TabIndex = 38;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(164, 127);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(273, 27);
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
            this.btnLamMoi.Location = new System.Drawing.Point(164, 32);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(127, 27);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.White;
            this.btnThemPhong.Location = new System.Drawing.Point(19, 32);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(127, 27);
            this.btnThemPhong.TabIndex = 22;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSDDV);
            this.groupBox6.Controls.Add(this.btnDatPhong);
            this.groupBox6.Controls.Add(this.btnThoat);
            this.groupBox6.Controls.Add(this.btnSuaPhong);
            this.groupBox6.Controls.Add(this.btnLamMoi);
            this.groupBox6.Controls.Add(this.btnXoaPhong);
            this.groupBox6.Controls.Add(this.btnThemPhong);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(506, 402);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(453, 166);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnSDDV
            // 
            this.btnSDDV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSDDV.FlatAppearance.BorderSize = 0;
            this.btnSDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDDV.ForeColor = System.Drawing.Color.Black;
            this.btnSDDV.Location = new System.Drawing.Point(164, 80);
            this.btnSDDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSDDV.Name = "btnSDDV";
            this.btnSDDV.Size = new System.Drawing.Size(273, 27);
            this.btnSDDV.TabIndex = 28;
            this.btnSDDV.Text = "Sử dụng dịch vụ";
            this.btnSDDV.UseVisualStyleBackColor = false;
            this.btnSDDV.Click += new System.EventHandler(this.btnSDDV_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(310, 32);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(127, 27);
            this.btnDatPhong.TabIndex = 27;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhong.Location = new System.Drawing.Point(19, 127);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(127, 27);
            this.btnSuaPhong.TabIndex = 24;
            this.btnSuaPhong.Text = "Sửa phòng";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhong.Location = new System.Drawing.Point(19, 80);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(127, 27);
            this.btnXoaPhong.TabIndex = 23;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(721, 630);
            this.radNam.Margin = new System.Windows.Forms.Padding(2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 22);
            this.radNam.TabIndex = 66;
            this.radNam.TabStop = true;
            this.radNam.Text = "Năm";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThang.Location = new System.Drawing.Point(612, 630);
            this.radThang.Margin = new System.Windows.Forms.Padding(2);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(67, 22);
            this.radThang.TabIndex = 65;
            this.radThang.TabStop = true;
            this.radThang.Text = "Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.Location = new System.Drawing.Point(506, 628);
            this.radNgay.Margin = new System.Windows.Forms.Padding(2);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(63, 24);
            this.radNgay.TabIndex = 64;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGian.Location = new System.Drawing.Point(506, 584);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(273, 26);
            this.dtpThoiGian.TabIndex = 63;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(882, 582);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(77, 27);
            this.btnIn.TabIndex = 62;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Tan;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(794, 582);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(77, 27);
            this.btnTim.TabIndex = 61;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 788);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radThang);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDichVu;
        private System.Windows.Forms.Label lblNgayDatPhong;
        private System.Windows.Forms.TextBox txtDatPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDatPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker dtpNgayDatPhong;
        private System.Windows.Forms.TextBox txtMaCTDP;
        private System.Windows.Forms.Label lblMaCTDP;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnSDDV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ComboBox cboTenLH;
        private System.Windows.Forms.ComboBox cboLoaiHinh;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTim;
    }
}