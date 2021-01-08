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
    public partial class Korona : Form
    {
        public Korona()
        {
            InitializeComponent();

            korona();
        }

        private void korona()
        {
            Uri url = new Uri("https://news.google.com/covid19/map?hl=tr&mid=%2Fm%2F01znc_&gl=TR&ceid=TR%3Atr");
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection toplamVaka = dokuman.DocumentNode.SelectNodes("/html/body/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div/div/div[1]/div[2]");
            foreach (HtmlNode title in toplamVaka)
            {
                vakaLabel.Text = "Toplam Vaka Sayısı : " + title.InnerText;
            }
            HtmlNodeCollection sonVaka = dokuman.DocumentNode.SelectNodes("//*[@id='yDmH0d']/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[2]/div/div[1]/table/tbody/tr[2]/td[2]");
            foreach (HtmlNode title in sonVaka)
            {
                sonVakaLabel.Text = "Bildirilen Son Vaka : " + title.InnerText;
            }
            HtmlNodeCollection toplamOlum= dokuman.DocumentNode.SelectNodes("/html/body/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div/div/div[3]/div[2]");
            foreach (HtmlNode title in toplamOlum)
            {
                olumLabel.Text = title.InnerText;
            }
            HtmlNodeCollection sonOlum = dokuman.DocumentNode.SelectNodes("/html/body/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div/div/div[3]/div[3]");
            foreach (HtmlNode title in sonOlum)
            {
                sonOlumLabel.Text = title.InnerText;
            }
        }
    }
}
