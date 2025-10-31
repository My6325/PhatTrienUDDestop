namespace Lab_Advanced_Command
{
    partial class AccountForm
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemDanhSáchCácVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhậtKýHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuStripAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.ContextMenuStrip = this.contextMenuStripAccount;
            this.dgvAccount.Location = new System.Drawing.Point(26, 22);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(745, 316);
            this.dgvAccount.TabIndex = 0;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchCácVaiTròToolStripMenuItem,
            this.xemNhậtKýHoạtĐộngToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccount";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(251, 80);
            // 
            // xemDanhSáchCácVaiTròToolStripMenuItem
            // 
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Name = "xemDanhSáchCácVaiTròToolStripMenuItem";
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Text = "Xem danh sách các vai trò";
            this.xemDanhSáchCácVaiTròToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchCácVaiTròToolStripMenuItem_Click);
            // 
            // xemNhậtKýHoạtĐộngToolStripMenuItem
            // 
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Name = "xemNhậtKýHoạtĐộngToolStripMenuItem";
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Text = "Xem nhật ký hoạt động";
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Click += new System.EventHandler(this.xemNhậtKýHoạtĐộngToolStripMenuItem_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(114, 353);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(119, 45);
            this.btnThemTK.TabIndex = 1;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(294, 353);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 45);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật tài khoản";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(503, 353);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.dgvAccount);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuStripAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchCácVaiTròToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoạtĐộngToolStripMenuItem;
    }
}