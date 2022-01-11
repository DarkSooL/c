using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Focus();
            
           
            string metin = textBox1.Text;
            listBox1.Items.Add(metin);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Focus();
            
            int indeks;
           
            indeks= listBox1.SelectedIndex;
            listBox1.Items.Remove(indeks);
            
        }
    }
}
