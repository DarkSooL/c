using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;
        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(1, 250);
            button1.Top = r.Next(1, 300);

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            puan += 10;
                
                label2.Text = Convert.ToString(puan);
           


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            puan -= 10;
            label2.Text = Convert.ToString(puan);

        }
    }
}
