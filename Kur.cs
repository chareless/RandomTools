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
    public partial class Kur : Form
    {
        public Kur()
        {
            InitializeComponent();

            kurGoster();
        }

        private static string dolarUrl = "https://www.bloomberght.com/doviz/dolar";
        private static string euroUrl = "https://www.bloomberght.com/doviz/euro";
        private static string sterlinUrl = "https://www.bloomberght.com/doviz/ingiliz-sterlini";
        private static string gramUrl = "https://www.bloomberght.com/altin/altin-tl-gr";
        private static string ceyrekUrl = "https://www.bloomberght.com/altin/ceyrek-altin";
        private static string yarimUrl = "https://www.bloomberght.com/altin/yarim-altin";
        private static string cumhuriyetUrl = "https://www.bloomberght.com/altin/cumhuriyet-altini";

        private void kurGoster()
        {
            dolarKur();
            euroKur();
            sterlinKur();
            gramKur();
            ceyrekKur();
            yarimKur();
            cumhuriyetKur();
        }

        private void dolarKur()
        {
            Uri url = new Uri(dolarUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                dolarLabel.Text = title.InnerText + " TL";
            }
        }
        private void euroKur()
        {
            Uri url = new Uri(euroUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                euroLabel.Text = title.InnerText + " TL";
            }
        }
        private void sterlinKur()
        {
            Uri url = new Uri(sterlinUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                sterlinLabel.Text = title.InnerText + " TL";
            }
        }
        private void gramKur()
        {
            Uri url = new Uri(gramUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                gramLabel.Text = title.InnerText + " TL";
            }
        }
        private void ceyrekKur()
        {
            Uri url = new Uri(ceyrekUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                ceyrekLabel.Text = title.InnerText + " TL";
            }
        }
        private void yarimKur()
        {
            Uri url = new Uri(yarimUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                yarimLabel.Text = title.InnerText + " TL";
            }
        }
        private void cumhuriyetKur()
        {
            Uri url = new Uri(cumhuriyetUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[1]/section/div/div/div[1]/div[2]/div[1]/h1/span[1]");
            foreach (HtmlNode title in titles)
            {
                cumhuriyetLabel.Text = title.InnerText + " TL";
            }
        }
    }
}
