namespace BTWinForm2
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
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.grboxChon = new System.Windows.Forms.GroupBox();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.grboxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(77, 49);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(64, 16);
            this.lbHo.TabIndex = 0;
            this.lbHo.Text = "Nhập họ: ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(77, 88);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(67, 16);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Nhập tên: ";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(77, 130);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(74, 16);
            this.lbN.TabIndex = 2;
            this.lbN.Text = "Nhập số n: ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(172, 43);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 22);
            this.txtHo.TabIndex = 0;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(172, 124);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(172, 82);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 1;
            // 
            // grboxChon
            // 
            this.grboxChon.Controls.Add(this.rdGiaiThua);
            this.grboxChon.Controls.Add(this.rdHoTen);
            this.grboxChon.Location = new System.Drawing.Point(172, 175);
            this.grboxChon.Name = "grboxChon";
            this.grboxChon.Size = new System.Drawing.Size(200, 100);
            this.grboxChon.TabIndex = 6;
            this.grboxChon.TabStop = false;
            this.grboxChon.Text = "Chọn chức năng";
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Checked = true;
            this.rdHoTen.Location = new System.Drawing.Point(23, 24);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(106, 20);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Nối họ và tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(23, 61);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(142, 20);
            this.rdGiaiThua.TabIndex = 1;
            this.rdGiaiThua.Text = "Tính giai thừa của n";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(100, 343);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(79, 20);
            this.lbKetQua.TabIndex = 7;
            this.lbKetQua.Text = "Kết quả:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(193, 343);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(14, 20);
            this.lbKQ.TabIndex = 8;
            this.lbKQ.Text = ".";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(197, 294);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(123, 35);
            this.btnKetQua.TabIndex = 9;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.grboxChon);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbHo);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.grboxChon.ResumeLayout(false);
            this.grboxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox grboxChon;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnKetQua;
    }
}