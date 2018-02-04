using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicyManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        bool textbox = false;
        private TextBox lastFocused;
        private RichTextBox RlastFocused;

        private void insertvar(int var)
        {
            if (textbox)
            {
                if (var == 1)
                {
                    lastFocused.AppendText("[NAME]");
                    lastFocused.Focus();
                }

                else if (var == 2)
                {
                    lastFocused.AppendText("[POLICY DESCRIPTION]");
                    lastFocused.Focus();
                }

                else if (var == 3)
                {
                    lastFocused.AppendText("[ISSUE DATE]");
                    lastFocused.Focus();
                }

                else if (var == 4)
                {
                    lastFocused.AppendText("[EXPIRY DATE]");
                    lastFocused.Focus();
                }

                else if (var == 5)
                {
                    lastFocused.AppendText("[WEEKS LEFT]");
                    lastFocused.Focus();
                }
            }

            else if (!textbox)
            {
                if (var == 1)
                {
                    RlastFocused.AppendText("[NAME]");
                    RlastFocused.Focus();
                }

                else if (var == 2)
                {
                    RlastFocused.AppendText("[POLICY DESCRIPTION]");
                    RlastFocused.Focus();
                }

                else if (var == 3)
                {
                    RlastFocused.AppendText("[ISSUE DATE]");
                    RlastFocused.Focus();
                }

                else if (var == 4)
                {
                    RlastFocused.AppendText("[EXPIRY DATE]");
                    RlastFocused.Focus();
                }

                else if (var == 5)
                {
                    RlastFocused.AppendText("[WEEKS LEFT]");
                    RlastFocused.Focus();
                }
            }
            
        }

        #region messagevars

        private void name_Click(object sender, EventArgs e)
        {
            insertvar(1);
        }

        private void expdate_Click(object sender, EventArgs e)
        {
            insertvar(4);
        }

        private void issuedate_Click(object sender, EventArgs e)
        {
            insertvar(3);
        }

        private void policy_Click(object sender, EventArgs e)
        {
            insertvar(2);
        }

        private void weeksleft_Click(object sender, EventArgs e)
        {
            insertvar(5);
        }

        #endregion

        public static string file = "messageconfig.ini";
        public static string emailconfig = "emailconfig.ini";

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(file)){ messageload(); }
            if (File.Exists(emailconfig)) { econfigload(); }

            foreach (TextBox box in new TextBox[] { subjectBox, footerBox })
            {
                box.LostFocus += textBoxFocusLost;
            }

            messageBox.LostFocus += richtextBoxFocusLost;
        }

        private void richtextBoxFocusLost(object sender, EventArgs e)
        {
            textbox = false;
            RlastFocused = (RichTextBox)sender;
        }

        private void textBoxFocusLost(object sender, EventArgs e)
        {
            textbox = true;
            lastFocused = (TextBox)sender;
        }

        private void econfigload()
        {
            string[] split = File.ReadAllText(emailconfig).Split('&');
            email.emailAddress = split[0];
            email.username = split[1];
            email.password = split[2];
            email.smtphost = split[3];
            email.usessl = split[4];

            emailBox.Text = email.emailAddress;
            userBox.Text = email.username;
            passBox.Text = email.password;
            smtpBox.Text = email.smtphost;
            if (email.usessl == "true")
                checkBox1.CheckState = CheckState.Checked;
            else
                checkBox1.CheckState = CheckState.Unchecked;
        }

        private void messageload()
        {
            string[] split = File.ReadAllText(file).Split('&');
            subjectBox.Text = split[0];
            footerBox.Text = split[1];
            messageBox.Text = split[2];
        }

        private void save()
        {
            string subject = subjectBox.Text;
            string footer = footerBox.Text;
            string message = messageBox.Text;

            string parsed = subject + "&" + footer + "&" + message;

            File.WriteAllText(file, parsed);

            string email = emailBox.Text;
            string user = userBox.Text;
            string pass = passBox.Text;
            string smtp = smtpBox.Text;
            string useSsl;
            if (checkBox1.Checked)
                useSsl = "true";
            else
                useSsl = "false";

            string cParsed = email + "&" + user + "&" + pass + "&" + smtp + "&" + useSsl;

            File.WriteAllText(emailconfig, cParsed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
