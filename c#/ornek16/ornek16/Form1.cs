using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek16
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
            int[] sayilar = new int[6];

            while (sayac < 6)
            {
                rastgele = r.Next(1, 50);

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
        }
    }
}
