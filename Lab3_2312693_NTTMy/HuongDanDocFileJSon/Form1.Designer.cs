namespace HuongDanDocFileJSon
{
    partial class frmReadFileJSon
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
            this.btnFileJSon = new System.Windows.Forms.Button();
            this.btnFileXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileJSon
            // 
            this.btnFileJSon.Location = new System.Drawing.Point(40, 49);
            this.btnFileJSon.Name = "btnFileJSon";
            this.btnFileJSon.Size = new System.Drawing.Size(192, 65);
            this.btnFileJSon.TabIndex = 0;
            this.btnFileJSon.Text = "Đọc File JSon";
            this.btnFileJSon.UseVisualStyleBackColor = true;
            this.btnFileJSon.Click += new System.EventHandler(this.btnFileJSon_Click);
            // 
            // btnFileXML
            // 
            this.btnFileXML.Location = new System.Drawing.Point(289, 49);
            this.btnFileXML.Name = "btnFileXML";
            this.btnFileXML.Size = new System.Drawing.Size(192, 65);
            this.btnFileXML.TabIndex = 1;
            this.btnFileXML.Text = "Đọc File XML";
            this.btnFileXML.UseVisualStyleBackColor = true;
            this.btnFileXML.Click += new System.EventHandler(this.btnFileXML_Click);
            // 
            // frmReadFileJSon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.btnFileXML);
            this.Controls.Add(this.btnFileJSon);
            this.Name = "frmReadFileJSon";
            this.Text = "frmReadFileJSon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileJSon;
        private System.Windows.Forms.Button btnFileXML;
    }
}

