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

        private void ustHesapla()
        {
            if(birTextBox1.Text!="" && birTextBox2.Text!="" && birTextBox1.Text != "," && birTextBox2.Text != ",")
            {
                float sonucUst = Convert.ToSingle(birTextBox1.Text) * Convert.ToSingle(birTextBox2.Text) / 100;
                sonucBir.Text = sonucUst.ToString();
            }
            else
            {
                sonucBir.Text = "";
            }
        }

        private void ortaHesapla()
        {
            if(ikiTextBox1.Text!="" && ikiTextBox2.Text!="" && ikiTextBox1.Text!="," && ikiTextBox2.Text!=",")
            {
                float sonucOrta = Convert.ToSingle(ikiTextBox2.Text) * 100 / Convert.ToSingle(ikiTextBox1.Text);
                sonucIki.Text = sonucOrta.ToString();
            }
            else
            {
                sonucIki.Text = "";
            }
        }

        private void altHesapla()
        {
            if (ucTextBox1.Text != "" && ucTextBox2.Text != "" && ucTextBox1.Text != "," && ucTextBox2.Text != ",")
            {
                float sonucAlt = Convert.ToSingle(ucTextBox1.Text) * 100 / Convert.ToSingle(ucTextBox2.Text);
                sonucUc.Text = sonucAlt.ToString();
            }
            else
            {
                sonucUc.Text = "";
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            ustHesapla();
            ortaHesapla();
            altHesapla();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            birTextBox1.Text = "";
            birTextBox2.Text = "";
            ikiTextBox1.Text = "";
            ikiTextBox2.Text = "";
            ucTextBox1.Text = "";
            ucTextBox2.Text = "";
            sonucBir.Text = "";
            sonucIki.Text = "";
            sonucUc.Text = "";
        }
    }
}
