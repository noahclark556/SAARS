namespace SAARS.ui.dialogs
{
    partial class DocumentSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.classChk = new System.Windows.Forms.CheckBox();
            this.privacyChk = new System.Windows.Forms.CheckBox();
            this.findingsChk = new System.Windows.Forms.CheckBox();
            this.CAchk = new System.Windows.Forms.CheckBox();
            this.remarksChk = new System.Windows.Forms.CheckBox();
            this.signChk = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Settings";
            // 
            // classChk
            // 
            this.classChk.AutoSize = true;
            this.classChk.Checked = true;
            this.classChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.classChk.Location = new System.Drawing.Point(31, 85);
            this.classChk.Name = "classChk";
            this.classChk.Size = new System.Drawing.Size(163, 23);
            this.classChk.TabIndex = 1;
            this.classChk.Text = "Show Classifcation";
            this.classChk.UseVisualStyleBackColor = true;
            // 
            // privacyChk
            // 
            this.privacyChk.AutoSize = true;
            this.privacyChk.Checked = true;
            this.privacyChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.privacyChk.Location = new System.Drawing.Point(31, 126);
            this.privacyChk.Name = "privacyChk";
            this.privacyChk.Size = new System.Drawing.Size(199, 23);
            this.privacyChk.TabIndex = 2;
            this.privacyChk.Text = "Show Privacy Statement";
            this.privacyChk.UseVisualStyleBackColor = true;
            // 
            // findingsChk
            // 
            this.findingsChk.AutoSize = true;
            this.findingsChk.Checked = true;
            this.findingsChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.findingsChk.Location = new System.Drawing.Point(276, 85);
            this.findingsChk.Name = "findingsChk";
            this.findingsChk.Size = new System.Drawing.Size(132, 23);
            this.findingsChk.TabIndex = 3;
            this.findingsChk.Text = "Show Findings";
            this.findingsChk.UseVisualStyleBackColor = true;
            // 
            // CAchk
            // 
            this.CAchk.AutoSize = true;
            this.CAchk.Checked = true;
            this.CAchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CAchk.Location = new System.Drawing.Point(276, 126);
            this.CAchk.Name = "CAchk";
            this.CAchk.Size = new System.Drawing.Size(190, 23);
            this.CAchk.TabIndex = 4;
            this.CAchk.Text = "Show Corrective Action";
            this.CAchk.UseVisualStyleBackColor = true;
            // 
            // remarksChk
            // 
            this.remarksChk.AutoSize = true;
            this.remarksChk.Checked = true;
            this.remarksChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remarksChk.Location = new System.Drawing.Point(31, 166);
            this.remarksChk.Name = "remarksChk";
            this.remarksChk.Size = new System.Drawing.Size(133, 23);
            this.remarksChk.TabIndex = 5;
            this.remarksChk.Text = "Show Remarks";
            this.remarksChk.UseVisualStyleBackColor = true;
            // 
            // signChk
            // 
            this.signChk.AutoSize = true;
            this.signChk.Checked = true;
            this.signChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.signChk.Location = new System.Drawing.Point(276, 166);
            this.signChk.Name = "signChk";
            this.signChk.Size = new System.Drawing.Size(184, 23);
            this.signChk.TabIndex = 6;
            this.signChk.Text = "Show Signature Fields";
            this.signChk.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(198, 213);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 33);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // DocumentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 258);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.signChk);
            this.Controls.Add(this.remarksChk);
            this.Controls.Add(this.CAchk);
            this.Controls.Add(this.findingsChk);
            this.Controls.Add(this.privacyChk);
            this.Controls.Add(this.classChk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocumentSettings";
            this.Text = "Document Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox classChk;
        private System.Windows.Forms.CheckBox privacyChk;
        private System.Windows.Forms.CheckBox findingsChk;
        private System.Windows.Forms.CheckBox CAchk;
        private System.Windows.Forms.CheckBox remarksChk;
        private System.Windows.Forms.CheckBox signChk;
        private System.Windows.Forms.Button saveBtn;
    }
}