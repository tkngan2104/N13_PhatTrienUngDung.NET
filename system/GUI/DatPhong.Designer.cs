﻿namespace GUI
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
            this.dgvDSDatPhong = new System.Windows.Forms.DataGridView();
            this.lblNgayDatPhong = new System.Windows.Forms.Label();
            this.txtDatPhong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.txtMaCTDP = new System.Windows.Forms.TextBox();
            this.lblMaCTDP = new System.Windows.Forms.Label();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.cboLoaiHinh = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.dtpNgayDatPhong = new System.Windows.Forms.DateTimePicker();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDatPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDatPhong
            // 
            this.dgvDSDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDatPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDatPhong.Location = new System.Drawing.Point(3, 31);
            this.dgvDSDatPhong.Name = "dgvDSDatPhong";
            this.dgvDSDatPhong.RowHeadersWidth = 62;
            this.dgvDSDatPhong.RowTemplate.Height = 28;
            this.dgvDSDatPhong.Size = new System.Drawing.Size(1413, 408);
            this.dgvDSDatPhong.TabIndex = 0;
            this.dgvDSDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDatPhong_CellContentClick);
            // 
            // lblNgayDatPhong
            // 
            this.lblNgayDatPhong.AutoSize = true;
            this.lblNgayDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDatPhong.Location = new System.Drawing.Point(362, 245);
            this.lblNgayDatPhong.Name = "lblNgayDatPhong";
            this.lblNgayDatPhong.Size = new System.Drawing.Size(165, 26);
            this.lblNgayDatPhong.TabIndex = 8;
            this.lblNgayDatPhong.Text = "Ngày đặt phòng";
            // 
            // txtDatPhong
            // 
            this.txtDatPhong.Enabled = false;
            this.txtDatPhong.Location = new System.Drawing.Point(366, 92);
            this.txtDatPhong.Name = "txtDatPhong";
            this.txtDatPhong.Size = new System.Drawing.Size(302, 35);
            this.txtDatPhong.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaPhong);
            this.groupBox1.Controls.Add(this.txtMaCTDP);
            this.groupBox1.Controls.Add(this.lblMaCTDP);
            this.groupBox1.Controls.Add(this.dtpNgayTraPhong);
            this.groupBox1.Controls.Add(this.lblNgayTraPhong);
            this.groupBox1.Controls.Add(this.cboLoaiHinh);
            this.groupBox1.Controls.Add(this.lblLoaiPhong);
            this.groupBox1.Controls.Add(this.dtpNgayDatPhong);
            this.groupBox1.Controls.Add(this.lblNgayDatPhong);
            this.groupBox1.Controls.Add(this.txtDatPhong);
            this.groupBox1.Controls.Add(this.lblMaDP);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 436);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(22, 240);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(302, 37);
            this.cboMaPhong.TabIndex = 43;
            // 
            // txtMaCTDP
            // 
            this.txtMaCTDP.Enabled = false;
            this.txtMaCTDP.Location = new System.Drawing.Point(366, 182);
            this.txtMaCTDP.Name = "txtMaCTDP";
            this.txtMaCTDP.Size = new System.Drawing.Size(302, 35);
            this.txtMaCTDP.TabIndex = 42;
            // 
            // lblMaCTDP
            // 
            this.lblMaCTDP.AutoSize = true;
            this.lblMaCTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTDP.Location = new System.Drawing.Point(362, 152);
            this.lblMaCTDP.Name = "lblMaCTDP";
            this.lblMaCTDP.Size = new System.Drawing.Size(213, 26);
            this.lblMaCTDP.TabIndex = 41;
            this.lblMaCTDP.Text = "Mã chi tiết đặt phòng";
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(366, 368);
            this.dtpNgayTraPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(302, 35);
            this.dtpNgayTraPhong.TabIndex = 40;
            this.dtpNgayTraPhong.ValueChanged += new System.EventHandler(this.dtpNgayTraPhong_ValueChanged);
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraPhong.Location = new System.Drawing.Point(362, 335);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(160, 26);
            this.lblNgayTraPhong.TabIndex = 39;
            this.lblNgayTraPhong.Text = "Ngày trả phòng";
            // 
            // cboLoaiHinh
            // 
            this.cboLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHinh.FormattingEnabled = true;
            this.cboLoaiHinh.Location = new System.Drawing.Point(22, 179);
            this.cboLoaiHinh.Name = "cboLoaiHinh";
            this.cboLoaiHinh.Size = new System.Drawing.Size(302, 37);
            this.cboLoaiHinh.TabIndex = 34;
            this.cboLoaiHinh.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHinh_SelectedIndexChanged);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(18, 152);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(100, 26);
            this.lblLoaiPhong.TabIndex = 33;
            this.lblLoaiPhong.Text = "Loại hình";
            // 
            // dtpNgayDatPhong
            // 
            this.dtpNgayDatPhong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatPhong.Location = new System.Drawing.Point(366, 275);
            this.dtpNgayDatPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDatPhong.Name = "dtpNgayDatPhong";
            this.dtpNgayDatPhong.Size = new System.Drawing.Size(302, 35);
            this.dtpNgayDatPhong.TabIndex = 32;
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDP.Location = new System.Drawing.Point(362, 63);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(144, 26);
            this.lblMaDP.TabIndex = 2;
            this.lblMaDP.Text = "Mã đặt phòng";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(22, 92);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(302, 35);
            this.txtMaNS.TabIndex = 1;
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNS.Location = new System.Drawing.Point(18, 63);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(125, 26);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(22, 94);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(264, 35);
            this.txtCCCD.TabIndex = 5;
            this.txtCCCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCCD_KeyDown);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(18, 65);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(199, 26);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "Căn cước công dân";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 747);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1419, 297);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhong.Location = new System.Drawing.Point(3, 31);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.RowHeadersWidth = 62;
            this.dgvDSPhong.RowTemplate.Height = 28;
            this.dgvDSPhong.Size = new System.Drawing.Size(1413, 263);
            this.dgvDSPhong.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtSDTKH);
            this.groupBox2.Controls.Add(this.lblCCCD);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(746, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 255);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(366, 94);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(264, 35);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Enabled = false;
            this.txtSDTKH.Location = new System.Drawing.Point(366, 165);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(264, 35);
            this.txtSDTKH.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(22, 165);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(264, 35);
            this.txtTenKH.TabIndex = 10;
            // 
            // lblDatPhong
            // 
            this.lblDatPhong.AutoSize = true;
            this.lblDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatPhong.Location = new System.Drawing.Point(574, 18);
            this.lblDatPhong.Name = "lblDatPhong";
            this.lblDatPhong.Size = new System.Drawing.Size(330, 58);
            this.lblDatPhong.TabIndex = 1;
            this.lblDatPhong.Text = "ĐẶT PHÒNG";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSDatPhong);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 1059);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1419, 442);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách đặt phòng";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblDatPhong);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1470, 100);
            this.pnlTieuDe.TabIndex = 38;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(246, 195);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(410, 42);
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
            this.btnLamMoi.Location = new System.Drawing.Point(246, 49);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(190, 42);
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
            this.btnThemPhong.Location = new System.Drawing.Point(28, 49);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(190, 42);
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
            this.groupBox6.Location = new System.Drawing.Point(746, 446);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(693, 255);
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
            this.btnSDDV.Location = new System.Drawing.Point(246, 123);
            this.btnSDDV.Name = "btnSDDV";
            this.btnSDDV.Size = new System.Drawing.Size(410, 42);
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
            this.btnDatPhong.Location = new System.Drawing.Point(465, 49);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(190, 42);
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
            this.btnSuaPhong.Location = new System.Drawing.Point(28, 195);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(190, 42);
            this.btnSuaPhong.TabIndex = 24;
            this.btnSuaPhong.Text = "Sửa phòng";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhong.Location = new System.Drawing.Point(28, 123);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(190, 42);
            this.btnXoaPhong.TabIndex = 23;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1496, 1100);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDatPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDatPhong;
        private System.Windows.Forms.Label lblNgayDatPhong;
        private System.Windows.Forms.TextBox txtDatPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDatPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cboLoaiHinh;
        private System.Windows.Forms.Label lblLoaiPhong;
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
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.DataGridView dgvDSPhong;
    }
}