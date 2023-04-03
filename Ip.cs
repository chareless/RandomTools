using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class Ip : Form
    {
        public Ip()
        {
            InitializeComponent();

            ipGoster();
        }

        static string dns;
        private void ipGoster()
        {
            try
            {
                WebClient wc = new WebClient();
                dns = wc.DownloadString("https://www.ipnedir.com/");
                dns = (new System.Text.RegularExpressions.Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dns).Value;
                wc.Dispose();
                ipLabel.Text = dns;
            }
            catch(Exception e)
            {
                ipLabel.Text = "IP adresi bulunamadı.";
            }
            
        }
        private void ipLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dns);
            MessageBox.Show("IP Adresi Kopyalandı.");
        }
    }
}
