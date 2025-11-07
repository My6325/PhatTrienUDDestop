namespace Lab_Basic_Command
{
    partial class MainHD
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
            this.lblNgay = new System.Windows.Forms.Label();
            this.dgvMainHD = new System.Windows.Forms.DataGridView();
            this.lbDate = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(37, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(16, 21);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(87, 16);
            this.lblNgay.TabIndex = 14;
            this.lblNgay.Text = "Ngày lập HĐ:";
            // 
            // dgvMainHD
            // 
            this.dgvMainHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMainHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMainHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainHD.Location = new System.Drawing.Point(201, 21);
            this.dgvMainHD.Name = "dgvMainHD";
            this.dgvMainHD.RowHeadersWidth = 51;
            this.dgvMainHD.RowTemplate.Height = 24;
            this.dgvMainHD.Size = new System.Drawing.Size(583, 355);
            this.dgvMainHD.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.ItemHeight = 16;
            this.lbDate.Location = new System.Drawing.Point(19, 50);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(159, 180);
            this.lbDate.TabIndex = 8;
            this.lbDate.SelectedIndexChanged += new System.EventHandler(this.lbDate_SelectedIndexChanged);
            // 
            // MainHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.dgvMainHD);
            this.Controls.Add(this.lbDate);
            this.Name = "MainHD";
            this.Text = "MainHD";
            this.Load += new System.EventHandler(this.MainHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridView dgvMainHD;
        private System.Windows.Forms.ListBox lbDate;
    }
}