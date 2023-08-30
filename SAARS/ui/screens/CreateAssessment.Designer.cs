namespace SAARS.ui.screens
{
    partial class CreateAssessment
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
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.onPremise = new System.Windows.Forms.CheckBox();
            this.inCloud = new System.Windows.Forms.CheckBox();
            this.remoteChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findingsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remarksTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scopeSelect = new System.Windows.Forms.ComboBox();
            this.reportedPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.conductedPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confidential = new System.Windows.Forms.RadioButton();
            this.topSecret = new System.Windows.Forms.RadioButton();
            this.secret = new System.Windows.Forms.RadioButton();
            this.controlled = new System.Windows.Forms.RadioButton();
            this.unclass = new System.Windows.Forms.RadioButton();
            this.createBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(69, 31);
            this.titleTxtBox.MaxLength = 25;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(368, 27);
            this.titleTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(105, 78);
            this.descTxtBox.MaxLength = 100;
            this.descTxtBox.Multiline = true;
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(332, 76);
            this.descTxtBox.TabIndex = 2;
            // 
            // onPremise
            // 
            this.onPremise.AutoSize = true;
            this.onPremise.Location = new System.Drawing.Point(25, 40);
            this.onPremise.Name = "onPremise";
            this.onPremise.Size = new System.Drawing.Size(109, 23);
            this.onPremise.TabIndex = 4;
            this.onPremise.Text = "On Premise";
            this.onPremise.UseVisualStyleBackColor = true;
            // 
            // inCloud
            // 
            this.inCloud.AutoSize = true;
            this.inCloud.Location = new System.Drawing.Point(25, 83);
            this.inCloud.Name = "inCloud";
            this.inCloud.Size = new System.Drawing.Size(86, 23);
            this.inCloud.TabIndex = 5;
            this.inCloud.Text = "In Cloud";
            this.inCloud.UseVisualStyleBackColor = true;
            // 
            // remoteChk
            // 
            this.remoteChk.AutoSize = true;
            this.remoteChk.Location = new System.Drawing.Point(25, 126);
            this.remoteChk.Name = "remoteChk";
            this.remoteChk.Size = new System.Drawing.Size(82, 23);
            this.remoteChk.TabIndex = 6;
            this.remoteChk.Text = "Remote";
            this.remoteChk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remoteChk);
            this.groupBox1.Controls.Add(this.onPremise);
            this.groupBox1.Controls.Add(this.inCloud);
            this.groupBox1.Location = new System.Drawing.Point(479, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deployment Model";
            // 
            // findingsBox
            // 
            this.findingsBox.Location = new System.Drawing.Point(106, 323);
            this.findingsBox.MaxLength = 2147483647;
            this.findingsBox.Name = "findingsBox";
            this.findingsBox.ReadOnly = true;
            this.findingsBox.Size = new System.Drawing.Size(366, 27);
            this.findingsBox.TabIndex = 8;
            this.findingsBox.Text = "Click to input";
            this.findingsBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Findings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Corrective Action";
            // 
            // caTxtBox
            // 
            this.caTxtBox.Location = new System.Drawing.Point(158, 377);
            this.caTxtBox.MaxLength = 2147483647;
            this.caTxtBox.Name = "caTxtBox";
            this.caTxtBox.ReadOnly = true;
            this.caTxtBox.Size = new System.Drawing.Size(314, 27);
            this.caTxtBox.TabIndex = 10;
            this.caTxtBox.Text = "Click to input";
            this.caTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.caTxtBox_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Remarks";
            // 
            // remarksTxtBox
            // 
            this.remarksTxtBox.Location = new System.Drawing.Point(106, 431);
            this.remarksTxtBox.MaxLength = 2147483647;
            this.remarksTxtBox.Name = "remarksTxtBox";
            this.remarksTxtBox.ReadOnly = true;
            this.remarksTxtBox.Size = new System.Drawing.Size(366, 27);
            this.remarksTxtBox.TabIndex = 12;
            this.remarksTxtBox.Text = "Click to input";
            this.remarksTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.remarksTxtBox_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.scopeSelect);
            this.groupBox2.Controls.Add(this.reportedPicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.conductedPicker);
            this.groupBox2.Controls.Add(this.titleTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.descTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 290);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Assessment Scope";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Report Date";
            // 
            // scopeSelect
            // 
            this.scopeSelect.FormattingEnabled = true;
            this.scopeSelect.Items.AddRange(new object[] {
            "Black Box",
            "Gray Box",
            "White Box"});
            this.scopeSelect.Location = new System.Drawing.Point(154, 250);
            this.scopeSelect.Name = "scopeSelect";
            this.scopeSelect.Size = new System.Drawing.Size(283, 27);
            this.scopeSelect.TabIndex = 17;
            this.scopeSelect.Text = "Black Box";
            // 
            // reportedPicker
            // 
            this.reportedPicker.Enabled = false;
            this.reportedPicker.Location = new System.Drawing.Point(132, 211);
            this.reportedPicker.Name = "reportedPicker";
            this.reportedPicker.Size = new System.Drawing.Size(305, 27);
            this.reportedPicker.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Conducted Date";
            // 
            // conductedPicker
            // 
            this.conductedPicker.Location = new System.Drawing.Point(132, 172);
            this.conductedPicker.Name = "conductedPicker";
            this.conductedPicker.Size = new System.Drawing.Size(305, 27);
            this.conductedPicker.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confidential);
            this.groupBox3.Controls.Add(this.topSecret);
            this.groupBox3.Controls.Add(this.secret);
            this.groupBox3.Controls.Add(this.controlled);
            this.groupBox3.Controls.Add(this.unclass);
            this.groupBox3.Location = new System.Drawing.Point(479, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 216);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classification";
            // 
            // confidential
            // 
            this.confidential.AutoSize = true;
            this.confidential.Location = new System.Drawing.Point(15, 108);
            this.confidential.Name = "confidential";
            this.confidential.Size = new System.Drawing.Size(112, 23);
            this.confidential.TabIndex = 4;
            this.confidential.TabStop = true;
            this.confidential.Text = "Confidential";
            this.confidential.UseVisualStyleBackColor = true;
            // 
            // topSecret
            // 
            this.topSecret.AutoSize = true;
            this.topSecret.Location = new System.Drawing.Point(15, 185);
            this.topSecret.Name = "topSecret";
            this.topSecret.Size = new System.Drawing.Size(101, 23);
            this.topSecret.TabIndex = 3;
            this.topSecret.TabStop = true;
            this.topSecret.Text = "Top Secret";
            this.topSecret.UseVisualStyleBackColor = true;
            // 
            // secret
            // 
            this.secret.AutoSize = true;
            this.secret.Location = new System.Drawing.Point(15, 147);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(70, 23);
            this.secret.TabIndex = 2;
            this.secret.TabStop = true;
            this.secret.Text = "Secret";
            this.secret.UseVisualStyleBackColor = true;
            // 
            // controlled
            // 
            this.controlled.AutoSize = true;
            this.controlled.Location = new System.Drawing.Point(15, 70);
            this.controlled.Name = "controlled";
            this.controlled.Size = new System.Drawing.Size(190, 23);
            this.controlled.TabIndex = 1;
            this.controlled.TabStop = true;
            this.controlled.Text = "Controlled Unclassified";
            this.controlled.UseVisualStyleBackColor = true;
            // 
            // unclass
            // 
            this.unclass.AutoSize = true;
            this.unclass.Location = new System.Drawing.Point(15, 31);
            this.unclass.Name = "unclass";
            this.unclass.Size = new System.Drawing.Size(114, 23);
            this.unclass.TabIndex = 0;
            this.unclass.TabStop = true;
            this.unclass.Text = "Unclassified";
            this.unclass.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(307, 470);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(119, 37);
            this.createBtn.TabIndex = 16;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SAARS.Properties.Resources.settings;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(711, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 24);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remarksTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findingsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateAssessment";
            this.Text = "Create Assessment";
            this.Load += new System.EventHandler(this.CreateAssessment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.CheckBox onPremise;
        private System.Windows.Forms.CheckBox inCloud;
        private System.Windows.Forms.CheckBox remoteChk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox findingsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remarksTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker reportedPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker conductedPicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton confidential;
        private System.Windows.Forms.RadioButton topSecret;
        private System.Windows.Forms.RadioButton secret;
        private System.Windows.Forms.RadioButton controlled;
        private System.Windows.Forms.RadioButton unclass;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox scopeSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}