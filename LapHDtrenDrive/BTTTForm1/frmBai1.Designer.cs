namespace BTTTForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureXe = new System.Windows.Forms.PictureBox();
            this.grboxMauXe = new System.Windows.Forms.GroupBox();
            this.rdbtnTrang = new System.Windows.Forms.RadioButton();
            this.rdbtnDo = new System.Windows.Forms.RadioButton();
            this.rdbtnXanh = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lbDT = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureXe)).BeginInit();
            this.grboxMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureXe
            // 
            this.pictureXe.Image = ((System.Drawing.Image)(resources.GetObject("pictureXe.Image")));
            this.pictureXe.Location = new System.Drawing.Point(21, 36);
            this.pictureXe.Name = "pictureXe";
            this.pictureXe.Size = new System.Drawing.Size(384, 228);
            this.pictureXe.TabIndex = 0;
            this.pictureXe.TabStop = false;
            // 
            // grboxMauXe
            // 
            this.grboxMauXe.Controls.Add(this.rdbtnTrang);
            this.grboxMauXe.Controls.Add(this.rdbtnDo);
            this.grboxMauXe.Controls.Add(this.rdbtnXanh);
            this.grboxMauXe.Location = new System.Drawing.Point(478, 12);
            this.grboxMauXe.Name = "grboxMauXe";
            this.grboxMauXe.Size = new System.Drawing.Size(191, 179);
            this.grboxMauXe.TabIndex = 1;
            this.grboxMauXe.TabStop = false;
            this.grboxMauXe.Text = "Chọn màu xe";
            // 
            // rdbtnTrang
            // 
            this.rdbtnTrang.AutoSize = true;
            this.rdbtnTrang.Location = new System.Drawing.Point(23, 124);
            this.rdbtnTrang.Name = "rdbtnTrang";
            this.rdbtnTrang.Size = new System.Drawing.Size(64, 20);
            this.rdbtnTrang.TabIndex = 2;
            this.rdbtnTrang.Text = "Trắng";
            this.rdbtnTrang.UseVisualStyleBackColor = true;
            this.rdbtnTrang.CheckedChanged += new System.EventHandler(this.rdbtnTrang_CheckedChanged);
            // 
            // rdbtnDo
            // 
            this.rdbtnDo.AutoSize = true;
            this.rdbtnDo.Location = new System.Drawing.Point(23, 79);
            this.rdbtnDo.Name = "rdbtnDo";
            this.rdbtnDo.Size = new System.Drawing.Size(45, 20);
            this.rdbtnDo.TabIndex = 1;
            this.rdbtnDo.Text = "Đỏ";
            this.rdbtnDo.UseVisualStyleBackColor = true;
            this.rdbtnDo.CheckedChanged += new System.EventHandler(this.rdbtnDo_CheckedChanged);
            // 
            // rdbtnXanh
            // 
            this.rdbtnXanh.AutoSize = true;
            this.rdbtnXanh.Checked = true;
            this.rdbtnXanh.Location = new System.Drawing.Point(23, 34);
            this.rdbtnXanh.Name = "rdbtnXanh";
            this.rdbtnXanh.Size = new System.Drawing.Size(58, 20);
            this.rdbtnXanh.TabIndex = 0;
            this.rdbtnXanh.TabStop = true;
            this.rdbtnXanh.Text = "Xanh";
            this.rdbtnXanh.UseVisualStyleBackColor = true;
            this.rdbtnXanh.CheckedChanged += new System.EventHandler(this.rdbtnXanh_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(424, 227);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(66, 20);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(424, 284);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(74, 20);
            this.lbSL.TabIndex = 3;
            this.lbSL.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(508, 227);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(119, 22);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(508, 284);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(71, 22);
            this.txtSL.TabIndex = 5;
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDT.Location = new System.Drawing.Point(630, 226);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(20, 24);
            this.lbDT.TabIndex = 6;
            this.lbDT.Text = "$";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTinhTien.Location = new System.Drawing.Point(478, 321);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(116, 39);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(295, 382);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(272, 29);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "Tổng tiền thanh toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "$";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.Location = new System.Drawing.Point(580, 382);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(53, 29);
            this.lbTien.TabIndex = 11;
            this.lbTien.Text = "     ";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.grboxMauXe);
            this.Controls.Add(this.pictureXe);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureXe)).EndInit();
            this.grboxMauXe.ResumeLayout(false);
            this.grboxMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureXe;
        private System.Windows.Forms.GroupBox grboxMauXe;
        private System.Windows.Forms.RadioButton rdbtnTrang;
        private System.Windows.Forms.RadioButton rdbtnDo;
        private System.Windows.Forms.RadioButton rdbtnXanh;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTien;
    }
}