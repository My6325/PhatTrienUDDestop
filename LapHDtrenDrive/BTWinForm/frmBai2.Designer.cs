namespace BTWinForm
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
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.cbBoxTenhang = new System.Windows.Forms.ComboBox();
            this.grBoxHinhThuc = new System.Windows.Forms.GroupBox();
            this.rdbtnChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rdbtnTienMat = new System.Windows.Forms.RadioButton();
            this.grBoxHinhThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(35, 37);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(67, 16);
            this.lbTenHang.TabIndex = 0;
            this.lbTenHang.Text = "Tên Hàng";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(35, 122);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(64, 16);
            this.lbSL.TabIndex = 1;
            this.lbSL.Text = "Số Lượng";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(35, 80);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(55, 16);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(129, 74);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(129, 122);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 22);
            this.txtSL.TabIndex = 4;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(129, 287);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 35);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(35, 344);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(149, 20);
            this.lbThanhToan.TabIndex = 6;
            this.lbThanhToan.Text = "Số tiền thanh toán:";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.Location = new System.Drawing.Point(199, 344);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(13, 20);
            this.lbTien.TabIndex = 7;
            this.lbTien.Text = ".";
            // 
            // cbBoxTenhang
            // 
            this.cbBoxTenhang.FormattingEnabled = true;
            this.cbBoxTenhang.Items.AddRange(new object[] {
            "Chuột ",
            "Máy in",
            "Bàn phím"});
            this.cbBoxTenhang.Location = new System.Drawing.Point(129, 34);
            this.cbBoxTenhang.Name = "cbBoxTenhang";
            this.cbBoxTenhang.Size = new System.Drawing.Size(121, 24);
            this.cbBoxTenhang.TabIndex = 8;
            this.cbBoxTenhang.SelectedIndexChanged += new System.EventHandler(this.cbBoxTenhang_SelectedIndexChanged);
            // 
            // grBoxHinhThuc
            // 
            this.grBoxHinhThuc.Controls.Add(this.rdbtnTienMat);
            this.grBoxHinhThuc.Controls.Add(this.rdbtnChuyenKhoan);
            this.grBoxHinhThuc.Location = new System.Drawing.Point(129, 170);
            this.grBoxHinhThuc.Name = "grBoxHinhThuc";
            this.grBoxHinhThuc.Size = new System.Drawing.Size(200, 100);
            this.grBoxHinhThuc.TabIndex = 9;
            this.grBoxHinhThuc.TabStop = false;
            this.grBoxHinhThuc.Text = "Hình thức thanh toán";
            // 
            // rdbtnChuyenKhoan
            // 
            this.rdbtnChuyenKhoan.AutoSize = true;
            this.rdbtnChuyenKhoan.Location = new System.Drawing.Point(38, 30);
            this.rdbtnChuyenKhoan.Name = "rdbtnChuyenKhoan";
            this.rdbtnChuyenKhoan.Size = new System.Drawing.Size(113, 20);
            this.rdbtnChuyenKhoan.TabIndex = 0;
            this.rdbtnChuyenKhoan.Text = "Chuyển khoản";
            this.rdbtnChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdbtnTienMat
            // 
            this.rdbtnTienMat.AutoSize = true;
            this.rdbtnTienMat.Checked = true;
            this.rdbtnTienMat.Location = new System.Drawing.Point(38, 62);
            this.rdbtnTienMat.Name = "rdbtnTienMat";
            this.rdbtnTienMat.Size = new System.Drawing.Size(80, 20);
            this.rdbtnTienMat.TabIndex = 1;
            this.rdbtnTienMat.TabStop = true;
            this.rdbtnTienMat.Text = "Tiền mặt";
            this.rdbtnTienMat.UseVisualStyleBackColor = true;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grBoxHinhThuc);
            this.Controls.Add(this.cbBoxTenhang);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbThanhToan);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbTenHang);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grBoxHinhThuc.ResumeLayout(false);
            this.grBoxHinhThuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.ComboBox cbBoxTenhang;
        private System.Windows.Forms.GroupBox grBoxHinhThuc;
        private System.Windows.Forms.RadioButton rdbtnTienMat;
        private System.Windows.Forms.RadioButton rdbtnChuyenKhoan;
    }
}