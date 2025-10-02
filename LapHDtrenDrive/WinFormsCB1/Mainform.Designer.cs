namespace WinFormsCB1
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
            this.lbTen = new System.Windows.Forms.Label();
            this.lbXuat = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(90, 53);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(97, 16);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Nhập họ và tên";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbXuat
            // 
            this.lbXuat.AutoSize = true;
            this.lbXuat.Location = new System.Drawing.Point(90, 130);
            this.lbXuat.Name = "lbXuat";
            this.lbXuat.Size = new System.Drawing.Size(83, 16);
            this.lbXuat.TabIndex = 1;
            this.lbXuat.Text = "Bạn đã nhập";
            this.lbXuat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(241, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(192, 22);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(241, 130);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(192, 22);
            this.txtCopy.TabIndex = 3;
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXuLy.Location = new System.Drawing.Point(241, 88);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 4;
            this.btnXuLy.Text = "Xử Lý";
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSaoChep.Location = new System.Drawing.Point(349, 88);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = false;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbXuat);
            this.Controls.Add(this.lbTen);
            this.Name = "Mainform";
            this.Text = "Chương trình đâu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbXuat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

