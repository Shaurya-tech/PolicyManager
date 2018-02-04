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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            cEdit();
        }

        public static string name;
        public static string email;
        public static string policydescp;
        public static DateTime initdate;
        public static DateTime expdate;
        public static decimal priorweeks;
        public static string isSent;

        public static string value;

        private void cEdit()
        {
            string config = Form1.config;
            List<string> elements = new List<string>();
            string[] lines = File.ReadAllLines(config);

            for (int i = 0; i < (lines.Length); i++)
            {
                if (lines[i].Contains(value))
                {
                    string[] split = lines[i].Split('&');
                    name = split[0];
                    email = split[1];
                    policydescp = split[2];
                    //initdate = Convert.ToDateTime(split[3]);
                    initdate = DateTime.ParseExact(split[3], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    //expdate = Convert.ToDateTime(split[4]);
                    expdate = DateTime.ParseExact(split[4], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    priorweeks = Convert.ToDecimal(split[5]);
                    isSent = split[6];

                    nameBox.Text = name;
                    emailBox.Text = email;
                    policyBox.Text = policydescp;
                    startDate.SetDate(initdate);
                    endDate.SetDate(expdate);
                    lStart.Text = "Start Date: " + initdate.ToShortDateString();
                    lEnd.Text = "Expiration Date: " + expdate.ToShortDateString();
                    numericUpDown1.Value = priorweeks;
                }

                else
                {
                    // Event_Logger.debug = "Value: " + value;
                    // MessageBox.Show("Line 70: Edit Form (Values Mismatch!)");
                    // Event_Logger.debug = "in File: " + lines[i];
                }
            }           
        }

        private void DateSet(DateTime date, int init)
        {
            if (init == 1)
            {
                endDate.SetDate(date.AddYears(1));
                lStart.Text = "Start Date: " + date.ToString("dd/MM/yyyy");
                lEnd.Text = "Expiration Date: " + date.AddYears(1).ToString("dd/MM/yyyy");

                //initdate = startDate.SelectionRange.Start;
            }

            else if (init == 0)
            {
                startDate.SetDate(date.AddYears(-1));
                lEnd.Text = "Expiration Date: " + date.ToString("dd/MM/yyyy");
                lStart.Text = "Start Date: " + date.AddYears(-1).ToString("dd/MM/yyyy");

                //expdate = endDate.SelectionRange.Start;
            }
        }

        private void startDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSet(startDate.SelectionRange.Start, 1);
        }

        private void endDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSet(endDate.SelectionRange.Start, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("PLEASE ENTER A NAME!"); }
            else if (string.IsNullOrEmpty(email) || !email.Contains("@")) { MessageBox.Show("PLEASE ENTER A VALID EMAIL!"); }
            else if (string.IsNullOrEmpty(policydescp)) { MessageBox.Show("PLEASE ENTER POLICY DETAILS!"); }

            else if (initdate > expdate) { MessageBox.Show("SOMETHING WENT WRONG WITH THE DATES! PLEASE RETRY"); }

            else
            {
                string parsed = name + "&" + email + "&" + policydescp + "&" + startDate.SelectionRange.Start.ToString("dd/MM/yyyy") + "&" + endDate.SelectionRange.Start.ToString("dd/MM/yyyy") + "&" + priorweeks + "&" + isSent;
                string config = Form1.config;
                string[] lines = File.ReadAllLines(config);

                for (int i = 0; i < (lines.Length); i++)
                {
                    if (lines[i].Contains(value))
                    {
                        lines[i] = parsed;
                    }
                }

                File.WriteAllText(config, "");

                foreach (var line in lines)
                {
                    File.AppendAllText(config, line + Environment.NewLine);
                }

                this.Close();

            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            email = emailBox.Text;
        }

        private void policyBox_TextChanged(object sender, EventArgs e)
        {
            policydescp = policyBox.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            priorweeks = numericUpDown1.Value;
        }
    }
}
