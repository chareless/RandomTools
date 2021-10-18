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
    public partial class KurCevir : Form
    {
        public KurCevir()
        {
            InitializeComponent();
        }

        private static string dolarUrl = "https://kur.doviz.com/serbest-piyasa/amerikan-dolari";
        private static string euroUrl = "https://kur.doviz.com/serbest-piyasa/euro";
        private static string sterlinUrl = "https://kur.doviz.com/serbest-piyasa/sterlin";

        private static double dolar;
        private static double euro;
        private static double sterlin;

        private static double miktar;
        private static double sonuc;

        private void kur()
        {
            dolarKur();
            euroKur();
            sterlinKur();
        }

        private void dolarKur()
        {
            Uri url = new Uri(dolarUrl);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]");
            foreach (HtmlNode title in titles)
            {
                dolar = Convert.ToSingle(title.InnerText);
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
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]");
            foreach (HtmlNode title in titles)
            {
                euro = Convert.ToSingle(title.InnerText);
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
            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]");
            foreach (HtmlNode title in titles)
            {
                sterlin = Convert.ToSingle(title.InnerText);
            }
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            if(miktarTextBox.Text != "")
            {
                miktar = Convert.ToSingle(miktarTextBox.Text);

                kur();

                if (comboBox1.Text == "Türk Lirası" && comboBox2.Text == "Dolar")
                {
                    sonuc = miktar / dolar;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " TL = " + sonuc.ToString() + " Dolar";
                }
                else if (comboBox1.Text == "Türk Lirası" && comboBox2.Text == "Euro")
                {
                    sonuc = miktar / euro;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " TL = " + sonuc.ToString() + " Euro";
                }
                else if (comboBox1.Text == "Türk Lirası" && comboBox2.Text == "Sterlin")
                {
                    sonuc = miktar / sterlin;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " TL = " + sonuc.ToString() + " Sterlin";
                }

                else if (comboBox1.Text == "Dolar" && comboBox2.Text == "Türk Lirası")
                {
                    sonuc = miktar * dolar;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Dolar = " + sonuc.ToString() + " TL";
                }
                else if (comboBox1.Text == "Euro" && comboBox2.Text == "Türk Lirası")
                {
                    sonuc = miktar * euro;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Euro = " + sonuc.ToString() + " TL";
                }
                else if (comboBox1.Text == "Sterlin" && comboBox2.Text == "Türk Lirası")
                {
                    sonuc = miktar * sterlin;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Sterlin = " + sonuc.ToString() + " TL";
                }

                else if (comboBox1.Text == "Dolar" && comboBox2.Text == "Euro")
                {
                    sonuc = miktar * dolar / euro;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Dolar = " + sonuc.ToString() + " Euro";
                }
                else if (comboBox1.Text == "Dolar" && comboBox2.Text == "Sterlin")
                {
                    sonuc = miktar * dolar / sterlin;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Dolar = " + sonuc.ToString() + " Sterlin";
                }
                else if (comboBox1.Text == "Euro" && comboBox2.Text == "Dolar")
                {
                    sonuc = miktar * euro / dolar;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Euro = " + sonuc.ToString() + " Dolar";
                }
                else if (comboBox1.Text == "Euro" && comboBox2.Text == "Sterlin")
                {
                    sonuc = miktar * euro / sterlin;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Euro = " + sonuc.ToString() + " Sterlin";
                }
                else if (comboBox1.Text == "Sterlin" && comboBox2.Text == "Dolar")
                {
                    sonuc = miktar * sterlin / dolar;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Sterlin = " + sonuc.ToString() + " Dolar";
                }
                else if (comboBox1.Text == "Sterlin" && comboBox2.Text == "Euro")
                {
                    sonuc = miktar * sterlin / euro;
                    sonuc = Math.Round(sonuc, 4);
                    sonucLabel.Text = miktar + " Sterlin = " + sonuc.ToString() + " Euro";
                }
                else
                {
                    sonucLabel.Text = "Hatalı İşlem!";
                }
            }
            else
            {
                sonucLabel.Text = "Miktarı Giriniz!";
            }
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            miktar = 0;
            miktarTextBox.Text = "";
            sonuc = 0;
            sonucLabel.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}