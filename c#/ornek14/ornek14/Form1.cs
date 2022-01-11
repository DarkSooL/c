using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;

            if (label4.Text == "0")
            {
                MessageBox.Show("Lütfen Para koyunuz.");
            }
            else {


                int zar1 = r.Next(1, 5);
                int zar2 = r.Next(1, 5);
                int zar3 = r.Next(1, 5);
                int zar4 = r.Next(1, 5);

                int toplam;
                int toplam2;
                int oyuncu1;
                int oyuncu2;
                int tutar;


                toplam = zar1 + zar2;
                toplam2 = zar3 + zar4;


                pictureBox1.Image = ımageList1.Images[zar1];
                pictureBox2.Image = ımageList1.Images[zar2];
                pictureBox3.Image = ımageList1.Images[zar3];
                pictureBox4.Image = ımageList1.Images[zar4];

                oyuncu1 = Convert.ToInt32(label7.Text);
                oyuncu2 = Convert.ToInt32(label8.Text);
                tutar = Convert.ToInt32(label4.Text);



                if (toplam > toplam2)
                {

                    label7.Text = Convert.ToString(oyuncu1 + tutar);
                    label7.Text = Convert.ToString(oyuncu1 - tutar);

                }
                else if (toplam2 > toplam)
                {
                    label8.Text = Convert.ToString(oyuncu2 + tutar);

                }
                else if (toplam2 == toplam)
                {
                    MessageBox.Show("Durum Berabere Para Geri Dağıltıldı");
                }

                label4.Text = "0";
                textBox1.Text = "";


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int paraekle;

            paraekle = Convert.ToInt32(textBox1.Text);


            if (paraekle > 10000)
            {
                MessageBox.Show("10000 Den fazla Bakiye Ekleyemezsiniz.");
            }
            else {
                label4.Text = Convert.ToString(paraekle * 2);

                label7.Text = Convert.ToString(10000 - paraekle);
                label8.Text = Convert.ToString(10000 - paraekle);
            }

        }
    }
}
