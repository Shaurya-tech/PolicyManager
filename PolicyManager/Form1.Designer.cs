namespace PolicyManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ValueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueWeeksLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._weeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emailCheck = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueName,
            this.Email,
            this.PolicyDescription,
            this.ValueInitDate,
            this.ValueDueDate,
            this.ValueWeeksLeft,
            this._weeks,
            this.sent});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 506);
            this.dataGridView1.TabIndex = 3;
            // 
            // ValueName
            // 
            this.ValueName.HeaderText = "Name";
            this.ValueName.Name = "ValueName";
            this.ValueName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PolicyDescription
            // 
            this.PolicyDescription.HeaderText = "Policy Description";
            this.PolicyDescription.Name = "PolicyDescription";
            this.PolicyDescription.ReadOnly = true;
            // 
            // ValueInitDate
            // 
            this.ValueInitDate.HeaderText = "Start Date";
            this.ValueInitDate.Name = "ValueInitDate";
            this.ValueInitDate.ReadOnly = true;
            // 
            // ValueDueDate
            // 
            this.ValueDueDate.HeaderText = "Expiration Date";
            this.ValueDueDate.Name = "ValueDueDate";
            this.ValueDueDate.ReadOnly = true;
            // 
            // ValueWeeksLeft
            // 
            this.ValueWeeksLeft.HeaderText = "Weeks Left Before Expiration";
            this.ValueWeeksLeft.Name = "ValueWeeksLeft";
            this.ValueWeeksLeft.ReadOnly = true;
            // 
            // _weeks
            // 
            this._weeks.HeaderText = "Reminding Weeks Before Exp";
            this._weeks.Name = "_weeks";
            this._weeks.ReadOnly = true;
            // 
            // sent
            // 
            this.sent.HeaderText = "Email Sent";
            this.sent.Name = "sent";
            this.sent.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 55);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(285, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(190, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(95, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailCheck
            // 
            this.emailCheck.Tick += new System.EventHandler(this.emailCheck_Tick);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(380, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "History";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueWeeksLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn _weeks;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sent;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Timer emailCheck;
    }
}

