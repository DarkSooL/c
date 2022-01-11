using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox1.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (comboBox1.Text == "Normal") {

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            }
            else if (comboBox1.Text == "Ortala"){
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            }
            else if (comboBox1.Text == "Sığdır")
            {
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            }
            else if (comboBox1.Text == "Otamatik")
            {
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;


            }
        }
    }
}
