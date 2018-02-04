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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void DateSet(DateTime date, int init)
        {
            if (init == 1)
            {
                dueCalender.SetDate(date.AddYears(1));
                //DateTime.ParseExact(split[3],"dd/MM/yyyy" ,System.Globalization.CultureInfo.InvariantCulture)
                initDate.Text = "Start Date: " + date.ToString("dd/MM/yyyy");
                dueDate.Text = "Expiration Date: " + date.AddYears(1).ToString("dd/MM/yyyy");
            }

            else if (init == 0)
            {
                initCalender.SetDate(date.AddYears(-1));    
                dueDate.Text = "Expiration Date: " + date.ToString("dd/MM/yyyy");
                initDate.Text = "Start Date: " + date.AddYears(-1).ToString("dd/MM/yyyy");
            }
        }

        private void initCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSet(initCalender.SelectionRange.Start, 1);
        }

        private void dueCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateSet(dueCalender.SelectionRange.Start, 0);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            initCalender.MaxSelectionCount = 1;
            dueCalender.MaxSelectionCount = 1;
            DateSet(initCalender.SelectionRange.Start, 1);
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            save(name.Text, email.Text, policy.Text, initCalender.SelectionRange.Start, dueCalender.SelectionRange.Start, numericUpDown1.Value);
        }

        private void save(string name, string email, string policyDetails, DateTime initDate, DateTime expirationDate, decimal priorWeeks)
        {
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("PLEASE ENTER A NAME!"); }
            else if (string.IsNullOrEmpty(email) || !email.Contains("@")) { MessageBox.Show("PLEASE ENTER A VALID EMAIL!"); }
            else if (string.IsNullOrEmpty(name)) { MessageBox.Show("PLEASE ENTER POLICY DETAILS!"); }

            else if (initDate > expirationDate) { MessageBox.Show("SOMETHING WENT WRONG WITH THE DATES! PLEASE RETRY"); }

            else
            {
                string config = Form1.config;

                if (File.Exists(config))
                {
                    string parsed = name + "&" + email + "&" + policyDetails + "&" + initDate.ToString("dd/MM/yyyy") + "&" + expirationDate.ToString("dd/MM/yyyy") + "&" + priorWeeks + "&" + "False";
                    File.AppendAllText(config, parsed + Environment.NewLine);
                    this.Close();
                }
            }
        }
    }
}
