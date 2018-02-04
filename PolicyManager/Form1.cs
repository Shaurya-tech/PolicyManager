using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PolicyManager
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
        }

        DateTime lastaccesstime;

        public static string config = "config.ini";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(config)) { LoadConfig(); } 
            else { File.Create(config); }

            lastaccesstime = File.GetLastWriteTime(config);


            Event_Logger frm = new Event_Logger();

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - ((this.Width + frm.Width)/2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
            this.StartPosition = FormStartPosition.Manual; 
    
            frm.Location = new Point(this.Right + 10, this.Top);
            frm.StartPosition = FormStartPosition.Manual; //new Point(this.Right + 10, this.Top);
            frm.Show();


            econfigload();
            update.Start();
            emailCheck.Start();
        }

        private void econfigload()
        {
            string[] split = File.ReadAllText("emailconfig.ini").Split('&');
            email.emailAddress = split[0];
            email.username = split[1];
            email.password = split[2];
            email.smtphost = split[3];
        }

        List<string> names = new List<string>();
        List<string> emails = new List<string>();
        List<string> policydescriptions = new List<string>();
        List<DateTime> initdates = new List<DateTime>();
        List<DateTime> duedates = new List<DateTime>();
        List<int> priorweeks = new List<int>();
        List<bool> isSent = new List<bool>();

        private void LoadConfig()
        {
            lastaccesstime = File.GetLastWriteTime(config);

            //emailCheck.Interval = 100;

            names.Clear();
            emails.Clear();
            policydescriptions.Clear();
            initdates.Clear();
            duedates.Clear();
            priorweeks.Clear();
            isSent.Clear();

            dataGridView1.Rows.Clear();

            string[] contents = File.ReadAllLines(config);

            for (int i = 0; i < contents.Length; i++)
            {
                string[] split = contents[i].Split('&');
                names.Add(split[0]);
                emails.Add(split[1]);
                policydescriptions.Add(split[2]);
                //initdates.Add(Convert.ToDateTime(split[3])); // ERROR
                initdates.Add(DateTime.ParseExact(split[3],"dd/MM/yyyy" ,System.Globalization.CultureInfo.InvariantCulture));
                //duedates.Add(Convert.ToDateTime(split[4]));
                duedates.Add(DateTime.ParseExact(split[4], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                priorweeks.Add(Convert.ToInt32(split[5]));
                isSent.Add(Convert.ToBoolean(split[6]));

            }

            for (int i = 0; i < names.Count; i++)
            {
                int real = Convert.ToInt32((duedates[i].Subtract(DateTime.Today).TotalDays) / 7);

                string[] values = { names[i], emails[i], policydescriptions[i], initdates[i].ToString("dd/MM/yyyy"), duedates[i].ToString("dd/MM/yyyy"), real.ToString(), priorweeks[i].ToString(), isSent[i].ToString()};
                dataGridView1.Rows.Add(values);

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();

            Form fc = Application.OpenForms["AddForm"];

            if (fc != null)
                fc.Close();

            frm.Show();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (lastaccesstime != File.GetLastWriteTime(config))
            {
                LoadConfig();
            }
        }

        private void cUpdate()
        {
            List<string> elements = new List<string>();

            for (int i = 0; i < (dataGridView1.RowCount); i++)
            {
                string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string email = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string policydescip = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string startdate = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string expirdate = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string priorweeks = dataGridView1.Rows[i].Cells[6].Value.ToString();
                string _sent = dataGridView1.Rows[i].Cells[7].Value.ToString();

                string parsed = name + "&" + email + "&" + policydescip + "&" + startdate.ToString() + "&" + expirdate.ToString() + "&" + priorweeks + "&" + _sent;
                elements.Add(parsed);
            }

            File.WriteAllText(config, "");

            foreach (var element in elements)
            {
                File.AppendAllText(config, element + Environment.NewLine);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh();
                    cUpdate();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;

            string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
            string email = dataGridView1.Rows[i].Cells[1].Value.ToString();
            string policydescip = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string startdate = dataGridView1.Rows[i].Cells[3].Value.ToString();
            //MessageBox.Show(startdate);
            //string startdate = DateTime.ParseExact(dataGridView1.Rows[i].Cells[3].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            string expirdate = dataGridView1.Rows[i].Cells[4].Value.ToString();
            //string expirdate = DateTime.ParseExact(dataGridView1.Rows[i].Cells[4].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            string priorweeks = dataGridView1.Rows[i].Cells[6].Value.ToString();
            string _sent = dataGridView1.Rows[i].Cells[7].Value.ToString();

            string parsed = name + "&" + email + "&" + policydescip + "&" + startdate.ToString() + "&" + expirdate.ToString() + "&" + priorweeks + "&" + _sent;
            EditForm.value = parsed;
            EditForm frm = new EditForm();
            Form fc = Application.OpenForms["EditForm"];

            if (fc != null)
                fc.Close();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            Form fc = Application.OpenForms["SettingsForm"];

            if (fc != null)
                fc.Close();

            frm.Show();
        }

        public static void resetTimer()
        {
            
        }

        private void emailCheck_Tick(object sender, EventArgs e)
        {
            emailCheck.Interval = 10000;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString()) <= Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    if (!Convert.ToBoolean(dataGridView1.Rows[i].Cells[7].Value))
                    {
                        string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string address = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string policy = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        //DateTime init = Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value);
                        DateTime init = DateTime.ParseExact(dataGridView1.Rows[i].Cells[3].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        //DateTime expire = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                        DateTime expire = DateTime.ParseExact(dataGridView1.Rows[i].Cells[4].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        int weeksleft = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                        int weeksbefore = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);

                        Event_Logger.debug = "Sending Email To: " + address;

                        Thread thread = new Thread(() => email.sendmail(name, address, policy, init, expire, weeksleft, weeksbefore, i));
                        thread.Start();
                        break;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Event_Logger frm = new Event_Logger();
            Form fc = Application.OpenForms["Event_Logger"];

            if (fc != null)
                fc.Show();

            frm.Show();*/
        }
    }
}
