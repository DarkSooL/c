using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgele;
            int sayac = 0;
            int[] sayilar = new int[22];
            int[] gsayilar = new int[10];                
            



            while (sayac < 22)
            {
                rastgele = r.Next(1, 80);

                if (Array.IndexOf(sayilar, rastgele) == -1)
                {
                    sayilar[sayac] = rastgele;
                    sayac++;
                }
            }
            Array.Sort(sayilar);
            label1.Text = sayilar[0].ToString();
            label2.Text = sayilar[1].ToString();
            label3.Text = sayilar[2].ToString();
            label4.Text = sayilar[3].ToString();
            label5.Text = sayilar[4].ToString();
            label6.Text = sayilar[5].ToString();
            label7.Text = sayilar[6].ToString();
            label8.Text = sayilar[7].ToString();
            label9.Text = sayilar[8].ToString();
            label10.Text = sayilar[9].ToString();
            label11.Text = sayilar[10].ToString();
            label12.Text = sayilar[11].ToString();
            label13.Text = sayilar[12].ToString();
            label14.Text = sayilar[13].ToString();
            label15.Text = sayilar[14].ToString();
            label16.Text = sayilar[15].ToString();
            label17.Text = sayilar[16].ToString();
            label18.Text = sayilar[17].ToString();
            label19.Text = sayilar[18].ToString();
            label20.Text = sayilar[19].ToString();
            label21.Text = sayilar[20].ToString();
            label22.Text = sayilar[21].ToString();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 1;
            numericUpDown6.Value = 1;
            numericUpDown7.Value = 1;
            numericUpDown8.Value = 1;
            numericUpDown9.Value = 1;
            numericUpDown10.Value = 1;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";






        }
    }
}
