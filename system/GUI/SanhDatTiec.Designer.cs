﻿namespace GUI
{
    partial class SanhDatTiec
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
            this.lblQLSanhDT = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSSanhDT = new System.Windows.Forms.DataGridView();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.lblTenSanh = new System.Windows.Forms.Label();
            this.txtMaSanh = new System.Windows.Forms.TextBox();
            this.lblMaSanh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTieuDe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanhDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblQLSanhDT);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1472, 100);
            this.pnlTieuDe.TabIndex = 30;
            // 
            // lblQLSanhDT
            // 
            this.lblQLSanhDT.AutoSize = true;
            this.lblQLSanhDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSanhDT.Location = new System.Drawing.Point(427, 23);
            this.lblQLSanhDT.Name = "lblQLSanhDT";
            this.lblQLSanhDT.Size = new System.Drawing.Size(655, 58);
            this.lblQLSanhDT.TabIndex = 1;
            this.lblQLSanhDT.Text = "QUẢN LÝ SẢNH ĐẶT TIỆC";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1122, 48);
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
            this.btnLamMoi.Location = new System.Drawing.Point(857, 48);
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
            this.btnSua.Location = new System.Drawing.Point(590, 48);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1410, 123);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSSanhDT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(483, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 416);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sảnh đặt tiệc";
            // 
            // dgvDSSanhDT
            // 
            this.dgvDSSanhDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanhDT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSanhDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanhDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanhDT.Location = new System.Drawing.Point(3, 31);
            this.dgvDSSanhDT.Name = "dgvDSSanhDT";
            this.dgvDSSanhDT.RowHeadersWidth = 62;
            this.dgvDSSanhDT.RowTemplate.Height = 28;
            this.dgvDSSanhDT.Size = new System.Drawing.Size(952, 382);
            this.dgvDSSanhDT.TabIndex = 0;
            this.dgvDSSanhDT.Click += new System.EventHandler(this.dgvDSSanhDT_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(62, 329);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(303, 35);
            this.txtGiaTien.TabIndex = 5;
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(57, 300);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(87, 26);
            this.lblGiaTien.TabIndex = 4;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(62, 215);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(303, 35);
            this.txtTenSanh.TabIndex = 3;
            this.txtTenSanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSanh_KeyPress);
            // 
            // lblTenSanh
            // 
            this.lblTenSanh.AutoSize = true;
            this.lblTenSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanh.Location = new System.Drawing.Point(57, 186);
            this.lblTenSanh.Name = "lblTenSanh";
            this.lblTenSanh.Size = new System.Drawing.Size(101, 26);
            this.lblTenSanh.TabIndex = 2;
            this.lblTenSanh.Text = "Tên sảnh";
            // 
            // txtMaSanh
            // 
            this.txtMaSanh.Enabled = false;
            this.txtMaSanh.Location = new System.Drawing.Point(62, 103);
            this.txtMaSanh.Name = "txtMaSanh";
            this.txtMaSanh.Size = new System.Drawing.Size(303, 35);
            this.txtMaSanh.TabIndex = 1;
            // 
            // lblMaSanh
            // 
            this.lblMaSanh.AutoSize = true;
            this.lblMaSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanh.Location = new System.Drawing.Point(57, 74);
            this.lblMaSanh.Name = "lblMaSanh";
            this.lblMaSanh.Size = new System.Drawing.Size(171, 26);
            this.lblMaSanh.TabIndex = 0;
            this.lblMaSanh.Text = "Mã sảnh đặt tiệc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.lblGiaTien);
            this.groupBox1.Controls.Add(this.txtTenSanh);
            this.groupBox1.Controls.Add(this.lblTenSanh);
            this.groupBox1.Controls.Add(this.txtMaSanh);
            this.groupBox1.Controls.Add(this.lblMaSanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 416);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sảnh đặt tiệc";
            // 
            // SanhDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 728);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanhDatTiec";
            this.Text = "SanhDatTiec";
            this.Load += new System.EventHandler(this.SanhDatTiec_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanhDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblQLSanhDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSSanhDT;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.Label lblTenSanh;
        private System.Windows.Forms.TextBox txtMaSanh;
        private System.Windows.Forms.Label lblMaSanh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}