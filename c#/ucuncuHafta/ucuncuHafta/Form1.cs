using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucuncuHafta
{
    public partial class Form1 : Form
    {
        string fileContent = "";
        string filePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();
                //MessageBox.Show("" + filePath);
                
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                richTextBox1.Text = fileContent;

            }

            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            globalDegiskenler.mesaj = fileContent;
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void gönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalDegiskenler.gonder = txtGonder.Text;
            Form2 fr = new Form2();
            fr.ShowDialog();
        }
    }
}
