namespace PolicyManager
{
    partial class SettingsForm
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.smtpBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.footerBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weeksleft = new System.Windows.Forms.Button();
            this.expdate = new System.Windows.Forms.Button();
            this.issuedate = new System.Windows.Forms.Button();
            this.policy = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailBox.Location = new System.Drawing.Point(71, 39);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(428, 26);
            this.emailBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.smtpBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Account Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "SMTP";
            // 
            // smtpBox
            // 
            this.smtpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.smtpBox.Location = new System.Drawing.Point(71, 135);
            this.smtpBox.Name = "smtpBox";
            this.smtpBox.Size = new System.Drawing.Size(428, 26);
            this.smtpBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pass";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passBox.Location = new System.Drawing.Point(71, 103);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(428, 26);
            this.passBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userBox.Location = new System.Drawing.Point(71, 71);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(428, 26);
            this.userBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.footerBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.subjectBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 364);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Settings";
            // 
            // messageBox
            // 
            this.messageBox.AcceptsTab = true;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.EnableAutoDragDrop = true;
            this.messageBox.Location = new System.Drawing.Point(15, 140);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(667, 213);
            this.messageBox.TabIndex = 6;
            this.messageBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Footer";
            // 
            // footerBox
            // 
            this.footerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.footerBox.Location = new System.Drawing.Point(82, 74);
            this.footerBox.Name = "footerBox";
            this.footerBox.Size = new System.Drawing.Size(600, 26);
            this.footerBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Subject";
            // 
            // subjectBox
            // 
            this.subjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectBox.Location = new System.Drawing.Point(82, 39);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(600, 26);
            this.subjectBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.weeksleft);
            this.groupBox3.Controls.Add(this.expdate);
            this.groupBox3.Controls.Add(this.issuedate);
            this.groupBox3.Controls.Add(this.policy);
            this.groupBox3.Controls.Add(this.name);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(731, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 364);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert Variables";
            // 
            // weeksleft
            // 
            this.weeksleft.Location = new System.Drawing.Point(23, 247);
            this.weeksleft.Name = "weeksleft";
            this.weeksleft.Size = new System.Drawing.Size(189, 37);
            this.weeksleft.TabIndex = 4;
            this.weeksleft.Text = "Weeks Before Expiry";
            this.weeksleft.UseVisualStyleBackColor = true;
            this.weeksleft.Click += new System.EventHandler(this.weeksleft_Click);
            // 
            // expdate
            // 
            this.expdate.Location = new System.Drawing.Point(23, 204);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(189, 37);
            this.expdate.TabIndex = 3;
            this.expdate.Text = "Expiry Date";
            this.expdate.UseVisualStyleBackColor = true;
            this.expdate.Click += new System.EventHandler(this.expdate_Click);
            // 
            // issuedate
            // 
            this.issuedate.Location = new System.Drawing.Point(23, 161);
            this.issuedate.Name = "issuedate";
            this.issuedate.Size = new System.Drawing.Size(189, 37);
            this.issuedate.TabIndex = 2;
            this.issuedate.Text = "Issue Date";
            this.issuedate.UseVisualStyleBackColor = true;
            this.issuedate.Click += new System.EventHandler(this.issuedate_Click);
            // 
            // policy
            // 
            this.policy.Location = new System.Drawing.Point(23, 118);
            this.policy.Name = "policy";
            this.policy.Size = new System.Drawing.Size(189, 37);
            this.policy.TabIndex = 1;
            this.policy.Text = "Policy Description";
            this.policy.UseVisualStyleBackColor = true;
            this.policy.Click += new System.EventHandler(this.policy_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(23, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 37);
            this.name.TabIndex = 0;
            this.name.Text = "Name of Recepient";
            this.name.UseVisualStyleBackColor = true;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(686, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Use SSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox smtpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox footerBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button weeksleft;
        private System.Windows.Forms.Button expdate;
        private System.Windows.Forms.Button issuedate;
        private System.Windows.Forms.Button policy;
        private System.Windows.Forms.Button name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}