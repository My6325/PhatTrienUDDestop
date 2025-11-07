namespace Lab_Basic_Command
{
    partial class AccountManager
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.lblXemNhom = new System.Windows.Forms.Label();
            this.lblXemActive = new System.Windows.Forms.Label();
            this.cbbNhom = new System.Windows.Forms.ComboBox();
            this.cbbActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTàiKhoảnToolStripMenuItem,
            this.xemDanhSáchVaiTròToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccount";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(225, 52);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiKhoảnToolStripMenuItem_Click);
            // 
            // xemDanhSáchVaiTròToolStripMenuItem
            // 
            this.xemDanhSáchVaiTròToolStripMenuItem.Name = "xemDanhSáchVaiTròToolStripMenuItem";
            this.xemDanhSáchVaiTròToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.xemDanhSáchVaiTròToolStripMenuItem.Text = "Xem danh sách vai trò";
            this.xemDanhSáchVaiTròToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchVaiTròToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(525, 414);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 46);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(316, 414);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 46);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật tài khoản";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(137, 414);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(119, 46);
            this.btnThemTK.TabIndex = 5;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.ContextMenuStrip = this.contextMenuStripAccount;
            this.dgvAccount.Location = new System.Drawing.Point(49, 82);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(745, 316);
            this.dgvAccount.TabIndex = 4;
            // 
            // lblXemNhom
            // 
            this.lblXemNhom.AutoSize = true;
            this.lblXemNhom.Location = new System.Drawing.Point(45, 28);
            this.lblXemNhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXemNhom.Name = "lblXemNhom";
            this.lblXemNhom.Size = new System.Drawing.Size(102, 16);
            this.lblXemNhom.TabIndex = 10;
            this.lblXemNhom.Text = "Xem theo nhóm:";
            // 
            // lblXemActive
            // 
            this.lblXemActive.AutoSize = true;
            this.lblXemActive.Location = new System.Drawing.Point(433, 28);
            this.lblXemActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXemActive.Name = "lblXemActive";
            this.lblXemActive.Size = new System.Drawing.Size(105, 16);
            this.lblXemActive.TabIndex = 11;
            this.lblXemActive.Text = "Xem theo active:";
            // 
            // cbbNhom
            // 
            this.cbbNhom.FormattingEnabled = true;
            this.cbbNhom.Location = new System.Drawing.Point(165, 18);
            this.cbbNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNhom.Name = "cbbNhom";
            this.cbbNhom.Size = new System.Drawing.Size(236, 24);
            this.cbbNhom.TabIndex = 12;
            this.cbbNhom.SelectedIndexChanged += new System.EventHandler(this.cbbNhom_SelectedIndexChanged);
            // 
            // cbbActive
            // 
            this.cbbActive.FormattingEnabled = true;
            this.cbbActive.Location = new System.Drawing.Point(557, 18);
            this.cbbActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbActive.Name = "cbbActive";
            this.cbbActive.Size = new System.Drawing.Size(159, 24);
            this.cbbActive.TabIndex = 13;
            this.cbbActive.SelectedIndexChanged += new System.EventHandler(this.cbbActive_SelectedIndexChanged);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 516);
            this.ContextMenuStrip = this.contextMenuStripAccount;
            this.Controls.Add(this.cbbActive);
            this.Controls.Add(this.cbbNhom);
            this.Controls.Add(this.lblXemActive);
            this.Controls.Add(this.lblXemNhom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchVaiTròToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label lblXemNhom;
        private System.Windows.Forms.Label lblXemActive;
        private System.Windows.Forms.ComboBox cbbNhom;
        private System.Windows.Forms.ComboBox cbbActive;
    }
}