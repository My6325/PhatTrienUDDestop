namespace Lab_Advanced_Command
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
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTell = new System.Windows.Forms.Label();
            this.mtbTell = new System.Windows.Forms.MaskedTextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.btnAddVTNew = new System.Windows.Forms.Button();
            this.lblVT = new System.Windows.Forms.Label();
            this.ckbVaiTro = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(32, 32);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(95, 16);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "AccountName:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(162, 26);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(523, 22);
            this.txtAccountName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(523, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(162, 125);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(523, 22);
            this.txtFullName.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(32, 131);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 16);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "FullName:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(523, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Location = new System.Drawing.Point(32, 230);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(33, 16);
            this.lblTell.TabIndex = 8;
            this.lblTell.Text = "Tell:";
            // 
            // mtbTell
            // 
            this.mtbTell.Location = new System.Drawing.Point(162, 224);
            this.mtbTell.Mask = "0000.000.000";
            this.mtbTell.Name = "mtbTell";
            this.mtbTell.Size = new System.Drawing.Size(106, 22);
            this.mtbTell.TabIndex = 10;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(32, 275);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(87, 16);
            this.lblDateCreated.TabIndex = 11;
            this.lblDateCreated.Text = "DateCreated:";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreated.Location = new System.Drawing.Point(162, 269);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(121, 22);
            this.dtpDateCreated.TabIndex = 12;
            // 
            // btnAddVTNew
            // 
            this.btnAddVTNew.Location = new System.Drawing.Point(586, 337);
            this.btnAddVTNew.Name = "btnAddVTNew";
            this.btnAddVTNew.Size = new System.Drawing.Size(99, 45);
            this.btnAddVTNew.TabIndex = 13;
            this.btnAddVTNew.Text = "Add vai trò";
            this.btnAddVTNew.UseVisualStyleBackColor = true;
            this.btnAddVTNew.Click += new System.EventHandler(this.btnAddVTNew_Click);
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Location = new System.Drawing.Point(32, 320);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(48, 16);
            this.lblVT.TabIndex = 14;
            this.lblVT.Text = "Vai trò:";
            // 
            // ckbVaiTro
            // 
            this.ckbVaiTro.FormattingEnabled = true;
            this.ckbVaiTro.Location = new System.Drawing.Point(162, 314);
            this.ckbVaiTro.Name = "ckbVaiTro";
            this.ckbVaiTro.Size = new System.Drawing.Size(408, 89);
            this.ckbVaiTro.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(344, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(528, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ckbVaiTro);
            this.Controls.Add(this.lblVT);
            this.Controls.Add(this.btnAddVTNew);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInfoForm";
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.MaskedTextBox mtbTell;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Button btnAddVTNew;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.CheckedListBox ckbVaiTro;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}