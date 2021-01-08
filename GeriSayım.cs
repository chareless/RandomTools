using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class GeriSayım : Form
    {
        public GeriSayım()
        {
            InitializeComponent();
        }

        static int saat = 0, dakika = 0, saniye = 0;


        private void baslaButton_Click(object sender, EventArgs e)
        {
            char[] ayrac = new char[] { ':' };
            string[] zaman = zamanTextBox.Text.Split(ayrac, StringSplitOptions.RemoveEmptyEntries);
            if (zaman.Length == 3 )
            {
                saat = Convert.ToInt32(zaman[0]);
                dakika = Convert.ToInt32(zaman[1]);
                saniye = Convert.ToInt32(zaman[2]);
                if(saniye == 0 && dakika == 0 && saat == 0)
                {
                    timer1.Enabled = false;
                }
                else
                {
                    timer1.Enabled = true;
                }
              
            }
            else
            {
                MessageBox.Show("Lütfen Saat:Dakika:Saniye Biçiminde Giriniz.");
            }
        }

        private void durdurButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            saat = 0;
            dakika = 0;
            saniye = 0;
            zamanTextBox.Text = "0:0:0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zamanTextBox.Text = (saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString());
            saniye = saniye - 1;
            if ((saniye == -1))
            {
                if (saat == 0 && dakika == 0)
                {
                    zamanTextBox.Text = "0:0:0";
                    timer1.Stop();
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Süre Doldu.");
                }
                saniye = 59;
                dakika = dakika - 1;
                if (dakika == -1)
                {
                    saniye = 59;
                    dakika = 59;
                    saat = saat - 1;
                }
            }
        }
    }
}
