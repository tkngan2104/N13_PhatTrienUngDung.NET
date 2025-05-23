namespace GUI
{
    partial class ThongKeDatPhongTheoNgay
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
            this.rpt_ThongKeDatPhongTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpt_ThongKeDatPhongTheoNgay
            // 
            this.rpt_ThongKeDatPhongTheoNgay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpt_ThongKeDatPhongTheoNgay.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongTinDatPhongTheoNgay.rdlc";
            this.rpt_ThongKeDatPhongTheoNgay.Location = new System.Drawing.Point(0, 45);
            this.rpt_ThongKeDatPhongTheoNgay.Name = "rpt_ThongKeDatPhongTheoNgay";
            this.rpt_ThongKeDatPhongTheoNgay.ServerReport.BearerToken = null;
            this.rpt_ThongKeDatPhongTheoNgay.Size = new System.Drawing.Size(800, 405);
            this.rpt_ThongKeDatPhongTheoNgay.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.Location = new System.Drawing.Point(667, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ThongKeDatPhongTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rpt_ThongKeDatPhongTheoNgay);
            this.Name = "ThongKeDatPhongTheoNgay";
            this.Text = "ThongKeDatPhongTheoNgay";
            this.Load += new System.EventHandler(this.ThongKeDatPhongTheoNgay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_ThongKeDatPhongTheoNgay;
        private System.Windows.Forms.Button btnExit;
    }
}