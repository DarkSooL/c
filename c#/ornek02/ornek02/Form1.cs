using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cinsiyetinizi Seçiniz.")
            {
                MessageBox.Show("Cinsiyeti Seçiniz");
                comboBox1.Focus();
            }
            else if (txtBoy.Text == "")
            {
                MessageBox.Show("Boy'u Boş geçemezsin");
                txtBoy.Focus();
            }

            else if (txtKilo.Text == "")
            {
                MessageBox.Show("Kiloyu'i Boş Girdin");
                txtKilo.Focus();
            }
           
            else
            {
                double boy, kilo, vki;
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            vki = kilo / (boy * boy);
            label3.Text = vki.ToString();
                
                switch (comboBox1.Text)
                {
                    case "Erkek":
                        if (vki < 20.7)
                        {
                            textBox1.Text = "Zayıf. Düşüklük BMİ Değeri de risk oluşturur.";
                        }
                        else if (vki >= 20.7 && vki < 26.4)
                        {
                            textBox1.Text = "Normal Risk Yok";
                        }
                        else if (vki >= 26.5 && vki < 27.8)
                        {
                            textBox1.Text = "Şişmanlık Sınırında";
                        }
                        else if (vki >= 27.9 && vki < 31.1)
                        {
                            textBox1.Text = "Şişman Orta derece Riskli";
                        }
                        else if (vki >= 31.2 && vki < 45.4)
                        {
                            textBox1.Text = "Ciddi Derecede Şişmanlık";
                        }
                        else
                        {
                            textBox1.Text = "Öldürücü Şişmanlık. Çok Büyük Risk var";

                        }
                        break;

                    case "Kadın":
                        if (vki < 19.1)
                        {
                            textBox1.Text = "Zayıf. Düşüklük BMİ Değeri de risk oluşturur.";
                        }
                        else if (vki >= 19.1 && vki < 25.8)
                        {
                            textBox1.Text = "Normal Risk Yok";
                        }
                        else if (vki >= 25.9 && vki < 27.3)
                        {
                            textBox1.Text = "Şişmanlık Sınırında";
                        }
                        else if (vki >= 27.4 && vki < 32.2)
                        {
                            textBox1.Text = "Şişman Orta derece Riskli";
                        }
                        else if (vki >= 32.3 && vki < 44.8)
                        {
                            textBox1.Text = "Ciddi Derecede Şişmanlık";
                        }
                        else
                        {
                            textBox1.Text = "Öldürücü Şişmanlık. Çok Büyük Risk var";

                        }
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoy.Text = "";
            txtKilo.Text = "";
            comboBox1.Text = "";
            label3.Text = "";
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }
    }
}
