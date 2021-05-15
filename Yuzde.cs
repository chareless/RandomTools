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
    public partial class Yuzde : Form
    {
        public Yuzde()
        {
            InitializeComponent();
        }

        private void birHesapla()
        {
            if(birTextBox1.Text!="" && birTextBox2.Text!="" && birTextBox1.Text != "," && birTextBox2.Text != ",")
            {
                float birSonuc = Convert.ToSingle(birTextBox1.Text) * Convert.ToSingle(birTextBox2.Text) / 100;
                sonucBir.Text = birSonuc.ToString();
            }
            else
            {
                sonucBir.Text = "";
            }
        }

        private void ikiHesapla()
        {
            if(ikiTextBox1.Text!="" && ikiTextBox2.Text!="" && ikiTextBox1.Text!="," && ikiTextBox2.Text!=",")
            {
                float ikiSonuc = Convert.ToSingle(ikiTextBox2.Text) * 100 / Convert.ToSingle(ikiTextBox1.Text);
                sonucIki.Text = ikiSonuc.ToString();
            }
            else
            {
                sonucIki.Text = "";
            }
        }

        private void ucHesapla()
        {
            if (ucTextBox1.Text != "" && ucTextBox2.Text != "" && ucTextBox1.Text != "," && ucTextBox2.Text != ",")
            {
                float ucSonuc = Convert.ToSingle(ucTextBox1.Text) * 100 / Convert.ToSingle(ucTextBox2.Text);
                sonucUc.Text = ucSonuc.ToString();
            }
            else
            {
                sonucUc.Text = "";
            }
        }

        private void dortHesapla()
        {
            if (dortTextBox1.Text != "" && dortTextBox2.Text != "" && dortTextBox1.Text != "," && dortTextBox2.Text != ",")
            {
                float dortSonuc = Convert.ToSingle(dortTextBox1.Text) + (Convert.ToSingle(dortTextBox1.Text)*Convert.ToSingle(dortTextBox2.Text)/100);
                sonucDort.Text = dortSonuc.ToString();
            }
            else
            {
                sonucDort.Text = "";
            }
        }

        private void besHesapla()
        {
            if (besTextBox1.Text != "" && besTextBox2.Text != "" && besTextBox1.Text != "," && besTextBox2.Text != ",")
            {
                float besSonuc = Convert.ToSingle(besTextBox1.Text) - (Convert.ToSingle(besTextBox1.Text) * Convert.ToSingle(besTextBox2.Text) / 100);
                sonucBes.Text = besSonuc.ToString();
            }
            else
            {
                sonucBes.Text = "";
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            birHesapla();
            ikiHesapla();
            ucHesapla();
            dortHesapla();
            besHesapla();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            birTextBox1.Text = "";
            birTextBox2.Text = "";
            ikiTextBox1.Text = "";
            ikiTextBox2.Text = "";
            ucTextBox1.Text = "";
            ucTextBox2.Text = "";
            dortTextBox1.Text = "";
            dortTextBox2.Text = "";
            besTextBox1.Text = "";
            besTextBox2.Text = "";
            sonucBir.Text = "";
            sonucIki.Text = "";
            sonucUc.Text = "";
            sonucDort.Text = "";
            sonucBes.Text = "";
        }
    }
}
