namespace Lab_Advanced_Command
{
    partial class RoleForm
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
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 226);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(92, 226);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(133, 33);
            this.btnAddRole.TabIndex = 16;
            this.btnAddRole.Text = "Add ";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID:";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(31, 71);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(76, 16);
            this.lblRoleName.TabIndex = 19;
            this.lblRoleName.Text = "RoleName:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(31, 169);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 16);
            this.lblNotes.TabIndex = 20;
            this.lblNotes.Text = "Notes:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(31, 117);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 16);
            this.lblPath.TabIndex = 21;
            this.lblPath.Text = "Path:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(172, 22);
            this.txtID.TabIndex = 22;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(141, 65);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(381, 22);
            this.txtRoleName.TabIndex = 23;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(141, 111);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(381, 22);
            this.txtPath.TabIndex = 24;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(141, 163);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(381, 22);
            this.txtNote.TabIndex = 25;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 299);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRole);
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtNote;
    }
}