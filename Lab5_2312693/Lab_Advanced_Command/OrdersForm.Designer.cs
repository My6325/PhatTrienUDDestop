namespace Lab_Advanced_Command
{
    partial class OrdersForm
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
            this.dvgBill = new System.Windows.Forms.DataGridView();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTienChuaGiam = new System.Windows.Forms.Label();
            this.txtTienChuaGiam = new System.Windows.Forms.TextBox();
            this.lblTienDaGiam = new System.Windows.Forms.Label();
            this.txtTienDaGiam = new System.Windows.Forms.TextBox();
            this.txtSTGiam = new System.Windows.Forms.TextBox();
            this.lblSTGiam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgBill
            // 
            this.dvgBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBill.Location = new System.Drawing.Point(29, 129);
            this.dvgBill.Margin = new System.Windows.Forms.Padding(4);
            this.dvgBill.Name = "dvgBill";
            this.dvgBill.RowHeadersWidth = 51;
            this.dvgBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgBill.Size = new System.Drawing.Size(1013, 239);
            this.dvgBill.TabIndex = 12;
            this.dvgBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBill_CellDoubleClick);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(335, 88);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 24);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(25, 88);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(71, 24);
            this.lblFrom.TabIndex = 10;
            this.lblFrom.Text = "From: ";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(341, 13);
            this.lblHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(234, 48);
            this.lblHoaDon.TabIndex = 9;
            this.lblHoaDon.Text = "HÓA ĐƠN ";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(387, 86);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(152, 22);
            this.dtpTo.TabIndex = 8;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(111, 86);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(152, 22);
            this.dtpFrom.TabIndex = 7;
            // 
            // lblTienChuaGiam
            // 
            this.lblTienChuaGiam.AutoSize = true;
            this.lblTienChuaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienChuaGiam.Location = new System.Drawing.Point(25, 401);
            this.lblTienChuaGiam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienChuaGiam.Name = "lblTienChuaGiam";
            this.lblTienChuaGiam.Size = new System.Drawing.Size(242, 24);
            this.lblTienChuaGiam.TabIndex = 13;
            this.lblTienChuaGiam.Text = "Tổng tiền chưa giảm giá:";
            // 
            // txtTienChuaGiam
            // 
            this.txtTienChuaGiam.Location = new System.Drawing.Point(289, 399);
            this.txtTienChuaGiam.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienChuaGiam.Name = "txtTienChuaGiam";
            this.txtTienChuaGiam.Size = new System.Drawing.Size(132, 22);
            this.txtTienChuaGiam.TabIndex = 14;
            // 
            // lblTienDaGiam
            // 
            this.lblTienDaGiam.AutoSize = true;
            this.lblTienDaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDaGiam.Location = new System.Drawing.Point(25, 452);
            this.lblTienDaGiam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienDaGiam.Name = "lblTienDaGiam";
            this.lblTienDaGiam.Size = new System.Drawing.Size(229, 24);
            this.lblTienDaGiam.TabIndex = 15;
            this.lblTienDaGiam.Text = "Tổng tiền sau giảm giá:";
            // 
            // txtTienDaGiam
            // 
            this.txtTienDaGiam.Location = new System.Drawing.Point(289, 452);
            this.txtTienDaGiam.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienDaGiam.Name = "txtTienDaGiam";
            this.txtTienDaGiam.Size = new System.Drawing.Size(132, 22);
            this.txtTienDaGiam.TabIndex = 16;
            // 
            // txtSTGiam
            // 
            this.txtSTGiam.Location = new System.Drawing.Point(635, 399);
            this.txtSTGiam.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTGiam.Name = "txtSTGiam";
            this.txtSTGiam.Size = new System.Drawing.Size(132, 22);
            this.txtSTGiam.TabIndex = 18;
            // 
            // lblSTGiam
            // 
            this.lblSTGiam.AutoSize = true;
            this.lblSTGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTGiam.Location = new System.Drawing.Point(453, 401);
            this.lblSTGiam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTGiam.Name = "lblSTGiam";
            this.lblSTGiam.Size = new System.Drawing.Size(162, 24);
            this.lblSTGiam.TabIndex = 17;
            this.lblSTGiam.Text = "Số tiền đã giảm:";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 512);
            this.Controls.Add(this.txtSTGiam);
            this.Controls.Add(this.lblSTGiam);
            this.Controls.Add(this.txtTienDaGiam);
            this.Controls.Add(this.lblTienDaGiam);
            this.Controls.Add(this.txtTienChuaGiam);
            this.Controls.Add(this.lblTienChuaGiam);
            this.Controls.Add(this.dvgBill);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgBill;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTienChuaGiam;
        private System.Windows.Forms.TextBox txtTienChuaGiam;
        private System.Windows.Forms.Label lblTienDaGiam;
        private System.Windows.Forms.TextBox txtTienDaGiam;
        private System.Windows.Forms.TextBox txtSTGiam;
        private System.Windows.Forms.Label lblSTGiam;
    }
}