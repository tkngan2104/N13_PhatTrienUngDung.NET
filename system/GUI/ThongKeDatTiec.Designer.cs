namespace GUI
{
    partial class ThongKeDatTiec
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
            this.rptThongKeTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.rptThongKeTheoThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptThongKeTheoNam = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // rptThongKeTheoNgay
            // 
            this.rptThongKeTheoNgay.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeDatTiecTheoNgay.rdlc";
            this.rptThongKeTheoNgay.Location = new System.Drawing.Point(87, 587);
            this.rptThongKeTheoNgay.Name = "rptThongKeTheoNgay";
            this.rptThongKeTheoNgay.ServerReport.BearerToken = null;
            this.rptThongKeTheoNgay.Size = new System.Drawing.Size(1216, 572);
            this.rptThongKeTheoNgay.TabIndex = 0;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.Location = new System.Drawing.Point(87, 153);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(94, 33);
            this.radNgay.TabIndex = 1;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThang.Location = new System.Drawing.Point(283, 153);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(97, 30);
            this.radThang.TabIndex = 2;
            this.radThang.TabStop = true;
            this.radThang.Text = "Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(486, 153);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(84, 30);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Năm";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(87, 99);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(243, 26);
            this.dtpNgay.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(635, 79);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 46);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTim
            // 
            this.dgvTim.BackgroundColor = System.Drawing.Color.White;
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(87, 228);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersWidth = 62;
            this.dgvTim.RowTemplate.Height = 28;
            this.dgvTim.Size = new System.Drawing.Size(1216, 331);
            this.dgvTim.TabIndex = 6;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(635, 153);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 52);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // rptThongKeTheoThang
            // 
            this.rptThongKeTheoThang.Location = new System.Drawing.Point(87, 1189);
            this.rptThongKeTheoThang.Name = "rptThongKeTheoThang";
            this.rptThongKeTheoThang.ServerReport.BearerToken = null;
            this.rptThongKeTheoThang.Size = new System.Drawing.Size(1216, 572);
            this.rptThongKeTheoThang.TabIndex = 9;
            // 
            // rptThongKeTheoNam
            // 
            this.rptThongKeTheoNam.Location = new System.Drawing.Point(87, 1796);
            this.rptThongKeTheoNam.Name = "rptThongKeTheoNam";
            this.rptThongKeTheoNam.ServerReport.BearerToken = null;
            this.rptThongKeTheoNam.Size = new System.Drawing.Size(1216, 572);
            this.rptThongKeTheoNam.TabIndex = 11;
            // 
            // ThongKeDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 928);
            this.Controls.Add(this.rptThongKeTheoNam);
            this.Controls.Add(this.rptThongKeTheoThang);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radThang);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.rptThongKeTheoNgay);
            this.Name = "ThongKeDatTiec";
            this.Text = "ThongKeDatTiec";
            this.Load += new System.EventHandler(this.ThongKeDatTiec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeTheoNgay;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeTheoThang;
        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeTheoNam;
    }
}