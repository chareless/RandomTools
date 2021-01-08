using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeGames
{
    public partial class Hatırlatıcı : Form
    {
        public Hatırlatıcı()
        {
            InitializeComponent();
        }
        string sonuc;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saatTextBox.Text == label6.Text && dateTimePicker1.Text == dateTimePicker2.Text)
            {
                timer1.Stop();
                SystemSounds.Hand.Play();
                MessageBox.Show("Alarm : " + mesajTextBox.Text.ToString());
            }
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime zaman;
            zaman = DateTime.Now;
            MessageBox.Show("Alarm Kuruldu : " + mesajTextBox.Text.ToString());
        }

        private void Hatırlatıcı_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sonuc = string.Format("{0:HH:mm:ss}", DateTime.Now);
            label6.Text = sonuc.ToString();
        }
    }
}
