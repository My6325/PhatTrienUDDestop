namespace BTWinForm2
{
    partial class frmBai1
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
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(48, 72);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(157, 20);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "Thông tin thiết bị:";
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(61, 109);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(10, 16);
            this.lbHienThi.TabIndex = 1;
            this.lbHienThi.Text = ".";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(49, 235);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(109, 20);
            this.lbThanhTien.TabIndex = 2;
            this.lbThanhTien.Text = "Thành tiền: ";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Location = new System.Drawing.Point(162, 238);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(10, 16);
            this.lbTien.TabIndex = 3;
            this.lbTien.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.lbThongTin);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lbHienThi;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbTien;
    }
}