namespace PolicyManager
{
    partial class AddForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.policy = new System.Windows.Forms.TextBox();
            this.saveBut = new System.Windows.Forms.Button();
            this.initCalender = new System.Windows.Forms.MonthCalendar();
            this.dueCalender = new System.Windows.Forms.MonthCalendar();
            this.initDate = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(334, 26);
            this.name.TabIndex = 0;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(362, 42);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(555, 26);
            this.email.TabIndex = 1;
            // 
            // policy
            // 
            this.policy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policy.Location = new System.Drawing.Point(12, 109);
            this.policy.Name = "policy";
            this.policy.Size = new System.Drawing.Size(905, 26);
            this.policy.TabIndex = 2;
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(748, 335);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(169, 36);
            this.saveBut.TabIndex = 5;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // initCalender
            // 
            this.initCalender.Location = new System.Drawing.Point(18, 171);
            this.initCalender.Name = "initCalender";
            this.initCalender.TabIndex = 6;
            this.initCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.initCalender_DateSelected);
            // 
            // dueCalender
            // 
            this.dueCalender.Location = new System.Drawing.Point(263, 171);
            this.dueCalender.Name = "dueCalender";
            this.dueCalender.TabIndex = 7;
            this.dueCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dueCalender_DateChanged);
            // 
            // initDate
            // 
            this.initDate.AutoSize = true;
            this.initDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initDate.Location = new System.Drawing.Point(536, 196);
            this.initDate.Name = "initDate";
            this.initDate.Size = new System.Drawing.Size(58, 19);
            this.initDate.TabIndex = 8;
            this.initDate.Text = "label1";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(536, 232);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(58, 19);
            this.dueDate.TabIndex = 9;
            this.dueDate.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remind ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(615, 266);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 27);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weeks Before Expiration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Expiration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Policy Details";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 383);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.initDate);
            this.Controls.Add(this.dueCalender);
            this.Controls.Add(this.initCalender);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.policy);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "AddForm";
            this.Text = "Add Reminder";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox policy;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.MonthCalendar initCalender;
        private System.Windows.Forms.MonthCalendar dueCalender;
        private System.Windows.Forms.Label initDate;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}