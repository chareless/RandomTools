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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();

            mevcutLabel.Text = RastgeleAraçlar.guncelSurum;
            guncellemeDenetle();
        }
        private void guncellemeDenetle()
        {
            Uri url = new Uri("http://www.denizsaribayir.cf/randomtools.html");
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div/div/div[2]/div/div/div/div/div[2]/div[2]/div/div/p[5]/h7");
            foreach (HtmlNode title in titles)
            {
                guncelLabel.Text = title.InnerText;
            }

            if (mevcutLabel.Text == guncelLabel.Text)
            {
                indirButton.Enabled = false;
                indirButton.Visible = false;
                durumLabel.Text = "Sürüm Güncel";
            }
            else
            {
                indirButton.Enabled = true;
                indirButton.Visible = true;
                durumLabel.Text = "Güncelleme Mevcut";
            }
        }
        private void indirButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not defterinin kopyasını almayı unutmayın!");
            System.Diagnostics.Process.Start("https://github.com/chareless/RandomTools-for-Windows/archive/master.zip");
        }
    }
}
