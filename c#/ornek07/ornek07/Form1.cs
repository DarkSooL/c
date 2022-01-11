using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DateTime ayar;

        private void Form1_Load(object sender, EventArgs e)
        {
            

            numericUpDown1.Value = DateTime.Now.Day;
            numericUpDown2.Value = DateTime.Now.Month;
            numericUpDown3.Value = DateTime.Now.Year;

            numericUpDown6.Value = DateTime.Now.Hour;
            numericUpDown5.Value = DateTime.Now.Minute;




        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime an = DateTime.Now;

            MessageBox.Show(ayar.ToString()+"-----"+an.ToString()+"="+DateTime.Compare(ayar,an));
            if (ayar.ToString().Equals( an.ToString())) {

                MessageBox.Show("Süre Doldu");
              


            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            string tarih;
            string saat;


            
            tarih = numericUpDown1.Value + "/" + numericUpDown2.Value + "/" + numericUpDown3.Value;
            saat = numericUpDown6.Value + ":" + numericUpDown5.Value+":0";

           

            ayar = Convert.ToDateTime(tarih +" "+ saat);

           
            

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
