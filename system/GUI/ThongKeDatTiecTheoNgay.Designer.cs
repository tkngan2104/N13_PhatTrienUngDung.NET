namespace GUI
{
    partial class ThongKeDatTiecTheoNgay
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataSetThongKeDatTiecTheoNgay1 = new GUI.DataSetThongKeDatTiecTheoNgay();
            this.rptThongKeTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetThongKeDatTiecTheoNgay1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.Location = new System.Drawing.Point(1293, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataSetThongKeDatTiecTheoNgay1
            // 
            this.dataSetThongKeDatTiecTheoNgay1.DataSetName = "DataSetThongKeDatTiecTheoNgay";
            this.dataSetThongKeDatTiecTheoNgay1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptThongKeTheoNgay
            // 
            this.rptThongKeTheoNgay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptThongKeTheoNgay.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeDatTiecTheoNgay.rdlc";
            this.rptThongKeTheoNgay.Location = new System.Drawing.Point(0, 94);
            this.rptThongKeTheoNgay.Name = "rptThongKeTheoNgay";
            this.rptThongKeTheoNgay.ServerReport.BearerToken = null;
            this.rptThongKeTheoNgay.Size = new System.Drawing.Size(1473, 950);
            this.rptThongKeTheoNgay.TabIndex = 7;
            // 
            // ThongKeDatTiecTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 1044);
            this.Controls.Add(this.rptThongKeTheoNgay);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDatTiecTheoNgay";
            this.Text = "ThongKeDatTiecTheoNgay";
            this.Load += new System.EventHandler(this.ThongKeDatTiecTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetThongKeDatTiecTheoNgay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private DataSetThongKeDatTiecTheoNgay dataSetThongKeDatTiecTheoNgay1;
        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeTheoNgay;
    }
}