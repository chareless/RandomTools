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
    public partial class Kilo : Form
    {
        public Kilo()
        {
            InitializeComponent();
        }

        float bmi;
        float kilo;
        int ideal;
        int boy;
        double inc;
        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            if(kiloTextBox.Text!="" && boyTextBox.Text!="")
            {
                kilo = Convert.ToSingle(kiloTextBox.Text);
                boy = Convert.ToInt32(boyTextBox.Text);
                inc = boy / 2.54;
                bmi = kilo / (boy * boy)*10000;
                if (erkekRadioButton.Checked == true)
                {
                    ideal = Convert.ToInt32(50 + (2.3 * (inc - 60)));
                    idealLabel.Text = ideal.ToString() + " kg";
                    bmiLabel.Text = bmi.ToString();
                    hataLabel.Text = "";
                }
                else if (kadinRadioButton.Checked == true)
                {
                    ideal = Convert.ToInt32(45.5 + (2.3 * (inc - 60)));
                    idealLabel.Text = ideal.ToString() + " kg";
                    bmiLabel.Text = bmi.ToString();
                    hataLabel.Text = "";
                }
                else
                {
                    sonucLabel.Text = "";
                    idealLabel.Text = "";
                    bmiLabel.Text = "";
                    hataLabel.Text = "Lütfen tüm alanları doldurunuz.";
                }

                if(bmi<18.5)
                {
                    sonucLabel.Text = "İdeal kilonuzun altındasınız.";
                    sonucLabel.ForeColor = Color.DarkRed;
                }
                if(bmi>=18.5 && bmi<25)
                {
                    sonucLabel.Text = "Kilonuz normal.";
                    sonucLabel.ForeColor = Color.LimeGreen;
                }
                if(bmi>=25 && bmi<30)
                {
                    sonucLabel.Text = "İdeal kilonuzun üstündesiniz.";
                    sonucLabel.ForeColor = Color.DarkRed;
                }
                if (bmi >= 30)
                {
                    sonucLabel.Text = "Obez.";
                    sonucLabel.ForeColor = Color.DarkRed;
                }
            }
           
            else
            {
                sonucLabel.Text = "";
                idealLabel.Text = "";
                bmiLabel.Text = "";
                hataLabel.Text = "Lütfen tüm alanları doldurunuz.";
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
