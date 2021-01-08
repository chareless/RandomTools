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
    public partial class KuraÇek : Form
    {
        public KuraÇek()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        public static int sayi;
       
        private void kuraButton_Click(object sender, EventArgs e)
        {
            if(kisiTextBox.Text!= "")
            {
                string[] textBoxLines = katilimciRichTextBox.Lines;
                sayi = Convert.ToInt32(kisiTextBox.Text);
                int[] x = new int[sayi];
                if (sayi <= textBoxLines.Length && sayi !=0)
                {
                    for (int i = 0; i < sayi; i++)
                    {
                        x[i] = rand.Next(0, textBoxLines.Length);
                        for (int kontrol = 0; kontrol < i; kontrol++)
                        {
                            if (x[kontrol] == x[i])
                            {
                                i--;
                                break;
                            }
                        }

                    }
                    for (int i = 0; i < sayi; i++)
                    {
                        sonucRichTextBox.Text += textBoxLines[x[i]] + "\n";
                    }
                }
                else
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Hata!");
            }
            
            
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            sonucRichTextBox.Text = "";
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(kisiTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece Sayı Girin!");
                kisiTextBox.Text = kisiTextBox.Text.Remove(kisiTextBox.Text.Length - 1);
            }
        }
    }
}
