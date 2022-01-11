using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text="Süre Seçiniz";
            label3.Text = "0";

            listBox1.Items.Add("Bitir:" + DateTime.Now.ToLongTimeString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(textBox1.Text);
          
            label3.Text = textBox1.Text;
            int interval = Convert.ToInt32(comboBox1.Text);
            timer1.Interval = interval;
            timer1.Start();

            listBox1.Items.Add("Başla" + DateTime.Now.ToLongTimeString());
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kalanSure = Convert.ToInt32(label3.Text);
            if (kalanSure >= 1)
            {
                kalanSure -= 1;
            }
            label3.Text = Convert.ToString(kalanSure);
            if (kalanSure == 0)
            {
                listBox1.Items.Add("Bitti" + DateTime.Now.ToLongTimeString());
                timer1.Stop();
                MessageBox.Show("Dikkat", "Kalan Süre 0'a ulaşmıştır.");

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
