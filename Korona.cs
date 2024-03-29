﻿using HtmlAgilityPack;
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
            try
            {
                Uri url = new Uri("https://news.google.com/covid19/map?hl=tr&mid=%2Fm%2F01znc_&gl=TR&ceid=TR%3Atr");
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);

                HtmlNodeCollection toplamVaka = dokuman.DocumentNode.SelectNodes("/html/body/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div/div/div[1]/div[2]");
                if (toplamVaka != null)
                {
                    foreach (HtmlNode title in toplamVaka)
                    {
                        vakaLabel.Text = "Toplam Vaka Sayısı : " + title.InnerText;
                    }
                }
                else
                {
                    vakaLabel.Text = "Toplam Vaka Sayısı : " + "Veri Yok";
                }

                HtmlNodeCollection sonVaka = dokuman.DocumentNode.SelectNodes("//*[@id='yDmH0d']/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div[1]/div/div[1]/div[3]/strong");
                if (sonVaka != null)
                {
                    foreach (HtmlNode title in sonVaka)
                    {
                        sonVakaLabel.Text = "Bildirilen Son Vaka : " + title.InnerText;
                    }
                }
                else
                {
                    sonVakaLabel.Text = "Bildirilen Son Vaka : " + "Veri Yok";
                }

                HtmlNodeCollection toplamOlum = dokuman.DocumentNode.SelectNodes("//*[@id='yDmH0d']/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]");
                if (toplamOlum != null)
                {
                    foreach (HtmlNode title in toplamOlum)
                    {
                        olumLabel.Text = "Toplam Vefat Sayısı : " + title.InnerText;
                    }
                }
                else
                {
                    olumLabel.Text = "Toplam Vefat Sayısı : " + "Veri Yok";
                }

                HtmlNodeCollection sonOlum = dokuman.DocumentNode.SelectNodes("//*[@id='yDmH0d']/c-wiz/div/div[2]/div[2]/div[4]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[3]/strong");
                if (sonOlum != null)
                {
                    foreach (HtmlNode title in sonOlum)
                    {
                        sonOlumLabel.Text = "Bildirilen Son Vefat : " + title.InnerText;
                    }
                }
                else
                {
                    sonOlumLabel.Text = "Bildirilen Son Vefat : " + "Veri Yok";
                }
            }
            catch(Exception e)
            {
                vakaLabel.Text = "Toplam Vaka Sayısı : " + "Veri Yok";
                sonVakaLabel.Text = "Bildirilen Son Vaka : " + "Veri Yok";
                olumLabel.Text = "Toplam Vefat Sayısı : " + "Veri Yok";
                sonOlumLabel.Text = "Bildirilen Son Vefat : " + "Veri Yok";
            }
        }
    }
}
