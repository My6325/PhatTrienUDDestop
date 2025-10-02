namespace WinFormsCB2
{
    partial class Mainform
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
            this.grboxGT = new System.Windows.Forms.GroupBox();
            this.rdbtnNu = new System.Windows.Forms.RadioButton();
            this.rdbtnNam = new System.Windows.Forms.RadioButton();
            this.grboxMau = new System.Windows.Forms.GroupBox();
            this.btnToMau = new System.Windows.Forms.Button();
            this.rdbtnXanh = new System.Windows.Forms.RadioButton();
            this.rdbtnDo = new System.Windows.Forms.RadioButton();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.grboxGT.SuspendLayout();
            this.grboxMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxGT
            // 
            this.grboxGT.Controls.Add(this.rdbtnNu);
            this.grboxGT.Controls.Add(this.rdbtnNam);
            this.grboxGT.Location = new System.Drawing.Point(389, 99);
            this.grboxGT.Name = "grboxGT";
            this.grboxGT.Size = new System.Drawing.Size(200, 131);
            this.grboxGT.TabIndex = 0;
            this.grboxGT.TabStop = false;
            this.grboxGT.Text = "Chọn giới tính";
            // 
            // rdbtnNu
            // 
            this.rdbtnNu.AutoSize = true;
            this.rdbtnNu.Location = new System.Drawing.Point(23, 73);
            this.rdbtnNu.Name = "rdbtnNu";
            this.rdbtnNu.Size = new System.Drawing.Size(45, 20);
            this.rdbtnNu.TabIndex = 1;
            this.rdbtnNu.TabStop = true;
            this.rdbtnNu.Text = "Nữ";
            this.rdbtnNu.UseVisualStyleBackColor = true;
            this.rdbtnNu.CheckedChanged += new System.EventHandler(this.rdbtnNu_CheckedChanged);
            // 
            // rdbtnNam
            // 
            this.rdbtnNam.AutoSize = true;
            this.rdbtnNam.Checked = true;
            this.rdbtnNam.Location = new System.Drawing.Point(23, 31);
            this.rdbtnNam.Name = "rdbtnNam";
            this.rdbtnNam.Size = new System.Drawing.Size(57, 20);
            this.rdbtnNam.TabIndex = 0;
            this.rdbtnNam.TabStop = true;
            this.rdbtnNam.Text = "Nam";
            this.rdbtnNam.UseVisualStyleBackColor = true;
            this.rdbtnNam.CheckedChanged += new System.EventHandler(this.rdbtnNam_CheckedChanged);
            // 
            // grboxMau
            // 
            this.grboxMau.Controls.Add(this.btnToMau);
            this.grboxMau.Controls.Add(this.rdbtnXanh);
            this.grboxMau.Controls.Add(this.rdbtnDo);
            this.grboxMau.Location = new System.Drawing.Point(370, 249);
            this.grboxMau.Name = "grboxMau";
            this.grboxMau.Size = new System.Drawing.Size(220, 109);
            this.grboxMau.TabIndex = 1;
            this.grboxMau.TabStop = false;
            this.grboxMau.Text = "Chọn hộp màu";
            // 
            // btnToMau
            // 
            this.btnToMau.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnToMau.Location = new System.Drawing.Point(116, 43);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 3;
            this.btnToMau.Text = "Tô Màu";
            this.btnToMau.UseVisualStyleBackColor = false;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // rdbtnXanh
            // 
            this.rdbtnXanh.AutoSize = true;
            this.rdbtnXanh.Location = new System.Drawing.Point(23, 74);
            this.rdbtnXanh.Name = "rdbtnXanh";
            this.rdbtnXanh.Size = new System.Drawing.Size(58, 20);
            this.rdbtnXanh.TabIndex = 2;
            this.rdbtnXanh.Text = "Xanh";
            this.rdbtnXanh.UseVisualStyleBackColor = true;
            // 
            // rdbtnDo
            // 
            this.rdbtnDo.AutoSize = true;
            this.rdbtnDo.Checked = true;
            this.rdbtnDo.Location = new System.Drawing.Point(23, 33);
            this.rdbtnDo.Name = "rdbtnDo";
            this.rdbtnDo.Size = new System.Drawing.Size(45, 20);
            this.rdbtnDo.TabIndex = 1;
            this.rdbtnDo.TabStop = true;
            this.rdbtnDo.Text = "Đỏ";
            this.rdbtnDo.UseVisualStyleBackColor = true;
            // 
            // txtMau
            // 
            this.txtMau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMau.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtMau.Location = new System.Drawing.Point(644, 264);
            this.txtMau.Multiline = true;
            this.txtMau.Name = "txtMau";
            this.txtMau.ReadOnly = true;
            this.txtMau.Size = new System.Drawing.Size(134, 94);
            this.txtMau.TabIndex = 2;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.grboxMau);
            this.Controls.Add(this.grboxGT);
            this.Name = "Mainform";
            this.Text = "BaiTap2";
            this.grboxGT.ResumeLayout(false);
            this.grboxGT.PerformLayout();
            this.grboxMau.ResumeLayout(false);
            this.grboxMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxGT;
        private System.Windows.Forms.RadioButton rdbtnNu;
        private System.Windows.Forms.RadioButton rdbtnNam;
        private System.Windows.Forms.GroupBox grboxMau;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rdbtnXanh;
        private System.Windows.Forms.RadioButton rdbtnDo;
        private System.Windows.Forms.TextBox txtMau;
    }
}

