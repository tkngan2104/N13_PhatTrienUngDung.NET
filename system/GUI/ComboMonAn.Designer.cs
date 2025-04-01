namespace GUI
{
    partial class ComboMonAn
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
            this.lblQLMonAn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMonAn = new System.Windows.Forms.Button();
            this.txtTenMA = new System.Windows.Forms.TextBox();
            this.lblTenMA = new System.Windows.Forms.Label();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.lblTenTD = new System.Windows.Forms.Label();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.lblMaTD = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.dgvCTCB = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSuaMA = new System.Windows.Forms.Button();
            this.btnXoaMA = new System.Windows.Forms.Button();
            this.btnThemMA = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCB = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaCB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCB)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLMonAn
            // 
            this.lblQLMonAn.AutoSize = true;
            this.lblQLMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLMonAn.Location = new System.Drawing.Point(358, 22);
            this.lblQLMonAn.Name = "lblQLMonAn";
            this.lblQLMonAn.Size = new System.Drawing.Size(784, 58);
            this.lblQLMonAn.TabIndex = 1;
            this.lblQLMonAn.Text = "QUẢN LÝ THỰC ĐƠN ĐẶT TIỆC";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnMonAn);
            this.groupBox1.Controls.Add(this.txtTenMA);
            this.groupBox1.Controls.Add(this.lblTenMA);
            this.groupBox1.Controls.Add(this.txtTenTD);
            this.groupBox1.Controls.Add(this.lblTenTD);
            this.groupBox1.Controls.Add(this.txtMaTD);
            this.groupBox1.Controls.Add(this.lblMaTD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 564);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 365);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thực đơn";
            // 
            // btnMonAn
            // 
            this.btnMonAn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMonAn.FlatAppearance.BorderSize = 0;
            this.btnMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.Location = new System.Drawing.Point(355, 281);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(38, 37);
            this.btnMonAn.TabIndex = 44;
            this.btnMonAn.Text = "...";
            this.btnMonAn.UseVisualStyleBackColor = false;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // txtTenMA
            // 
            this.txtTenMA.Location = new System.Drawing.Point(37, 281);
            this.txtTenMA.Name = "txtTenMA";
            this.txtTenMA.Size = new System.Drawing.Size(303, 35);
            this.txtTenMA.TabIndex = 5;
            // 
            // lblTenMA
            // 
            this.lblTenMA.AutoSize = true;
            this.lblTenMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMA.Location = new System.Drawing.Point(32, 252);
            this.lblTenMA.Name = "lblTenMA";
            this.lblTenMA.Size = new System.Drawing.Size(127, 26);
            this.lblTenMA.TabIndex = 4;
            this.lblTenMA.Text = "Tên món ăn";
            // 
            // txtTenTD
            // 
            this.txtTenTD.Location = new System.Drawing.Point(37, 184);
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(303, 35);
            this.txtTenTD.TabIndex = 3;
            // 
            // lblTenTD
            // 
            this.lblTenTD.AutoSize = true;
            this.lblTenTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTD.Location = new System.Drawing.Point(32, 155);
            this.lblTenTD.Name = "lblTenTD";
            this.lblTenTD.Size = new System.Drawing.Size(137, 26);
            this.lblTenTD.TabIndex = 2;
            this.lblTenTD.Text = "Tên thực đơn";
            // 
            // txtMaTD
            // 
            this.txtMaTD.Enabled = false;
            this.txtMaTD.Location = new System.Drawing.Point(37, 90);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(303, 35);
            this.txtMaTD.TabIndex = 1;
            // 
            // lblMaTD
            // 
            this.lblMaTD.AutoSize = true;
            this.lblMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTD.Location = new System.Drawing.Point(32, 61);
            this.lblMaTD.Name = "lblMaTD";
            this.lblMaTD.Size = new System.Drawing.Size(131, 26);
            this.lblMaTD.TabIndex = 0;
            this.lblMaTD.Text = "Mã thực đơn";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.lblQLMonAn);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1459, 100);
            this.pnlTieuDe.TabIndex = 39;
            // 
            // dgvCTCB
            // 
            this.dgvCTCB.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTCB.Location = new System.Drawing.Point(3, 31);
            this.dgvCTCB.Name = "dgvCTCB";
            this.dgvCTCB.RowHeadersWidth = 62;
            this.dgvCTCB.RowTemplate.Height = 28;
            this.dgvCTCB.Size = new System.Drawing.Size(955, 331);
            this.dgvCTCB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCTCB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 564);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(961, 365);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách món ăn trong thực đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnSuaMA);
            this.groupBox2.Controls.Add(this.btnXoaMA);
            this.groupBox2.Controls.Add(this.btnThemMA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 953);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1404, 123);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(60, 49);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(216, 42);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1120, 49);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(216, 42);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnSuaMA
            // 
            this.btnSuaMA.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSuaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMA.ForeColor = System.Drawing.Color.White;
            this.btnSuaMA.Location = new System.Drawing.Point(855, 49);
            this.btnSuaMA.Name = "btnSuaMA";
            this.btnSuaMA.Size = new System.Drawing.Size(216, 42);
            this.btnSuaMA.TabIndex = 24;
            this.btnSuaMA.Text = "Sửa món ăn";
            this.btnSuaMA.UseVisualStyleBackColor = false;
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMA.ForeColor = System.Drawing.Color.White;
            this.btnXoaMA.Location = new System.Drawing.Point(588, 49);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Size = new System.Drawing.Size(216, 42);
            this.btnXoaMA.TabIndex = 23;
            this.btnXoaMA.Text = "Xóa món ăn";
            this.btnXoaMA.UseVisualStyleBackColor = false;
            // 
            // btnThemMA
            // 
            this.btnThemMA.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThemMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMA.ForeColor = System.Drawing.Color.White;
            this.btnThemMA.Location = new System.Drawing.Point(322, 49);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Size = new System.Drawing.Size(216, 42);
            this.btnThemMA.TabIndex = 22;
            this.btnThemMA.Text = "Thêm món ăn";
            this.btnThemMA.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCB);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1404, 322);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách thực đơn đặt tiệc";
            // 
            // dgvCB
            // 
            this.dgvCB.BackgroundColor = System.Drawing.Color.White;
            this.dgvCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCB.Location = new System.Drawing.Point(3, 31);
            this.dgvCB.Name = "dgvCB";
            this.dgvCB.RowHeadersWidth = 62;
            this.dgvCB.RowTemplate.Height = 28;
            this.dgvCB.Size = new System.Drawing.Size(1398, 288);
            this.dgvCB.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(944, 487);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(216, 42);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaCB
            // 
            this.btnXoaCB.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCB.ForeColor = System.Drawing.Color.White;
            this.btnXoaCB.Location = new System.Drawing.Point(1215, 487);
            this.btnXoaCB.Name = "btnXoaCB";
            this.btnXoaCB.Size = new System.Drawing.Size(216, 42);
            this.btnXoaCB.TabIndex = 23;
            this.btnXoaCB.Text = "Xóa thực đơn";
            this.btnXoaCB.UseVisualStyleBackColor = false;
            // 
            // ComboMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 1041);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaCB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComboMonAn";
            this.Text = "ComboMonAn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQLMonAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTD;
        private System.Windows.Forms.Label lblTenTD;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.Label lblMaTD;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.DataGridView dgvCTCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenMA;
        private System.Windows.Forms.Label lblTenMA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSuaMA;
        private System.Windows.Forms.Button btnXoaMA;
        private System.Windows.Forms.Button btnThemMA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaCB;
        private System.Windows.Forms.Button btnMonAn;
    }
}