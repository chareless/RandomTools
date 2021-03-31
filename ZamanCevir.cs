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
    public partial class ZamanCevir : Form
    {
        public ZamanCevir()
        {
            InitializeComponent();

            bosText();
        }

        private void bosText()
        {
            zamanTextBox.Text = "";
            saniyeLabel.Text = "";
            dakikaLabel.Text = "";
            saatLabel.Text = "";
            günLabel.Text = "";
            ayLabel.Text = "";
            yılLabel.Text = "";
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            bosText();
            comboBox1.SelectedIndex = -1;
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            if (zamanTextBox.Text != "")
            {
                float zaman = Convert.ToSingle(zamanTextBox.Text);
                if (comboBox1.Text == "Saniye")
                {
                    saniyeLabel.Text = zaman.ToString() + " Saniye";
                    dakikaLabel.Text = (zaman / 60).ToString() + " Dakika";
                    saatLabel.Text = (zaman / 3600).ToString() + " Saat";
                    günLabel.Text = (zaman / 86400).ToString() + " Gün";
                    ayLabel.Text = (zaman / 2592000).ToString() + " Ay";
                    yılLabel.Text = (zaman / 3153600).ToString() + " Yıl";
                }
                else if (comboBox1.Text == "Dakika")
                {
                     saniyeLabel.Text = (zaman * 60).ToString() + " Saniye";
                     dakikaLabel.Text = zaman.ToString() + " Dakika";
                     saatLabel.Text = (zaman / 60).ToString() + " Saat";
                     günLabel.Text = (zaman / 1440).ToString() + " Gün";
                     ayLabel.Text = (zaman / 43200).ToString() + " Ay";
                     yılLabel.Text = (zaman / 525600).ToString() + " Yıl";
                }
                else if (comboBox1.Text == "Saat")
                {
                     saniyeLabel.Text = (zaman * 3600).ToString() + " Saniye";
                     dakikaLabel.Text = (zaman * 60).ToString() + " Dakika";
                     saatLabel.Text = zaman.ToString() + " Saat";
                     günLabel.Text = (zaman / 24).ToString() + " Gün";
                     ayLabel.Text = (zaman / 720).ToString() + " Ay";
                     yılLabel.Text = (zaman / 8760).ToString() + " Yıl";
                }
                else if (comboBox1.Text == "Gün")
                {
                     saniyeLabel.Text = (zaman * 86400).ToString() + " Saniye";
                     dakikaLabel.Text = (zaman * 1440).ToString() + " Dakika";
                     saatLabel.Text = (zaman * 24).ToString() + " Saat";
                     günLabel.Text = zaman.ToString() + " Gün";
                     ayLabel.Text = (zaman / 30).ToString() + " Ay";
                     yılLabel.Text = (zaman / 365).ToString() + " Yıl";
                }
                else if (comboBox1.Text == "Ay")
                {
                    saniyeLabel.Text = (zaman * 2592000).ToString() + " Saniye";
                    dakikaLabel.Text = (zaman * 43200).ToString() + " Dakika";
                    saatLabel.Text = (zaman * 720).ToString() + " Saat";
                    günLabel.Text = (zaman * 30).ToString() + " Gün";
                    ayLabel.Text = zaman.ToString() + " Ay";
                    yılLabel.Text = (zaman / 365 * 30).ToString() + " Yıl";
                }
                else if (comboBox1.Text == "Yıl")
                {
                    saniyeLabel.Text = (zaman * 31536000).ToString() + " Saniye";
                    dakikaLabel.Text = (zaman * 525600).ToString() + " Dakika";
                    saatLabel.Text = (zaman * 8760).ToString() + " Saat";
                    günLabel.Text = (zaman * 365).ToString() + " Gün";
                    ayLabel.Text = (zaman / 30 * 365).ToString() + " Ay";
                    yılLabel.Text = zaman.ToString() + " Yıl";
                }
                else
                {
                    saniyeLabel.Text = "Birim Seçiniz!";
                    dakikaLabel.Text = "Birim Seçiniz!";
                    saatLabel.Text = "Birim Seçiniz!";
                    günLabel.Text = "Birim Seçiniz!";
                    ayLabel.Text = "Birim Seçiniz!";
                    yılLabel.Text = "Birim Seçiniz!";
                }
            }
            else
            {
                saniyeLabel.Text = "Zamanı Giriniz!";
                dakikaLabel.Text = "Zamanı Giriniz!";
                saatLabel.Text = "Zamanı Giriniz!";
                günLabel.Text = "Zamanı Giriniz!";
                ayLabel.Text = "Zamanı Giriniz!";
                yılLabel.Text = "Zamanı Giriniz!";
            } 
        }
    }
}
