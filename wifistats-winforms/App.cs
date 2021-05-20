using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wifistats_winforms
{
    public partial class App : Form
    {
        bool isAlwaysOnTop = false;

        public App()
        {
            InitializeComponent();
        }

        private string sendPing(string PingDest)
        {
            Ping p = new();
            PingReply r;
            string s;
            s = PingDest;
            r = p.Send(s);

            if (r.Status == IPStatus.Success)
            {
                return r.RoundtripTime.ToString() + " ms";
            } else
            {
                return "Request Failed";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isAlwaysOnTop = !isAlwaysOnTop;
            MinimizeBox = !isAlwaysOnTop;

            TopMost = isAlwaysOnTop;

            if (isAlwaysOnTop)
            {
                Opacity = 0.7;
            }
            else
            {
                Opacity = 1;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void RunChecks_Tick(object sender, EventArgs e)
        {
            DNSPing.Text = "Cloudflare DNS Ping: "+ sendPing("1.1.1.1");
            Ping.Text = "NeverSSL Ping: " + sendPing("neverssl.com");
        }
    }
}
