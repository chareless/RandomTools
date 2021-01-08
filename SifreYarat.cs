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
    public partial class SifreYarat : Form
    {
        public SifreYarat()
        {
            InitializeComponent();
        }

        string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        int length;
        public string CreatePassword(int length)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void olusturButton_Click(object sender, EventArgs e)
        {
            if (uzunlukTextBox.Text != "")
            {
                if(Convert.ToInt32(uzunlukTextBox.Text)> 43679)
                {
                    uzunlukTextBox.Text = "43679";
                }
                length = Convert.ToInt32(uzunlukTextBox.Text);
            }
            valid = "";
            if(checkBox1.Checked==true|| checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true )
            {
                if (checkBox1.Checked == true)
                {
                    valid += "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ";
                }
                if (checkBox2.Checked == true)
                {
                    valid += "abcçdefghıijklmnoöpqrsştuüvwxyz";
                }
                if (checkBox3.Checked == true)
                {
                    valid += "0123456789";
                }
                if (checkBox4.Checked == true)
                {
                    valid += "!'^+-*/._?=}{][()&%½$#£é<>|~,``:";
                }
                sifreTextBox.Text = CreatePassword(length);
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
