namespace BTWinForm4
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
            this.lbNhapLT = new System.Windows.Forms.Label();
            this.lbNhapTH = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhapLT
            // 
            this.lbNhapLT.AutoSize = true;
            this.lbNhapLT.Location = new System.Drawing.Point(91, 70);
            this.lbNhapLT.Name = "lbNhapLT";
            this.lbNhapLT.Size = new System.Drawing.Size(127, 16);
            this.lbNhapLT.TabIndex = 0;
            this.lbNhapLT.Text = "Nhập điểm lý thuyết:";
            // 
            // lbNhapTH
            // 
            this.lbNhapTH.AutoSize = true;
            this.lbNhapTH.Location = new System.Drawing.Point(83, 112);
            this.lbNhapTH.Name = "lbNhapTH";
            this.lbNhapTH.Size = new System.Drawing.Size(135, 16);
            this.lbNhapTH.TabIndex = 1;
            this.lbNhapTH.Text = "Nhập điểm thực hành:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(106, 227);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(150, 20);
            this.lbKetQua.TabIndex = 2;
            this.lbKetQua.Text = "Kết quả xếp loại:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.Color.Red;
            this.lbKQ.Location = new System.Drawing.Point(284, 227);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(14, 20);
            this.lbKQ.TabIndex = 3;
            this.lbKQ.Text = ".";
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(250, 158);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(89, 33);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // txtLT
            // 
            this.txtLT.Location = new System.Drawing.Point(241, 64);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(132, 22);
            this.txtLT.TabIndex = 0;
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(241, 106);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(132, 22);
            this.txtTH.TabIndex = 1;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTH);
            this.Controls.Add(this.txtLT);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapTH);
            this.Controls.Add(this.lbNhapLT);
            this.Name = "frmBai2";
            this.Text = "Xếp Loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapLT;
        private System.Windows.Forms.Label lbNhapTH;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.TextBox txtTH;
    }
}