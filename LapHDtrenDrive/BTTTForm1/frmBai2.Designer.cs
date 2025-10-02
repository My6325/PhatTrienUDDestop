namespace BTTTForm1
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDSBanHang = new System.Windows.Forms.Label();
            this.listBoxHH = new System.Windows.Forms.ListBox();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.listBoxMua = new System.Windows.Forms.ListBox();
            this.lbDSMua = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBoxHH);
            this.panel1.Controls.Add(this.lbDSBanHang);
            this.panel1.Location = new System.Drawing.Point(49, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 285);
            this.panel1.TabIndex = 0;
            // 
            // lbDSBanHang
            // 
            this.lbDSBanHang.AutoSize = true;
            this.lbDSBanHang.Location = new System.Drawing.Point(82, 16);
            this.lbDSBanHang.Name = "lbDSBanHang";
            this.lbDSBanHang.Size = new System.Drawing.Size(133, 16);
            this.lbDSBanHang.TabIndex = 1;
            this.lbDSBanHang.Text = "Danh sách hàng hóa:";
            // 
            // listBoxHH
            // 
            this.listBoxHH.FormattingEnabled = true;
            this.listBoxHH.ItemHeight = 16;
            this.listBoxHH.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listBoxHH.Location = new System.Drawing.Point(20, 47);
            this.listBoxHH.Name = "listBoxHH";
            this.listBoxHH.Size = new System.Drawing.Size(135, 116);
            this.listBoxHH.TabIndex = 2;
            // 
            // btnChonHang
            // 
            this.btnChonHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnChonHang.Location = new System.Drawing.Point(177, 84);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(109, 40);
            this.btnChonHang.TabIndex = 3;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = false;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTien);
            this.panel2.Controls.Add(this.lbThanhToan);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.listBoxMua);
            this.panel2.Controls.Add(this.lbDSMua);
            this.panel2.Location = new System.Drawing.Point(357, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 285);
            this.panel2.TabIndex = 1;
            // 
            // btnBoHang
            // 
            this.btnBoHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBoHang.Location = new System.Drawing.Point(18, 84);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(111, 40);
            this.btnBoHang.TabIndex = 3;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = false;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // listBoxMua
            // 
            this.listBoxMua.FormattingEnabled = true;
            this.listBoxMua.ItemHeight = 16;
            this.listBoxMua.Location = new System.Drawing.Point(151, 45);
            this.listBoxMua.Name = "listBoxMua";
            this.listBoxMua.Size = new System.Drawing.Size(148, 116);
            this.listBoxMua.TabIndex = 2;
            // 
            // lbDSMua
            // 
            this.lbDSMua.AutoSize = true;
            this.lbDSMua.Location = new System.Drawing.Point(82, 16);
            this.lbDSMua.Name = "lbDSMua";
            this.lbDSMua.Size = new System.Drawing.Size(160, 16);
            this.lbDSMua.TabIndex = 1;
            this.lbDSMua.Text = "Các mặt hàng khách mua:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTinhTien.Location = new System.Drawing.Point(166, 177);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(89, 30);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(13, 233);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(197, 25);
            this.lbThanhToan.TabIndex = 5;
            this.lbThanhToan.Text = "Tổng tiền thanh toán:";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.Location = new System.Drawing.Point(218, 233);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(17, 25);
            this.lbTien.TabIndex = 6;
            this.lbTien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox listBoxHH;
        private System.Windows.Forms.Label lbDSBanHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox listBoxMua;
        private System.Windows.Forms.Label lbDSMua;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbTien;
    }
}