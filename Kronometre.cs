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
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;


        private void baslaButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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
            zamanLabel.Text="0:0:0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zamanLabel.Text = (saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString());
            saniye = saniye + 1;
            if ((saniye == 60))
            {
                saniye = 0;
                dakika = dakika + 1;
                if (dakika == 60)
                {
                    saniye = 0;
                    dakika = 0;
                    saat = saat + 1;
                }
            }
            
        }
    }
}
