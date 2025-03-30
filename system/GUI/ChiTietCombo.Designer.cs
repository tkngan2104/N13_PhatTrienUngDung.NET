namespace GUI
{
    partial class ChiTietCombo
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
            this.dgvCombo = new System.Windows.Forms.DataGridView();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblMaCB = new System.Windows.Forms.Label();
            this.txtMaCTCB = new System.Windows.Forms.TextBox();
            this.lblMaCTCB = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQLChucVu = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.cboMaCombo = new System.Windows.Forms.ComboBox();
            this.clbMonAn = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCombo
            // 
            this.dgvCombo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCombo.Location = new System.Drawing.Point(3, 25);
            this.dgvCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCombo.Name = "dgvCombo";
            this.dgvCombo.RowHeadersWidth = 62;
            this.dgvCombo.RowTemplate.Height = 28;
            this.dgvCombo.Size = new System.Drawing.Size(814, 452);
            this.dgvCombo.TabIndex = 0;
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(60, 219);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(113, 24);
            this.lblTenMonAn.TabIndex = 11;
            this.lblTenMonAn.Text = "Tên món ăn";
            // 
            // lblMaCB
            // 
            this.lblMaCB.AutoSize = true;
            this.lblMaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCB.Location = new System.Drawing.Point(59, 132);
            this.lblMaCB.Name = "lblMaCB";
            this.lblMaCB.Size = new System.Drawing.Size(100, 24);
            this.lblMaCB.TabIndex = 2;
            this.lblMaCB.Text = "Mã combo";
            // 
            // txtMaCTCB
            // 
            this.txtMaCTCB.Enabled = false;
            this.txtMaCTCB.Location = new System.Drawing.Point(63, 66);
            this.txtMaCTCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCTCB.Name = "txtMaCTCB";
            this.txtMaCTCB.Size = new System.Drawing.Size(270, 30);
            this.txtMaCTCB.TabIndex = 1;
            // 
            // lblMaCTCB
            // 
            this.lblMaCTCB.AutoSize = true;
            this.lblMaCTCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTCB.Location = new System.Drawing.Point(59, 42);
            this.lblMaCTCB.Name = "lblMaCTCB";
            this.lblMaCTCB.Size = new System.Drawing.Size(158, 24);
            this.lblMaCTCB.TabIndex = 0;
            this.lblMaCTCB.Text = "Mã chi tiết combo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCombo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 108);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(820, 479);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách combo";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.clbMonAn);
            this.groupBox1.Controls.Add(this.cboMaCombo);
            this.groupBox1.Controls.Add(this.lblTenMonAn);
            this.groupBox1.Controls.Add(this.lblMaCB);
            this.groupBox1.Controls.Add(this.txtMaCTCB);
            this.groupBox1.Controls.Add(this.lblMaCTCB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-14, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 479);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin combo";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(524, 38);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(192, 34);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa combo";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(997, 38);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(192, 34);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(762, 38);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(192, 34);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(288, 38);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(192, 34);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa combo";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 599);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1257, 98);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(55, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(192, 34);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm combo";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHI TIẾT COMBO";
            // 
            // lblQLChucVu
            // 
            this.lblQLChucVu.AutoSize = true;
            this.lblQLChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLChucVu.Location = new System.Drawing.Point(430, 17);
            this.lblQLChucVu.Name = "lblQLChucVu";
            this.lblQLChucVu.Size = new System.Drawing.Size(32, 48);
            this.lblQLChucVu.TabIndex = 1;
            this.lblQLChucVu.Text = " ";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTieuDe.Controls.Add(this.label1);
            this.pnlTieuDe.Controls.Add(this.lblQLChucVu);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1283, 80);
            this.pnlTieuDe.TabIndex = 39;
            // 
            // cboMaCombo
            // 
            this.cboMaCombo.FormattingEnabled = true;
            this.cboMaCombo.Location = new System.Drawing.Point(64, 160);
            this.cboMaCombo.Name = "cboMaCombo";
            this.cboMaCombo.Size = new System.Drawing.Size(269, 33);
            this.cboMaCombo.TabIndex = 12;
            // 
            // clbMonAn
            // 
            this.clbMonAn.FormattingEnabled = true;
            this.clbMonAn.Location = new System.Drawing.Point(64, 247);
            this.clbMonAn.Name = "clbMonAn";
            this.clbMonAn.Size = new System.Drawing.Size(269, 204);
            this.clbMonAn.TabIndex = 14;
            // 
            // ChiTietCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietCombo";
            this.Text = "ChiTietCombo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblMaCB;
        private System.Windows.Forms.TextBox txtMaCTCB;
        private System.Windows.Forms.Label lblMaCTCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQLChucVu;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.ComboBox cboMaCombo;
        private System.Windows.Forms.CheckedListBox clbMonAn;
    }
}