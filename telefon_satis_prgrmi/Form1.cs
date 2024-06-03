using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_satis_prgrmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if(checkBox1.Checked)
                {
                listBox1.Items.Add(checkBox1.Text + "" + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();

            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text + "" + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text + "" + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();

            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text + "" + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(checkBox3.Text + "" + label3.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();

            }
            else
            {
                listBox1.Items.Remove(checkBox3.Text + "" + label3.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(checkBox4.Text + "" + label4.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();

            }
            else
            {
                listBox1.Items.Remove(checkBox4.Text + "" + label4.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox5.Checked)
            {
                listBox1.Items.Add(checkBox5.Text + "" + label5.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label5.Text);
                textBox1.Text = toplam.ToString();

            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text + "" + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double kdv, toplam, maliyet;
            toplam = Convert.ToInt32(textBox1.Text);
            kdv = toplam / 100 * 30;
            maliyet = toplam - kdv;
            richTextBox1.Text = "MALİYET=" + maliyet + "\n";
            richTextBox1.Text += "KDV=" + kdv + "\n";
            richTextBox1.Text += "___________________________________\n\n";
            richTextBox1.Text += "ÖDENECEK TUTAR=" + toplam;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 goster = new Form2();
            goster.Show();
        }

        
    }
}
