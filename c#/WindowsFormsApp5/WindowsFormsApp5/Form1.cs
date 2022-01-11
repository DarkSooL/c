using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtSaniye_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnBasla_Click(object sender, EventArgs e)
		{
			int saniye = Convert.ToInt32(txtSaniye.Text);

			lblKalanSure.Text = txtSaniye.Text;

			int interval = Convert.ToInt32(cmbHizSecme.Text);
			timer1.Interval = interval;
			timer1.Start();

			listBox1.Items.Add("Başla " + DateTime.Now.ToLongTimeString());
		}

		private void btnDur_Click(object sender, EventArgs e)
		{
			txtSaniye.Clear();
			cmbHizSecme.Text = "Hız Seçin";
			lblKalanSure.Text = "0";

			listBox1.Items.Add("Dur " + DateTime.Now.ToLongTimeString());
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lblKalanSure_Click(object sender, EventArgs e)
		{

		}

		private void cmbHizSecme_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int kalanSure = Convert.ToInt32(lblKalanSure.Text);
			if (kalanSure >= 1) {
				kalanSure -= 1;
			}
			if (kalanSure == 0) {
				timer1.Stop();
				MessageBox.Show("Dikkat", "Kalan Süre 0'a ulaşmıştır.");
			}
			
			lblKalanSure.Text = Convert.ToString(kalanSure);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
