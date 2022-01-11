using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public static bool artı;
        public static bool minus;
        public static bool multiply;
        public static bool divide;

        public Form1()
        {
            InitializeComponent();
            artı = false;
            minus = false;
            multiply = false;
            divide = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirinciSayi.Text))
            {
                MessageBox.Show("Lütfen Sayıları Giriniz...");
                return;
            }

            //double sayi1 = double.Parse(txtBirinciSayi.Text);
            //double sayi2 = double.Parse(txtIkinciSayi.Text);
            //txtSonuc.Text = sayi1 + sayi2+"";
            //globalVariables.artı = double.Parse(txtBirinciSayi.Text);
            artı = true;
            globalVariables.birinciSayi = double.Parse(txtBirinciSayi.Text);
            txtBirinciSayi.ResetText();


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirinciSayi.Text))
            {
                MessageBox.Show("Lütfen Sayıları Giriniz...");
                return;
            }
            minus = true;
            globalVariables.birinciSayi = double.Parse(txtBirinciSayi.Text);
            txtBirinciSayi.ResetText();
            //if (string.IsNullOrEmpty(txtBirinciSayi.Text) || string.IsNullOrEmpty(txtIkinciSayi.Text))
            //{
            //    MessageBox.Show("Lütfen Sayıları Giriniz...");
            //    return;
            //}

            //double sayi1 = double.Parse(txtBirinciSayi.Text);
            //double sayi2 = double.Parse(txtIkinciSayi.Text);
            //txtSonuc.Text = sayi1 - sayi2 + "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirinciSayi.Text))
            {
                MessageBox.Show("Lütfen Sayıları Giriniz...");
                return;
            }
            divide = true;
            globalVariables.birinciSayi = double.Parse(txtBirinciSayi.Text);
            txtBirinciSayi.ResetText();
            //if (string.IsNullOrEmpty(txtBirinciSayi.Text) || string.IsNullOrEmpty(txtIkinciSayi.Text))
            //{
            //    MessageBox.Show("Lütfen Sayıları Giriniz...");
            //    return;
            //}

            //double sayi1 = double.Parse(txtBirinciSayi.Text);
            //double sayi2 = double.Parse(txtIkinciSayi.Text);
            //txtSonuc.Text = sayi1 / sayi2 + "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirinciSayi.Text))
            {
                MessageBox.Show("Lütfen Sayıları Giriniz...");
                return;
            }
            multiply = true;
            globalVariables.birinciSayi = double.Parse(txtBirinciSayi.Text);
            txtBirinciSayi.ResetText();
            //if (string.IsNullOrEmpty(txtBirinciSayi.Text) || string.IsNullOrEmpty(txtIkinciSayi.Text))
            //{
            //    MessageBox.Show("Lütfen Sayıları Giriniz...");
            //    return;
            //}

            //double sayi1 = double.Parse(txtBirinciSayi.Text);
            //double sayi2 = double.Parse(txtIkinciSayi.Text);
            //txtSonuc.Text = sayi1 * sayi2 + "";
        }

        public void temizle()
        {
            txtBirinciSayi.ResetText();
            //txtIkinciSayi.ResetText();
            //txtSonuc.ResetText();
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(globalVariables.birinciSayi.ToString()) || string.IsNullOrEmpty(txtBirinciSayi.Text))
            {
                MessageBox.Show("lütfen sayıları giriniz...");
                return;
            }
            if (artı)
            {
                double sonuc;
                sonuc = globalVariables.birinciSayi + double.Parse(txtBirinciSayi.Text);
                txtBirinciSayi.Text = sonuc + "";
                artı = false;
            }
            if (minus)
            {
                double sonuc;
                sonuc = globalVariables.birinciSayi - double.Parse(txtBirinciSayi.Text);
                txtBirinciSayi.Text = sonuc + "";
                minus = false;
            }
            if (multiply)
            {
                double sonuc;
                sonuc = globalVariables.birinciSayi * double.Parse(txtBirinciSayi.Text);
                txtBirinciSayi.Text = sonuc + "";
                multiply = false;
            }
            if (divide)
            {
                double sonuc;
                sonuc = globalVariables.birinciSayi / double.Parse(txtBirinciSayi.Text);
                txtBirinciSayi.Text = sonuc + "";
                divide = false;
            }
        }

        #region boş
        private void txtBirinciSayi_TextChanged(object sender, EventArgs e)
        {
            //txtBirinciSayi.Text = "";
        }
        #endregion
        private void txtBirinciSayi_Click(object sender, EventArgs e)
        {
            txtBirinciSayi.ResetText();
        }
    }
}
