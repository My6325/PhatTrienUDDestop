namespace Lab_Advanced_Command
{
    partial class AccountActivity
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
            this.lbDate = new System.Windows.Forms.ListBox();
            this.dgvAccountActivity = new System.Windows.Forms.DataGridView();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.ItemHeight = 16;
            this.lbDate.Location = new System.Drawing.Point(23, 52);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(159, 180);
            this.lbDate.TabIndex = 0;
            this.lbDate.SelectedIndexChanged += new System.EventHandler(this.lbDate_SelectedIndexChanged);
            // 
            // dgvAccountActivity
            // 
            this.dgvAccountActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccountActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountActivity.Location = new System.Drawing.Point(205, 23);
            this.dgvAccountActivity.Name = "dgvAccountActivity";
            this.dgvAccountActivity.RowHeadersWidth = 51;
            this.dgvAccountActivity.RowTemplate.Height = 24;
            this.dgvAccountActivity.Size = new System.Drawing.Size(583, 355);
            this.dgvAccountActivity.TabIndex = 1;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(221, 403);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(115, 16);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số lượng hóa đơn:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(458, 403);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(66, 16);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(342, 400);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(74, 22);
            this.txtSL.TabIndex = 4;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(540, 400);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(126, 22);
            this.txtTongTien.TabIndex = 5;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(20, 23);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(87, 16);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày lập HĐ:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(48, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AccountActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.dgvAccountActivity);
            this.Controls.Add(this.lbDate);
            this.Name = "AccountActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountActivity";
            this.Load += new System.EventHandler(this.AccountActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDate;
        private System.Windows.Forms.DataGridView dgvAccountActivity;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Button btnCancel;
    }
}