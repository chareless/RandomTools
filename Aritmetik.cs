using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class Aritmetik : Form
    {
        public Aritmetik()
        {
            InitializeComponent();
        }
        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            var sayilar = islemTextBox.Text.Split("/*-+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var isaretler = Regex.Split(islemTextBox.Text, @"\d", RegexOptions.None).Where(p => p != "").ToArray<string>();
            List<string> sayi = new List<string>();
            foreach (string num in sayilar)
            {
                sayi.Add(num);
            }
            List<string> islem = new List<string>();
            foreach (string isaret in isaretler)
            {
                islem.Add(isaret);
            }
            double deger = 0;
            for (int i = 0; i < islem.Count; i++)
            {
                switch (islem[i])
                {
                    case "*":
                        if (i + 1 < sayi.Count)
                        {
                            deger = Convert.ToDouble(sayi[i]) * Convert.ToDouble(sayi[i + 1]);
                            sayi[i] = Convert.ToString(deger);
                            sayi.RemoveAt(i + 1);
                            islem.Remove("*");
                            i = -1;
                        }
                        break;
                    case "/":
                        if (i + 1 < sayi.Count)
                        {
                            deger = Convert.ToDouble(sayi[i]) / Convert.ToDouble(sayi[i + 1]);
                            sayi[i] = Convert.ToString(deger);
                            sayi.RemoveAt(i + 1);
                            islem.Remove("/");
                            i = -1;
                        }
                        break;
                }
            }
            for (int i = 0; i < islem.Count; i++)
            {
                switch (islem[i])
                {
                    case "+":
                        if (i + 1 < sayi.Count)
                        {
                            deger = Convert.ToDouble(sayi[i]) + Convert.ToDouble(sayi[i + 1]);
                            sayi[i] = Convert.ToString(deger);
                            sayi.RemoveAt(i + 1);
                            islem.Remove("+");
                            i = -1;
                        }
                        break;
                    case "-":
                        if (i + 1 < sayi.Count)
                        {
                            deger = Convert.ToDouble(sayi[i]) - Convert.ToDouble(sayi[i + 1]);
                            sayi[i] = Convert.ToString(deger);
                            sayi.RemoveAt(i + 1);
                            islem.Remove("-");
                            i = -1;
                        }
                        break;
                }
            }
            if (islemTextBox.Text == "" || islemTextBox.Text == "/" || islemTextBox.Text == "*" || islemTextBox.Text == "+" || islemTextBox.Text == "-")
            {
                sonucTextBox.Text = "İşlem Giriniz";
            }
            else
                sonucTextBox.Text = sayi[0];
        }

        private void islemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != '*' && e.KeyChar != '-' && e.KeyChar != '+';
        }
    }
}