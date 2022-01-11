using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucuncuHafta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            if (globalDegiskenler.mesaj == "")
            {
                label2.Text = "Mesaj Boştur";
            }
            else
            {
                label2.Text = globalDegiskenler.mesaj;
            }

            txtGonderdenGelen.Text = globalDegiskenler.gonder;

        }
    }
}
