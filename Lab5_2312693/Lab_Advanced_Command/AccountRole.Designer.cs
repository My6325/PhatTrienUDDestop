namespace Lab_Advanced_Command
{
    partial class AccountRole
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.dgvAccountRole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountRole)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(263, 362);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(150, 46);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật vai trò";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThemVT
            // 
            this.btnThemVT.Location = new System.Drawing.Point(34, 362);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(150, 46);
            this.btnThemVT.TabIndex = 5;
            this.btnThemVT.Text = "Thêm vai trò";
            this.btnThemVT.UseVisualStyleBackColor = true;
            // 
            // dgvAccountRole
            // 
            this.dgvAccountRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountRole.Location = new System.Drawing.Point(34, 43);
            this.dgvAccountRole.Name = "dgvAccountRole";
            this.dgvAccountRole.RowHeadersWidth = 51;
            this.dgvAccountRole.RowTemplate.Height = 24;
            this.dgvAccountRole.Size = new System.Drawing.Size(733, 279);
            this.dgvAccountRole.TabIndex = 4;
            // 
            // AccountRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.dgvAccountRole);
            this.Name = "AccountRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountRole";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.DataGridView dgvAccountRole;
    }
}