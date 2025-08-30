namespace BTWinForm
{
    partial class frmchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBai1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBai2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBai3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBai1,
            this.toolStripBai2,
            this.toolStripBai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBai1
            // 
            this.toolStripBai1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBai1.Image")));
            this.toolStripBai1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBai1.Name = "toolStripBai1";
            this.toolStripBai1.Size = new System.Drawing.Size(66, 24);
            this.toolStripBai1.Text = "Bài 1";
            this.toolStripBai1.Click += new System.EventHandler(this.toolStripBai1_Click);
            // 
            // toolStripBai2
            // 
            this.toolStripBai2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBai2.Image")));
            this.toolStripBai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBai2.Name = "toolStripBai2";
            this.toolStripBai2.Size = new System.Drawing.Size(66, 24);
            this.toolStripBai2.Text = "Bài 2";
            this.toolStripBai2.Click += new System.EventHandler(this.toolStripBai2_Click);
            // 
            // toolStripBai3
            // 
            this.toolStripBai3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBai3.Image")));
            this.toolStripBai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBai3.Name = "toolStripBai3";
            this.toolStripBai3.Size = new System.Drawing.Size(66, 24);
            this.toolStripBai3.Text = "Bài 3";
            this.toolStripBai3.Click += new System.EventHandler(this.toolStripBai3_Click);
            // 
            // frmchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmchinh";
            this.Text = "Chương trình chính";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBai1;
        private System.Windows.Forms.ToolStripButton toolStripBai2;
        private System.Windows.Forms.ToolStripButton toolStripBai3;
    }
}

