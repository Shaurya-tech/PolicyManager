using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicyManager
{
    public partial class Event_Logger : Form
    {
        public Event_Logger()
        {
            InitializeComponent();
        }

        private void Event_Logger_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        public static string debug;
        string old;

        private void Event_Logger_Load(object sender, EventArgs e)
        {
            old = debug;
            Update.Start();
        }

        private void print(string text)
        {
            string result = "[" + DateTime.Now.ToString("hh:mm:ss tt") + "] " + text;
            this.textBox1.AppendText(result + Environment.NewLine);
        }  

        private void Update_Tick(object sender, EventArgs e)
        {
            if (debug != old)
            {
                print(debug);
                old = debug;
            }
        }
    }
}
