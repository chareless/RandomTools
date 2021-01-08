using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        float birinciSayi, ikinciSayi, sonuc;
        string islem;
        private void buttonTikla(object sender, EventArgs e)
        {
            if(ekranLabel.Text=="Hata.." || ekranLabel.Text == "Geçersiz İşlem")
            {
                ekranLabel.Text = "";
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = string.Empty;
                ekranLabel.Text += ((Button)sender).Text;
            }
            else
                ekranLabel.Text += ((Button)sender).Text;
        }
        private void artiButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "Hata.." && ekranLabel.Text != "Geçersiz İşlem")
            {
                birinciSayi = float.Parse(ekranLabel.Text);
                ekranLabel.Text = "0";
                islem = "+";
            }
        }
        private void eksiButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "Hata.." && ekranLabel.Text != "Geçersiz İşlem")
            {
                birinciSayi = float.Parse(ekranLabel.Text);
                ekranLabel.Text = "0";
                islem = "-";
            }
        }
        private void carpiButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "Hata.." && ekranLabel.Text != "Geçersiz İşlem")
            {
                birinciSayi = float.Parse(ekranLabel.Text);
                ekranLabel.Text = "0";
                islem = "x";
            }
        }
        private void boluButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "Hata.." && ekranLabel.Text != "Geçersiz İşlem")
            {
                birinciSayi = float.Parse(ekranLabel.Text);
                ekranLabel.Text = "0";
                islem = "/";
            }
        }
        private void esittirButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "Hata.." && ekranLabel.Text!="Geçersiz İşlem")
            {
                ikinciSayi = float.Parse(ekranLabel.Text);
            }
            switch (islem)
            {
                case "+":
                    sonuc = birinciSayi + ikinciSayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case "-":
                    sonuc = birinciSayi - ikinciSayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case "x":
                    sonuc = birinciSayi * ikinciSayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case "/":
                    if (ikinciSayi == 0)
                        ekranLabel.Text = "Geçersiz İşlem";
                    else
                    {
                        sonuc = birinciSayi / ikinciSayi;
                        ekranLabel.Text = Convert.ToString(sonuc);
                    }
                    break;
                default:
                    ekranLabel.Text = "Hata..";
                    break;
            }
        }
        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

    }
}
