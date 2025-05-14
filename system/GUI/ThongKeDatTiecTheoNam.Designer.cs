namespace GUI
{
    partial class ThongKeDatTiecTheoNam
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
            this.rptThongKeTheoNam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.Location = new System.Drawing.Point(1293, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rptThongKeTheoNam
            // 
            this.rptThongKeTheoNam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptThongKeTheoNam.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeDatTiecTheoNam.rdlc";
            this.rptThongKeTheoNam.Location = new System.Drawing.Point(0, 92);
            this.rptThongKeTheoNam.Name = "rptThongKeTheoNam";
            this.rptThongKeTheoNam.ServerReport.BearerToken = null;
            this.rptThongKeTheoNam.Size = new System.Drawing.Size(1473, 952);
            this.rptThongKeTheoNam.TabIndex = 8;
            // 
            // ThongKeDatTiecTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 1044);
            this.Controls.Add(this.rptThongKeTheoNam);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDatTiecTheoNam";
            this.Text = "ThongKeDatTiecTheoNam";
            this.Load += new System.EventHandler(this.ThongKeDatTiecTheoNam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeTheoNam;
    }
}