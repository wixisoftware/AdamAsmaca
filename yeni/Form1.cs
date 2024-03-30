using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni
{
    public partial class Form1 : Form
    {
        string bulunmasınıİkelime = "";
        string[] _kelimeuzunluk;
        int hata = 0;
        string[] harfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResimYukle();
            groupBox1.Enabled = false;
            textBox_bul.MaxLength = 1;

        }
        
         
            private void KelimeYaz()
            {
                label_bulunacak_kelime.Text = "";

                foreach (var item in _kelimeuzunluk)
                {
                    label_bulunacak_kelime.Text = label_bulunacak_kelime.Text + item;
                }
            }

            private void sıfırla()
            {
                hata = 0;
                ResimYükle();
                label_bulunacak_kelime.Text ="";
                textBox_bulunmasını_istedigimiz_kelime.Text = "";
                bulunmasınıİkelime = "";
                groupBox1.Enabled = false;
                checkBox1.Enabled = true;
           
            }

            private void ResimYükle()
            {
                    pictureBox1.Image = Image.FromFile($"img/{hata}.png");
            }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            bulunmasınıİkelime = textBox_bulunmasını_istedigimiz_kelime.Text.Trim().ToUpper();

            _kelimeuzunluk = new string[bulunmasınıİkelime.Length];

            for (int i = 0; i < bulunmasınıİkelime.Length; i++)
            {
                _kelimeuzunluk[i] = "-";
            }

            KelimeYaz();

            button_basla.Enabled = false;
            textBox_bulunmasını_istedigimiz_kelime.Enabled = false;
            checkBox1.Enabled = false;

            this.Text = textBox_bulunmasını_istedigimiz_kelime.Text;

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox_bulunmasını_istedigimiz_kelime.PasswordChar = '\0';
            }
            else
            {
                textBox_bulunmasını_istedigimiz_kelime.PasswordChar = '*';
            }
        }

        private void button_kontrol_Click_1(object sender, EventArgs e)
        {

            bool varMi = false;
            bool soylendi = false;
           

           

                foreach (var item in label_tahmin.Text)
                {
                    if (Convert.ToChar(textBox_bul.Text) == item)
                    {
                        MessageBox.Show("Bu tahmini daha önce yaptınız!");
                        soylendi = true;
                        varMi = true;

                    }
                }

               

                    for (int j = 0; j < textBox_bulunmasını_istedigimiz_kelime.Text.Trim().ToUpper().Length; j++)
                    {
                        if (bulunmasınıİkelime[j].ToString() == textBox_bul.Text.ToUpper())
                        {
                            _kelimeuzunluk[j] = textBox_bul.Text;

                            varMi = true;
                        }


                    }
              
                    KelimeYaz();

                    if (varMi)
                    {

                        if (label_bulunacak_kelime.Text.IndexOf("-") == -1)
                        {
                            MessageBox.Show("Oyunu Kazandınız!");
                            sıfırla();
                             textBox_bulunmasını_istedigimiz_kelime.Enabled = true;
                              button_basla.Enabled = true;
                             label_tahmin.Text = "";
                             textBox_bul.Text = "";

                        }

                        yazılsın(soylendi);

                        textBox_bul.Text = "";
                    }
                    else
                    {
                        hata++;

                        ResimYukle();

                        if (hata == 7)
                        {
                            MessageBox.Show($"Kaybettiniz!\nDoğru Kelime : {textBox_bulunmasını_istedigimiz_kelime.Text}");
                            sıfırla();
                        }

                        yazılsın(soylendi);

                        textBox_bul.Text = "";
                    }






        }

        private void yazılsın(bool soylendi)
        {
            if (soylendi == false)
            {
                label_tahmin.Text = label_tahmin.Text + " " + textBox_bul.Text;
            }
        }

        private void ResimYukle()
        { 
            pictureBox1.Image = Image.FromFile($"img/{hata}.png");
        }

        private void textBox_bulunmasını_istedigimiz_kelime_TextChanged_1(object sender, EventArgs e)
        {
            //başlarken görülmemesi için
            if (checkBox1.Checked == false)
            {
                textBox_bulunmasını_istedigimiz_kelime.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
