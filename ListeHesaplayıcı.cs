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
    public partial class ListeHesaplayıcı : Form
    {
        public ListeHesaplayıcı()
        {
            InitializeComponent();
            listView1.Columns.Add("No", 35);
            listView1.Columns.Add("Ürün", 125);
            listView1.Columns.Add("Fiyat", 125);
            listView1.Columns.Add("Adet", 125);
        }

        int sayac;
        double sonuc;

        private void urunButton_Click(object sender, EventArgs e)
        {
            if(urunTextBox.Text!="" && fiyatTextBox.Text!="" && adetTextBox.Text!="")
            {
                sonuc = 0;
                string[] satirlar;
                string hepsi = sayac+1 + " " +urunTextBox.Text + " " + fiyatTextBox.Text + " " + adetTextBox.Text;
                satirlar = hepsi.Split('\n');
                foreach (string s in satirlar)
                {
                    string[] kelimeler = s.Split(' ');
                    var listView1Item = new ListViewItem(kelimeler);
                    listView1.Items.Add(listView1Item);
                    sayac++;
                }
                for (int i = 0; i < sayac; i++)
                {
                    if ((listView1.Items[i].SubItems[2].Text) != "")
                        sonuc += Convert.ToDouble(listView1.Items[i].SubItems[2].Text)*(Convert.ToDouble(listView1.Items[i].SubItems[3].Text));
                }
                totalTextBox.Text = sonuc.ToString();
            }
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sayac = 0;
            sonuc = 0;
            totalTextBox.Text = sonuc.ToString();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txt_bosluk_giremez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void urunSilButton_Click(object sender, EventArgs e)
        {
            if (sayac != 0)
            {
                listView1.Items.Remove(listView1.Items[sayac - 1]);
                sayac--;
                sonuc = 0;
                for (int i = 0; i < sayac; i++)
                {
                    if ((listView1.Items[i].SubItems[2].Text) != "")
                        sonuc += Convert.ToDouble(listView1.Items[i].SubItems[2].Text) * (Convert.ToDouble(listView1.Items[i].SubItems[3].Text));
                }
                totalTextBox.Text = sonuc.ToString();
            }
        }

        private void seciliSilButton_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            for (int j = 0; j < sayac; j++)
            {
                if((listView1.Items[j].SubItems[0].Text)==noTextBox.Text)
                {
                    listView1.Items[Convert.ToInt32(noTextBox.Text)-1].SubItems[1].Text = "";
                    listView1.Items[Convert.ToInt32(noTextBox.Text)-1].SubItems[2].Text = "";
                    listView1.Items[Convert.ToInt32(noTextBox.Text)-1].SubItems[3].Text = "";
                    sonuc = 0;
                    kontrol = true;
                }
            }
            if(kontrol ==true)
            {
                for (int i = 0; i < sayac; i++)
                {
                    if ((listView1.Items[i].SubItems[2].Text) != "")
                        sonuc += Convert.ToDouble(listView1.Items[i].SubItems[2].Text) * (Convert.ToDouble(listView1.Items[i].SubItems[3].Text));
                }
                totalTextBox.Text = sonuc.ToString();
            }
        }
    }
}
