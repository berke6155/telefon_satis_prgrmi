using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_satis_prgrmi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Siparişiniz Başarılı Şekilde Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Text = "Bilgileriniz Kaydedildi ";
                label8.Text = "Siparişiniz Onaylandı";
                
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Siparişiniz İptal Edilmiştir.";
            label7.Text = "Siparişiniz Onaylanmadı";
            {
                MessageBox.Show("Siparişiniz İptal Edilmiştir!!!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 16;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox5.Text))

            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Siparişiniz Başarılı Şekilde Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Text = "Bilgileriniz Kaydedilmedi";
                label8.Text = "Siparişiniz Onaylandı";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 goster = new Form1();
            goster.Show();
        }

       
    }
}
