namespace Lab_Basic_Command
{
    partial class BillsForm
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dvgBill = new System.Windows.Forms.DataGridView();
            this.txtSTGiam = new System.Windows.Forms.TextBox();
            this.lblSTGiam = new System.Windows.Forms.Label();
            this.txtTienDaGiam = new System.Windows.Forms.TextBox();
            this.lblTienDaGiam = new System.Windows.Forms.Label();
            this.txtTienChuaGiam = new System.Windows.Forms.TextBox();
            this.lblTienChuaGiam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(76, 77);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(115, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(283, 77);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(115, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(249, 18);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(193, 39);
            this.lblHoaDon.TabIndex = 3;
            this.lblHoaDon.Text = "HÓA ĐƠN ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(12, 79);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 18);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From: ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(244, 79);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 18);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To:";
            // 
            // dvgBill
            // 
            this.dvgBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBill.Location = new System.Drawing.Point(15, 130);
            this.dvgBill.Name = "dvgBill";
            this.dvgBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgBill.Size = new System.Drawing.Size(760, 206);
            this.dvgBill.TabIndex = 6;
            this.dvgBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBill_CellDoubleClick);
            // 
            // txtSTGiam
            // 
            this.txtSTGiam.Location = new System.Drawing.Point(483, 366);
            this.txtSTGiam.Name = "txtSTGiam";
            this.txtSTGiam.Size = new System.Drawing.Size(100, 20);
            this.txtSTGiam.TabIndex = 24;
            // 
            // lblSTGiam
            // 
            this.lblSTGiam.AutoSize = true;
            this.lblSTGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTGiam.Location = new System.Drawing.Point(347, 368);
            this.lblSTGiam.Name = "lblSTGiam";
            this.lblSTGiam.Size = new System.Drawing.Size(130, 18);
            this.lblSTGiam.TabIndex = 23;
            this.lblSTGiam.Text = "Số tiền đã giảm:";
            // 
            // txtTienDaGiam
            // 
            this.txtTienDaGiam.Location = new System.Drawing.Point(224, 409);
            this.txtTienDaGiam.Name = "txtTienDaGiam";
            this.txtTienDaGiam.Size = new System.Drawing.Size(100, 20);
            this.txtTienDaGiam.TabIndex = 22;
            // 
            // lblTienDaGiam
            // 
            this.lblTienDaGiam.AutoSize = true;
            this.lblTienDaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDaGiam.Location = new System.Drawing.Point(26, 409);
            this.lblTienDaGiam.Name = "lblTienDaGiam";
            this.lblTienDaGiam.Size = new System.Drawing.Size(183, 18);
            this.lblTienDaGiam.TabIndex = 21;
            this.lblTienDaGiam.Text = "Tổng tiền sau giảm giá:";
            // 
            // txtTienChuaGiam
            // 
            this.txtTienChuaGiam.Location = new System.Drawing.Point(224, 366);
            this.txtTienChuaGiam.Name = "txtTienChuaGiam";
            this.txtTienChuaGiam.Size = new System.Drawing.Size(100, 20);
            this.txtTienChuaGiam.TabIndex = 20;
            // 
            // lblTienChuaGiam
            // 
            this.lblTienChuaGiam.AutoSize = true;
            this.lblTienChuaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienChuaGiam.Location = new System.Drawing.Point(26, 368);
            this.lblTienChuaGiam.Name = "lblTienChuaGiam";
            this.lblTienChuaGiam.Size = new System.Drawing.Size(192, 18);
            this.lblTienChuaGiam.TabIndex = 19;
            this.lblTienChuaGiam.Text = "Tổng tiền chưa giảm giá:";
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
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
            this.Name = "BillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BillsForm";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridView dvgBill;
        private System.Windows.Forms.TextBox txtSTGiam;
        private System.Windows.Forms.Label lblSTGiam;
        private System.Windows.Forms.TextBox txtTienDaGiam;
        private System.Windows.Forms.Label lblTienDaGiam;
        private System.Windows.Forms.TextBox txtTienChuaGiam;
        private System.Windows.Forms.Label lblTienChuaGiam;
    }
}