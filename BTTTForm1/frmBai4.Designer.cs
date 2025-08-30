namespace BTTTForm1
{
    partial class frmBai4
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
            this.lbNhapSo = new System.Windows.Forms.Label();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapSo
            // 
            this.lbNhapSo.AutoSize = true;
            this.lbNhapSo.Location = new System.Drawing.Point(334, 96);
            this.lbNhapSo.Name = "lbNhapSo";
            this.lbNhapSo.Size = new System.Drawing.Size(103, 16);
            this.lbNhapSo.TabIndex = 0;
            this.lbNhapSo.Text = "Nhập số cần tìm";
            // 
            // btnTimSo
            // 
            this.btnTimSo.Location = new System.Drawing.Point(471, 150);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(75, 23);
            this.btnTimSo.TabIndex = 1;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(471, 96);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 22);
            this.txtNhap.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(83, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 180);
            this.listBox1.TabIndex = 3;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(349, 217);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(101, 26);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Kết quả:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(460, 214);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(19, 26);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = ".";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.lbNhapSo);
            this.Name = "frmBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapSo;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbResult;
    }
}