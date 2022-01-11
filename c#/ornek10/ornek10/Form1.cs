using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float toplamFiyat=5;
        float toplam;
        string isim, telefon, adres;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            isim = txtAdSoyad.Text;
            telefon = txtTelefon.Text;
            adres = txtAdres.Text;
            hesapla();
            label8.Text = "SAyın" + isim + "Siparişiniz tutarı:" + toplam;
        }
        public void hesapla() {

            toplam = (float)nCorba.Value * toplamFiyat + (float)nSalata.Value * toplamFiyat + (float)nYemek.Value * toplamFiyat + (float)nTatli.Value * toplamFiyat;


        }
    }
}
