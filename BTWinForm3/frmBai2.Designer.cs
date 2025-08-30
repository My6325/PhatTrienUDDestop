namespace BTWinForm3
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.grboxChon = new System.Windows.Forms.GroupBox();
            this.rdTong = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.grboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(210, 42);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(187, 16);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập một số nguyên dương N:";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(422, 36);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(114, 22);
            this.txtNhapN.TabIndex = 1;
            // 
            // grboxChon
            // 
            this.grboxChon.Controls.Add(this.rdGiaiThua);
            this.grboxChon.Controls.Add(this.rdTong);
            this.grboxChon.Location = new System.Drawing.Point(336, 95);
            this.grboxChon.Name = "grboxChon";
            this.grboxChon.Size = new System.Drawing.Size(200, 100);
            this.grboxChon.TabIndex = 2;
            this.grboxChon.TabStop = false;
            this.grboxChon.Text = "Chọn công việc";
            // 
            // rdTong
            // 
            this.rdTong.AutoSize = true;
            this.rdTong.Checked = true;
            this.rdTong.Location = new System.Drawing.Point(30, 25);
            this.rdTong.Name = "rdTong";
            this.rdTong.Size = new System.Drawing.Size(140, 20);
            this.rdTong.TabIndex = 0;
            this.rdTong.TabStop = true;
            this.rdTong.Text = "Tính tổng 1+2+...+N";
            this.rdTong.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(30, 62);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(144, 20);
            this.rdGiaiThua.TabIndex = 1;
            this.rdGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(336, 216);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(111, 37);
            this.btnXemKQ.TabIndex = 3;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(252, 283);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(100, 20);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Kết quả là:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(362, 283);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(13, 20);
            this.lbKQ.TabIndex = 5;
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
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.lbNhap);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.grboxChon.ResumeLayout(false);
            this.grboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.GroupBox grboxChon;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTong;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQ;
    }
}