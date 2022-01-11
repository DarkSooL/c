using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hesapla() {

            double tutar;

            tutar = Convert.ToDouble(textBox1.Text);
            if (checkBox1.Checked) {
                tutar += tutar * 0.18;
            
            }
            if (checkBox2.Checked) {
                tutar += tutar * 0.25;
            }
            if (checkBox3.Checked)
            {
                tutar += 22;
            }
            textBox2.Text = Convert.ToString(tutar);
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
           }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }
    }
    }

