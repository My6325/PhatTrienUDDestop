namespace BTWinForm2
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
            this.lbSoThuNhat = new System.Windows.Forms.Label();
            this.lbSoThuHai = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.grboxChon = new System.Windows.Forms.GroupBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.grboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSoThuNhat
            // 
            this.lbSoThuNhat.AutoSize = true;
            this.lbSoThuNhat.Location = new System.Drawing.Point(150, 53);
            this.lbSoThuNhat.Name = "lbSoThuNhat";
            this.lbSoThuNhat.Size = new System.Drawing.Size(75, 16);
            this.lbSoThuNhat.TabIndex = 0;
            this.lbSoThuNhat.Text = "Số thứ nhất:";
            // 
            // lbSoThuHai
            // 
            this.lbSoThuHai.AutoSize = true;
            this.lbSoThuHai.Location = new System.Drawing.Point(157, 100);
            this.lbSoThuHai.Name = "lbSoThuHai";
            this.lbSoThuHai.Size = new System.Drawing.Size(68, 16);
            this.lbSoThuHai.TabIndex = 1;
            this.lbSoThuHai.Text = "Số thứ hai:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(251, 47);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 22);
            this.txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(251, 97);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 22);
            this.txtSo2.TabIndex = 3;
            // 
            // grboxChon
            // 
            this.grboxChon.Controls.Add(this.rdTru);
            this.grboxChon.Controls.Add(this.rdNhan);
            this.grboxChon.Controls.Add(this.rdChia);
            this.grboxChon.Controls.Add(this.rdCong);
            this.grboxChon.Location = new System.Drawing.Point(226, 150);
            this.grboxChon.Name = "grboxChon";
            this.grboxChon.Size = new System.Drawing.Size(200, 144);
            this.grboxChon.TabIndex = 4;
            this.grboxChon.TabStop = false;
            this.grboxChon.Text = "Chọn phép toán";
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(25, 21);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(60, 20);
            this.rdCong.TabIndex = 0;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(25, 99);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(55, 20);
            this.rdChia.TabIndex = 1;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(25, 73);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(60, 20);
            this.rdNhan.TabIndex = 2;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Checked = true;
            this.rdTru.Location = new System.Drawing.Point(25, 47);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(48, 20);
            this.rdTru.TabIndex = 3;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(260, 310);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(100, 36);
            this.btnXemKQ.TabIndex = 5;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(157, 371);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(100, 20);
            this.lbKetQua.TabIndex = 6;
            this.lbKetQua.Text = "Kết quả là:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(275, 371);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(14, 20);
            this.lbKQ.TabIndex = 7;
            this.lbKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.grboxChon);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lbSoThuHai);
            this.Controls.Add(this.lbSoThuNhat);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grboxChon.ResumeLayout(false);
            this.grboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoThuNhat;
        private System.Windows.Forms.Label lbSoThuHai;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox grboxChon;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQ;
    }
}