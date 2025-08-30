namespace BTWinForm3
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
            this.lbHTThongTin = new System.Windows.Forms.Label();
            this.lbTongLuong = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(67, 67);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(145, 16);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "Thông tin nhân viên:";
            // 
            // lbHTThongTin
            // 
            this.lbHTThongTin.AutoSize = true;
            this.lbHTThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHTThongTin.Location = new System.Drawing.Point(67, 113);
            this.lbHTThongTin.Name = "lbHTThongTin";
            this.lbHTThongTin.Size = new System.Drawing.Size(10, 16);
            this.lbHTThongTin.TabIndex = 1;
            this.lbHTThongTin.Text = ".";
            // 
            // lbTongLuong
            // 
            this.lbTongLuong.AutoSize = true;
            this.lbTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongLuong.Location = new System.Drawing.Point(67, 260);
            this.lbTongLuong.Name = "lbTongLuong";
            this.lbTongLuong.Size = new System.Drawing.Size(89, 16);
            this.lbTongLuong.TabIndex = 2;
            this.lbTongLuong.Text = "Tổng lương:";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(179, 260);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(10, 16);
            this.lbTong.TabIndex = 3;
            this.lbTong.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbTongLuong);
            this.Controls.Add(this.lbHTThongTin);
            this.Controls.Add(this.lbThongTin);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lbHTThongTin;
        private System.Windows.Forms.Label lbTongLuong;
        private System.Windows.Forms.Label lbTong;
    }
}