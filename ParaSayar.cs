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
    public partial class ParaSayar : Form
    {
        public ParaSayar()
        {
            InitializeComponent();
        }

        int sonucTL;
        int sonucKrs;

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            if(textBox200t.Text == "")
            {
                textBox200t.Text = "0";
            }
            if (textBox100t.Text == "")
            {
                textBox100t.Text = "0";
            }
            if (textBox50t.Text == "")
            {
                textBox50t.Text = "0";
            }
            if (textBox20t.Text == "")
            {
                textBox20t.Text = "0";
            }
            if (textBox10t.Text == "")
            {
                textBox10t.Text = "0";
            }
            if (textBox5t.Text == "")
            {
                textBox5t.Text = "0";
            }
            if (textBox1t.Text == "")
            {
                textBox1t.Text = "0";
            }
            if (textBox50k.Text == "")
            {
                textBox50k.Text = "0";
            }
            if (textBox25k.Text == "")
            {
                textBox25k.Text = "0";
            }
            if (textBox10k.Text == "")
            {
                textBox10k.Text = "0";
            }
            if (textBox5k.Text == "")
            {
                textBox5k.Text = "0";
            }
            if (textBox1k.Text == "")
            {
                textBox1k.Text = "0";
            }
            sonucTL = Convert.ToInt32(textBox200t.Text) * 200 + Convert.ToInt32(textBox100t.Text) * 100 + Convert.ToInt32(textBox50t.Text) * 50 + Convert.ToInt32(textBox20t.Text) * 20 + Convert.ToInt32(textBox10t.Text) * 10 + Convert.ToInt32(textBox5t.Text) * 5 + Convert.ToInt32(textBox1t.Text) * 1;
            sonucKrs = Convert.ToInt32(textBox50k.Text) * 50 + Convert.ToInt32(textBox25k.Text) * 25 + Convert.ToInt32(textBox10k.Text) * 10 + Convert.ToInt32(textBox5k.Text) * 5 + Convert.ToInt32(textBox1k.Text) * 1;
            while (!(sonucKrs < 100))
            {
                sonucKrs -= 100;
                sonucTL += 1;
            }
            sonucTlTextBox.Text = sonucTL.ToString();
            sonucKrsTextBox.Text = sonucKrs.ToString();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
