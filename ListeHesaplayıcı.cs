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
                string hepsi = urunTextBox.Text + " " + fiyatTextBox.Text + " " + adetTextBox.Text;
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
                    sonuc += Convert.ToDouble(listView1.Items[i].SubItems[1].Text)*(Convert.ToDouble(listView1.Items[i].SubItems[2].Text));
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
                    sonuc += Convert.ToDouble(listView1.Items[i].SubItems[1].Text) * (Convert.ToDouble(listView1.Items[i].SubItems[2].Text));
                }
                totalTextBox.Text = sonuc.ToString();
            }
        }
    }
}
