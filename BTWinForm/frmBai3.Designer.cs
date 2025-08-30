namespace BTWinForm
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoN = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.grboxChon = new System.Windows.Forms.GroupBox();
            this.rdbtnTinhTongA_B = new System.Windows.Forms.RadioButton();
            this.rdbtnTinhTong1_N = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQTong = new System.Windows.Forms.Label();
            this.grboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(44, 52);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(35, 16);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "Số a";
            // 
            // lbSoN
            // 
            this.lbSoN.AutoSize = true;
            this.lbSoN.Location = new System.Drawing.Point(44, 146);
            this.lbSoN.Name = "lbSoN";
            this.lbSoN.Size = new System.Drawing.Size(34, 16);
            this.lbSoN.TabIndex = 1;
            this.lbSoN.Text = "Số n";
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Location = new System.Drawing.Point(44, 98);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(35, 16);
            this.lbSoB.TabIndex = 2;
            this.lbSoB.Text = "Số b";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(112, 52);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 22);
            this.txtSoA.TabIndex = 0;
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(112, 146);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 22);
            this.txtSoN.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(112, 98);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 22);
            this.txtSoB.TabIndex = 1;
            // 
            // grboxChon
            // 
            this.grboxChon.Controls.Add(this.rdbtnTinhTong1_N);
            this.grboxChon.Controls.Add(this.rdbtnTinhTongA_B);
            this.grboxChon.Location = new System.Drawing.Point(47, 207);
            this.grboxChon.Name = "grboxChon";
            this.grboxChon.Size = new System.Drawing.Size(200, 100);
            this.grboxChon.TabIndex = 6;
            this.grboxChon.TabStop = false;
            this.grboxChon.Text = "Chọn phép toán";
            // 
            // rdbtnTinhTongA_B
            // 
            this.rdbtnTinhTongA_B.AutoSize = true;
            this.rdbtnTinhTongA_B.Checked = true;
            this.rdbtnTinhTongA_B.Location = new System.Drawing.Point(34, 24);
            this.rdbtnTinhTongA_B.Name = "rdbtnTinhTongA_B";
            this.rdbtnTinhTongA_B.Size = new System.Drawing.Size(130, 20);
            this.rdbtnTinhTongA_B.TabIndex = 7;
            this.rdbtnTinhTongA_B.TabStop = true;
            this.rdbtnTinhTongA_B.Text = "Tính tổng của a,b";
            this.rdbtnTinhTongA_B.UseVisualStyleBackColor = true;
            // 
            // rdbtnTinhTong1_N
            // 
            this.rdbtnTinhTong1_N.AutoSize = true;
            this.rdbtnTinhTong1_N.Location = new System.Drawing.Point(34, 59);
            this.rdbtnTinhTong1_N.Name = "rdbtnTinhTong1_N";
            this.rdbtnTinhTong1_N.Size = new System.Drawing.Size(142, 20);
            this.rdbtnTinhTong1_N.TabIndex = 8;
            this.rdbtnTinhTong1_N.Text = "Tính tổng từ 1 đến n";
            this.rdbtnTinhTong1_N.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(95, 323);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(87, 28);
            this.btnKetQua.TabIndex = 7;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(43, 373);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(100, 20);
            this.lbKetQua.TabIndex = 8;
            this.lbKetQua.Text = "Kết quả là:";
            // 
            // lbKQTong
            // 
            this.lbKQTong.AutoSize = true;
            this.lbKQTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQTong.Location = new System.Drawing.Point(149, 373);
            this.lbKQTong.Name = "lbKQTong";
            this.lbKQTong.Size = new System.Drawing.Size(14, 20);
            this.lbKQTong.TabIndex = 9;
            this.lbKQTong.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKQTong);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.grboxChon);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoN);
            this.Controls.Add(this.lbSoA);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.grboxChon.ResumeLayout(false);
            this.grboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoN;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.GroupBox grboxChon;
        private System.Windows.Forms.RadioButton rdbtnTinhTong1_N;
        private System.Windows.Forms.RadioButton rdbtnTinhTongA_B;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQTong;
    }
}