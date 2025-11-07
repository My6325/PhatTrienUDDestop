namespace Lab_Basic_Command
{
    partial class AccountInfoForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckbVaiTro = new System.Windows.Forms.CheckedListBox();
            this.lblVT = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.mtbTell = new System.Windows.Forms.MaskedTextBox();
            this.lblTell = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 339);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 29);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 339);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 29);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 339);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ckbVaiTro
            // 
            this.ckbVaiTro.FormattingEnabled = true;
            this.ckbVaiTro.Location = new System.Drawing.Point(119, 245);
            this.ckbVaiTro.Margin = new System.Windows.Forms.Padding(2);
            this.ckbVaiTro.Name = "ckbVaiTro";
            this.ckbVaiTro.Size = new System.Drawing.Size(307, 64);
            this.ckbVaiTro.TabIndex = 33;
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Location = new System.Drawing.Point(21, 250);
            this.lblVT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(40, 13);
            this.lblVT.TabIndex = 32;
            this.lblVT.Text = "Vai trò:";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreated.Location = new System.Drawing.Point(119, 209);
            this.dtpDateCreated.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(92, 20);
            this.dtpDateCreated.TabIndex = 30;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(21, 213);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(70, 13);
            this.lblDateCreated.TabIndex = 29;
            this.lblDateCreated.Text = "DateCreated:";
            // 
            // mtbTell
            // 
            this.mtbTell.Location = new System.Drawing.Point(119, 172);
            this.mtbTell.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTell.Mask = "0000.000.000";
            this.mtbTell.Name = "mtbTell";
            this.mtbTell.Size = new System.Drawing.Size(80, 20);
            this.mtbTell.TabIndex = 28;
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Location = new System.Drawing.Point(21, 177);
            this.lblTell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(27, 13);
            this.lblTell.TabIndex = 27;
            this.lblTell.Text = "Tell:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 137);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(119, 92);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(393, 20);
            this.txtFullName.TabIndex = 24;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(21, 96);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 23;
            this.lblFullName.Text = "FullName:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(393, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 55);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(119, 11);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(393, 20);
            this.txtAccountName.TabIndex = 20;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(21, 16);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 19;
            this.lblAccountName.Text = "AccountName:";
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 407);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ckbVaiTro);
            this.Controls.Add(this.lblVT);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.mtbTell);
            this.Controls.Add(this.lblTell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfoForm";
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox ckbVaiTro;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.MaskedTextBox mtbTell;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
    }
}