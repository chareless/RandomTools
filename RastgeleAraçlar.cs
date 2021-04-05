using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class RastgeleAraçlar : Form
    {
        public RastgeleAraçlar()
        {
            InitializeComponent();

            surumLabel.Text = guncelSurum;
            InternetKontrol();
        }

        public static string guncelSurum = "8.1";

        private void InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                netLabel.Text = "Bağlantı Mevcut";
                netLabel.ForeColor = Color.LimeGreen;
                updateToolStripButton.Enabled = true;
                kurButton.Enabled = true;
                ipButton.Enabled = true;
                koronaButton.Enabled = true;
                kurCevirButton.Enabled = true;
            }
            catch (Exception e)
            {
                netLabel.Text = "Bağlantı Yok";
                netLabel.ForeColor = Color.DarkRed;
                updateToolStripButton.Enabled = false;
                kurButton.Enabled = false;
                ipButton.Enabled = false;
                koronaButton.Enabled = false;
                kurCevirButton.Enabled = false;
            }
        }

        Random rand = new Random();
        public static int sayi;
        public static int sayi2;
        private void yazıTuraButton_Click(object sender, EventArgs e)
        {
            sayi = rand.Next(0, 2);
            if (sayi == 0)
            {
                MessageBox.Show("YAZI");
            }
            if (sayi == 1)
            {
                MessageBox.Show("TURA");
            }
        }

        private void tkmButton_Click(object sender, EventArgs e)
        {
            sayi = rand.Next(0, 3);
            if (sayi == 0)
            {
                MessageBox.Show("TAŞ");
            }
            if (sayi == 1)
            {
                MessageBox.Show("KAĞIT");
            }
            if (sayi == 2)
            {
                MessageBox.Show("MAKAS");
            }
        }

        private void zarAtButton_Click(object sender, EventArgs e)
        {
            string zarGirisi = Interaction.InputBox("Kaç Tane Zar Atılacak?", "Zar At","1 veya 2", 600, 300);
            if(zarGirisi == "1" || zarGirisi == "2")
            {
                if (Convert.ToInt32(zarGirisi) == 1)
                {
                    sayi = rand.Next(1, 7);
                    MessageBox.Show(sayi.ToString());
                }
                else if (Convert.ToInt32(zarGirisi) == 2)
                {
                    sayi = rand.Next(1, 7);
                    sayi2 = rand.Next(1, 7);
                    MessageBox.Show(sayi.ToString() + " ve " + sayi2.ToString());
                }
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }
        private void rastgeleNumaraButton_Click(object sender, EventArgs e)
        {
            RastgeleNumara f2 = new RastgeleNumara();
            f2.Show();
        }
        private void kuraButton_Click(object sender, EventArgs e)
        {
            KuraÇek f3 = new KuraÇek();
            f3.Show();
        }
        private void kronometreButton_Click(object sender, EventArgs e)
        {
            Kronometre f4 = new Kronometre();
            f4.Show();
        }
        private void hatirlaticiButton_Click(object sender, EventArgs e)
        {
            Hatırlatıcı f5 = new Hatırlatıcı();
            f5.Show();
        }
        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            About f6 = new About();
            f6.Show();
        }
        private void hesapMakinesiButton_Click(object sender, EventArgs e)
        {
            HesapMakinesi f7 = new HesapMakinesi();
            f7.Show();
        }
        private void paraSayButton_Click(object sender, EventArgs e)
        {
            ParaSayar f8 = new ParaSayar();
            f8.Show();
        }
        private void listeHesaplaButton_Click(object sender, EventArgs e)
        {
            ListeHesaplayıcı f9 = new ListeHesaplayıcı();
            f9.Show();
        }
        private void notButton_Click(object sender, EventArgs e)
        {
            Not f10 = new Not();
            f10.Show();
        }
        private void sifreYaratButton_Click(object sender, EventArgs e)
        {
            SifreYarat f11 = new SifreYarat();
            f11.Show();
        }
        private void kurButton_Click(object sender, EventArgs e)
        {
            Kur f12 = new Kur();
            f12.Show();
        }
        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            Update f13 = new Update();
            f13.Show();
        }
        private void koronaButton_Click(object sender, EventArgs e)
        {
            Korona f14 = new Korona();
            f14.Show();
        }
        private void ipButton_Click(object sender, EventArgs e)
        {
            Ip f15 = new Ip();
            f15.Show();
        }
        private void geriSayimButton_Click(object sender, EventArgs e)
        {
            GeriSayım f16 = new GeriSayım();
            f16.Show();
        }
        private void kitleButton_Click(object sender, EventArgs e)
        {
            Kilo f17 = new Kilo();
            f17.Show();
        }
        private void aritmetikButton_Click(object sender, EventArgs e)
        {
            Aritmetik f18 = new Aritmetik();
            f18.Show();
        }
        private void yuzdelikButton_Click(object sender, EventArgs e)
        {
            Yuzde f19 = new Yuzde();
            f19.Show();
        }
        private void kurCevirButton_Click(object sender, EventArgs e)
        {
            KurCevir f20 = new KurCevir();
            f20.Show();
        }
        private void zamanCevirButton_Click(object sender, EventArgs e)
        {
            ZamanCevir f21 = new ZamanCevir();
            f21.Show();
        }


        private void reportToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/#contact"); 
        }
        private void surumToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/randomtools.html#version");
        }
    }
}