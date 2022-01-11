using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();




            if (textBox1.Text == "" ) {
                MessageBox.Show("Boş Geçilemez.");
            }
            else {
                string metin = textBox1.Text;
                checkedListBox1.Items.Add(metin);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Liste Boş");

            }
            else if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                listBox1.Items.Clear();

                foreach (string chkditms in checkedListBox1.CheckedItems)
                {
                    listBox1.Items.Add(chkditms);
                }

            }

        }
    }
}
