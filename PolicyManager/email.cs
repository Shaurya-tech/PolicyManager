using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Threading;

namespace PolicyManager
{
    class email
    {
        public static string emailAddress, username, password, smtphost, usessl;

        public static string sSubject, sMessage;

        public static string sUser, sAddress, sPolicy;
        public static DateTime sInit, sExpire;
        public static int sWeeksLeft, sWeeksBefore, sRow;

        public static void sendmail(string user, string address, string policy, DateTime init, DateTime expire, int weeksLeft, int weeksbefore, int row)
        {
            try
            {
                Form1 frm = new Form1();
                frm.emailCheck.Stop();
                string content = File.ReadAllText("messageconfig.ini");
                if (content.Contains("[NAME]")) { content = content.Replace("[NAME]", user); }
                if (content.Contains("[POLICY DESCRIPTION]")) { content = content.Replace("[POLICY DESCRIPTION]", policy); }
                if (content.Contains("[ISSUE DATE]")) { content = content.Replace("[ISSUE DATE]", init.ToShortDateString()); }
                if (content.Contains("[EXPIRY DATE]")) { content = content.Replace("[EXPIRY DATE]", expire.ToShortDateString()); }
                if (content.Contains("[WEEKS LEFT]")) { content = content.Replace("[WEEKS LEFT]", weeksLeft.ToString()); }

                string[] split = content.Split('&');

                string subject = split[0];
                string footer = split[1];
                string message = split[2];

                sSubject = subject;
                sMessage = message + Environment.NewLine + footer;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtphost, 25);

                mail.From = new MailAddress(emailAddress);
                mail.To.Add(address);
                mail.Subject = subject;
                mail.Body = message + Environment.NewLine + footer;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                if (email.usessl == "true")
                    SmtpServer.EnableSsl = true;
                else
                    SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
               // mail.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess;

                sUser = user;
                sAddress = address;
                sPolicy = policy;
                sInit = init;
                sExpire = expire;
                sWeeksLeft = weeksLeft;
                sWeeksBefore = weeksbefore;
                sRow = row;

                success();

                //SmtpServer.SendCompleted += SmtpServer_SendCompleted;

            }

            catch (Exception ex)
            {
                /*MessageBox.Show(ex.ToString());
                Event_Logger.debug = "Email To: " + address + " Failed!";*/
                //MessageBox.Show(ex.InnerException.ToString());
                //Event_Logger.debug = ex.InnerException.ToString();
                if (ex.InnerException.ToString().Contains("Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host"))
                {
                    //success();
                }

                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private static void SmtpServer_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            success();
        }

        private static void success()
        {
            Form1 frm = new Form1();
            //string before = user + "&" + address + "&" + policy + "&" + init.ToShortDateString() + "&" + expire.ToShortDateString() + "&" + weeksbefore + "&" + "False";
            string before = sUser + "&" + sAddress + "&" + sPolicy + "&" + sInit.ToString("dd/MM/yyyy") + "&" + sExpire.ToString("dd/MM/yyyy") + "&" + sWeeksBefore + "&" + "False";
            //string after = user + "&" + address + "&" + policy + "&" + init.ToShortDateString() + "&" + expire.ToShortDateString() + "&" + weeksbefore + "&" + "True";
            string after = sUser + "&" + sAddress + "&" + sPolicy + "&" + sInit.ToString("dd/MM/yyyy") + "&" + sExpire.ToString("dd/MM/yyyy") + "&" + sWeeksBefore + "&" + "True";
            string config = Form1.config;
            string[] lines = File.ReadAllLines(config);

            for (int i = 0; i < (lines.Length); i++)
            {
                if (lines[i] == before)
                {
                    lines[i] = after;
                    break;
                }
            }

            File.WriteAllText(config, "");

            foreach (var line in lines)
            {
                File.AppendAllText(config, line + Environment.NewLine);
            }


            Event_Logger.debug = "Email To: " + sAddress + " Sent Successfully!";

            frm.emailCheck.Start();
        }
    }
}
