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

        private static string dolarUrl = "https://kur.doviz.com/serbest-piyasa/amerikan-dolari";
        private static string euroUrl = "https://kur.doviz.com/serbest-piyasa/euro";
        private static string sterlinUrl = "https://kur.doviz.com/serbest-piyasa/sterlin";
        private static string gramUrl = "https://altin.doviz.com/gram-altin";
        private static string ceyrekUrl = "https://altin.doviz.com/ceyrek-altin";
        private static string yarimUrl = "https://altin.doviz.com/yarim-altin";
        private static string tamUrl = "https://altin.doviz.com/tam-altin";
        private static string cumhuriyetUrl = "https://altin.doviz.com/cumhuriyet-altini";
        private static string selectedNode = "/html/body/div[3]/div[2]/div[1]/div[2]/div/div[1]/div[2]";
        

        private void kurGoster()
        {
            dolarKur();
            euroKur();
            sterlinKur();
            gramKur();
            ceyrekKur();
            yarimKur();
            tamKur();
            cumhuriyetKur();
        }

        private void dolarKur()
        {
            try
            {
                Uri url = new Uri(dolarUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    dolarLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                dolarLabel.Text = "Hatalı Veri";
            }
        }
        private void euroKur()
        {
            try
            {
                Uri url = new Uri(euroUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    euroLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                euroLabel.Text = "Hatalı Veri";
            }
        }
        private void sterlinKur()
        {
            try
            {
                Uri url = new Uri(sterlinUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    sterlinLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                sterlinLabel.Text = "Hatalı Veri";
            }
        }

        private void gramKur()
        {
            try
            {
                Uri url = new Uri(gramUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    gramLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                gramLabel.Text = "Hatalı Veri";
            }
           
        }
        private void ceyrekKur()
        {
            try
            {
                Uri url = new Uri(ceyrekUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    ceyrekLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                ceyrekLabel.Text = "Hatalı Veri";
            }
           
        }
        private void yarimKur()
        {
            try
            {
                Uri url = new Uri(yarimUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    yarimLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                yarimLabel.Text = "Hatalı Veri";
            }
           
        }

        private void tamKur()
        {
            try
            {
                Uri url = new Uri(tamUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    tamLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                tamLabel.Text = "Hatalı Veri";
            }
            
        }
        private void cumhuriyetKur()
        {
            try
            {
                Uri url = new Uri(cumhuriyetUrl);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes(selectedNode);
                foreach (HtmlNode title in titles)
                {
                    cumhuriyetLabel.Text = title.InnerText.Trim() + " TL";
                }
            }
            catch (Exception e)
            {
                cumhuriyetLabel.Text = "Hatalı Veri";
            }
           
        }
    }
}
