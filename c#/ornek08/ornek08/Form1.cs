using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value < 5)
            {

                label1.Text = "Ses Seviyesi Düşük";
                label1.ForeColor = Color.Black;

            }
            else if (trackBar1.Value < 10)
            {

                label1.Text = "Ses Seviyesi Orta";
                label1.ForeColor = Color.Green;

            }
            else {
                label1.Text = "Ses Seviyesi Yüksek";
                label1.ForeColor = Color.Red;


            } 
                


        }
    }
}
