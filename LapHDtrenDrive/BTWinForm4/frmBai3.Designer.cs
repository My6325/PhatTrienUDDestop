namespace BTWinForm4
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
            this.lbNhap1 = new System.Windows.Forms.Label();
            this.lbNhap2 = new System.Windows.Forms.Label();
            this.txtNhap1 = new System.Windows.Forms.TextBox();
            this.txtNhap2 = new System.Windows.Forms.TextBox();
            this.lbNhapHT = new System.Windows.Forms.Label();
            this.txtNhapHT = new System.Windows.Forms.TextBox();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnUSCLN = new System.Windows.Forms.Button();
            this.grboxGT = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.grboxGT.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap1
            // 
            this.lbNhap1.AutoSize = true;
            this.lbNhap1.Location = new System.Drawing.Point(50, 209);
            this.lbNhap1.Name = "lbNhap1";
            this.lbNhap1.Size = new System.Drawing.Size(109, 16);
            this.lbNhap1.TabIndex = 0;
            this.lbNhap1.Text = "Nhập số thứ nhất:";
            // 
            // lbNhap2
            // 
            this.lbNhap2.AutoSize = true;
            this.lbNhap2.Location = new System.Drawing.Point(57, 260);
            this.lbNhap2.Name = "lbNhap2";
            this.lbNhap2.Size = new System.Drawing.Size(102, 16);
            this.lbNhap2.TabIndex = 1;
            this.lbNhap2.Text = "Nhập số thứ hai:";
            // 
            // txtNhap1
            // 
            this.txtNhap1.Location = new System.Drawing.Point(182, 203);
            this.txtNhap1.Name = "txtNhap1";
            this.txtNhap1.Size = new System.Drawing.Size(100, 22);
            this.txtNhap1.TabIndex = 2;
            // 
            // txtNhap2
            // 
            this.txtNhap2.Location = new System.Drawing.Point(182, 254);
            this.txtNhap2.Name = "txtNhap2";
            this.txtNhap2.Size = new System.Drawing.Size(100, 22);
            this.txtNhap2.TabIndex = 3;
            // 
            // lbNhapHT
            // 
            this.lbNhapHT.AutoSize = true;
            this.lbNhapHT.Location = new System.Drawing.Point(59, 26);
            this.lbNhapHT.Name = "lbNhapHT";
            this.lbNhapHT.Size = new System.Drawing.Size(100, 16);
            this.lbNhapHT.TabIndex = 4;
            this.lbNhapHT.Text = "Nhập họ và tên:";
            // 
            // txtNhapHT
            // 
            this.txtNhapHT.Location = new System.Drawing.Point(184, 20);
            this.txtNhapHT.Name = "txtNhapHT";
            this.txtNhapHT.Size = new System.Drawing.Size(220, 22);
            this.txtNhapHT.TabIndex = 6;
            // 
            // btnThongTin
            // 
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.Location = new System.Drawing.Point(292, 114);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(152, 43);
            this.btnThongTin.TabIndex = 8;
            this.btnThongTin.Text = "Thông tin người dùng";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnUSCLN
            // 
            this.btnUSCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSCLN.Location = new System.Drawing.Point(342, 209);
            this.btnUSCLN.Name = "btnUSCLN";
            this.btnUSCLN.Size = new System.Drawing.Size(152, 43);
            this.btnUSCLN.TabIndex = 9;
            this.btnUSCLN.Text = "Xem USCLN";
            this.btnUSCLN.UseVisualStyleBackColor = true;
            this.btnUSCLN.Click += new System.EventHandler(this.btnUSCLN_Click);
            // 
            // grboxGT
            // 
            this.grboxGT.Controls.Add(this.rdNu);
            this.grboxGT.Controls.Add(this.rdNam);
            this.grboxGT.Location = new System.Drawing.Point(121, 57);
            this.grboxGT.Name = "grboxGT";
            this.grboxGT.Size = new System.Drawing.Size(108, 90);
            this.grboxGT.TabIndex = 10;
            this.grboxGT.TabStop = false;
            this.grboxGT.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(26, 21);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 0;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(27, 57);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grboxGT);
            this.Controls.Add(this.btnUSCLN);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.txtNhapHT);
            this.Controls.Add(this.lbNhapHT);
            this.Controls.Add(this.txtNhap2);
            this.Controls.Add(this.txtNhap1);
            this.Controls.Add(this.lbNhap2);
            this.Controls.Add(this.lbNhap1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.grboxGT.ResumeLayout(false);
            this.grboxGT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap1;
        private System.Windows.Forms.Label lbNhap2;
        private System.Windows.Forms.TextBox txtNhap1;
        private System.Windows.Forms.TextBox txtNhap2;
        private System.Windows.Forms.Label lbNhapHT;
        private System.Windows.Forms.TextBox txtNhapHT;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnUSCLN;
        private System.Windows.Forms.GroupBox grboxGT;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
    }
}