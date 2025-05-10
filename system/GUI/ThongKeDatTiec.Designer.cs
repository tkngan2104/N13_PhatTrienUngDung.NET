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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // rptThongKeTheoNgay
            // 
            this.rptThongKeTheoNgay.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeDatTiecTheoNgay.rdlc";
            this.rptThongKeTheoNgay.Location = new System.Drawing.Point(87, 507);
            this.rptThongKeTheoNgay.Name = "rptThongKeTheoNgay";
            this.rptThongKeTheoNgay.ServerReport.BearerToken = null;
            this.rptThongKeTheoNgay.Size = new System.Drawing.Size(1216, 591);
            this.rptThongKeTheoNgay.TabIndex = 0;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Location = new System.Drawing.Point(87, 153);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(126, 24);
            this.radNgay.TabIndex = 1;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "radioButton1";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(283, 153);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(126, 24);
            this.radThang.TabIndex = 2;
            this.radThang.TabStop = true;
            this.radThang.Text = "radioButton2";
            this.radThang.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(486, 153);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(126, 24);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "radioButton3";
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
            this.btnTim.Location = new System.Drawing.Point(635, 79);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 46);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "button1";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTim
            // 
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(87, 228);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersWidth = 62;
            this.dgvTim.RowTemplate.Height = 28;
            this.dgvTim.Size = new System.Drawing.Size(1216, 150);
            this.dgvTim.TabIndex = 6;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(635, 153);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 52);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "button2";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // ThongKeDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 759);
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
    }
}