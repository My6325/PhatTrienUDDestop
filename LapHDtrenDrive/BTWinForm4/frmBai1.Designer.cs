namespace BTWinForm4
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
            this.lbNamHH = new System.Windows.Forms.Label();
            this.lbHH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(58, 52);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(216, 20);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "Thông tin của sản phẩm:";
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHienThi.Location = new System.Drawing.Point(58, 107);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(13, 20);
            this.lbHienThi.TabIndex = 1;
            this.lbHienThi.Text = ".";
            // 
            // lbNamHH
            // 
            this.lbNamHH.AutoSize = true;
            this.lbNamHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamHH.Location = new System.Drawing.Point(58, 268);
            this.lbNamHH.Name = "lbNamHH";
            this.lbNamHH.Size = new System.Drawing.Size(127, 20);
            this.lbNamHH.TabIndex = 2;
            this.lbNamHH.Text = "Năm hết hạn: ";
            // 
            // lbHH
            // 
            this.lbHH.AutoSize = true;
            this.lbHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHH.Location = new System.Drawing.Point(191, 268);
            this.lbHH.Name = "lbHH";
            this.lbHH.Size = new System.Drawing.Size(14, 20);
            this.lbHH.TabIndex = 3;
            this.lbHH.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHH);
            this.Controls.Add(this.lbNamHH);
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
        private System.Windows.Forms.Label lbNamHH;
        private System.Windows.Forms.Label lbHH;
    }
}