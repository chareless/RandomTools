using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class RastgeleNumara : Form
    {
        public RastgeleNumara()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        public static int sonuc;
        private void uretButton_Click(object sender, EventArgs e)
        {
            int decimalValue;
            bool success1 = Int32.TryParse(xTextBox.Text, out decimalValue);
            bool success2 = Int32.TryParse(yTextBox.Text, out decimalValue);
            if (success1 && success2)
            {
                RastgeleAraçlar.sayi = Convert.ToInt32(xTextBox.Text);
                RastgeleAraçlar.sayi2 = Convert.ToInt32(yTextBox.Text);
                if (RastgeleAraçlar.sayi + 1 < RastgeleAraçlar.sayi2)
                {
                    sonuc = rand.Next(RastgeleAraçlar.sayi, RastgeleAraçlar.sayi2);
                    MessageBox.Show(sonuc.ToString());
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
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(xTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece Sayı Girin!");
                xTextBox.Text = xTextBox.Text.Remove(xTextBox.Text.Length - 1);
            }
        }
    }
}
