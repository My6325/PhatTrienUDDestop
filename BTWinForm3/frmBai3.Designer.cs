namespace BTWinForm3
{
    partial class frmBai3
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbNhapSo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap1 = new System.Windows.Forms.TextBox();
            this.txtNhap2 = new System.Windows.Forms.TextBox();
            this.grboxChon = new System.Windows.Forms.GroupBox();
            this.rdTachChuoi = new System.Windows.Forms.RadioButton();
            this.rdThuTu = new System.Windows.Forms.RadioButton();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.grboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(55, 48);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(82, 16);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập họ tên:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(160, 42);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(151, 22);
            this.txtNhap.TabIndex = 1;
            // 
            // lbNhapSo1
            // 
            this.lbNhapSo1.AutoSize = true;
            this.lbNhapSo1.Location = new System.Drawing.Point(28, 99);
            this.lbNhapSo1.Name = "lbNhapSo1";
            this.lbNhapSo1.Size = new System.Drawing.Size(109, 16);
            this.lbNhapSo1.TabIndex = 2;
            this.lbNhapSo1.Text = "Nhập số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số thứ hai:";
            // 
            // txtNhap1
            // 
            this.txtNhap1.Location = new System.Drawing.Point(160, 93);
            this.txtNhap1.Name = "txtNhap1";
            this.txtNhap1.Size = new System.Drawing.Size(151, 22);
            this.txtNhap1.TabIndex = 4;
            // 
            // txtNhap2
            // 
            this.txtNhap2.Location = new System.Drawing.Point(160, 138);
            this.txtNhap2.Name = "txtNhap2";
            this.txtNhap2.Size = new System.Drawing.Size(151, 22);
            this.txtNhap2.TabIndex = 5;
            // 
            // grboxChon
            // 
            this.grboxChon.Controls.Add(this.rdThuTu);
            this.grboxChon.Controls.Add(this.rdTachChuoi);
            this.grboxChon.Location = new System.Drawing.Point(160, 195);
            this.grboxChon.Name = "grboxChon";
            this.grboxChon.Size = new System.Drawing.Size(277, 123);
            this.grboxChon.TabIndex = 6;
            this.grboxChon.TabStop = false;
            this.grboxChon.Text = "Chọn chức năng";
            // 
            // rdTachChuoi
            // 
            this.rdTachChuoi.AutoSize = true;
            this.rdTachChuoi.Checked = true;
            this.rdTachChuoi.Location = new System.Drawing.Point(28, 32);
            this.rdTachChuoi.Name = "rdTachChuoi";
            this.rdTachChuoi.Size = new System.Drawing.Size(116, 20);
            this.rdTachChuoi.TabIndex = 0;
            this.rdTachChuoi.TabStop = true;
            this.rdTachChuoi.Text = "Tách họ và tên";
            this.rdTachChuoi.UseVisualStyleBackColor = true;
            // 
            // rdThuTu
            // 
            this.rdThuTu.AutoSize = true;
            this.rdThuTu.Location = new System.Drawing.Point(28, 75);
            this.rdThuTu.Name = "rdThuTu";
            this.rdThuTu.Size = new System.Drawing.Size(230, 20);
            this.rdThuTu.TabIndex = 1;
            this.rdThuTu.Text = "Kiểm tra số có phải liên tiếp không";
            this.rdThuTu.UseVisualStyleBackColor = true;
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.Location = new System.Drawing.Point(206, 334);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(169, 32);
            this.btnXemKQ.TabIndex = 7;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(76, 405);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(79, 20);
            this.lbKetQua.TabIndex = 8;
            this.lbKetQua.Text = "Kết quả:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(184, 405);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(14, 20);
            this.lbKQ.TabIndex = 9;
            this.lbKQ.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.grboxChon);
            this.Controls.Add(this.txtNhap2);
            this.Controls.Add(this.txtNhap1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNhapSo1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.grboxChon.ResumeLayout(false);
            this.grboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lbNhapSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap1;
        private System.Windows.Forms.TextBox txtNhap2;
        private System.Windows.Forms.GroupBox grboxChon;
        private System.Windows.Forms.RadioButton rdThuTu;
        private System.Windows.Forms.RadioButton rdTachChuoi;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQ;
    }
}