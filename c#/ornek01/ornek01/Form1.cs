using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIlkEndeks.Text == ""){
                MessageBox.Show("İlk Endeks'i Boş Girdin");
                txtIlkEndeks.Focus();
            }

            else if (txtSonEndeks.Text == ""){
                MessageBox.Show("Son Endeks'i Boş Girdin");
                txtSonEndeks.Focus();
            }
            else if(Convert.ToInt32(txtIlkEndeks.Text) > Convert.ToInt32(txtSonEndeks.Text)){
                MessageBox.Show("İlk Endeks, Son Endeks'den büyük olamaz.");
                txtIlkEndeks.Focus();
            }
            else
            {
                int ilkEndeks;
                int sonEndeks;
                int miktar;
                double tutar = 0;
                double atikSu;
                double toplam;


                ilkEndeks = Convert.ToInt32(txtIlkEndeks.Text);
                sonEndeks = Convert.ToInt32(txtSonEndeks.Text);
                miktar = sonEndeks - ilkEndeks;

                switch (cmbAbone.Text)
                {
                    case "Konut":
                        tutar = miktar * 0.9;
                        break;
                    case "Ticari":
                        tutar = miktar * 1.1;
                        break;
                }

                lblMiktar.Text = Convert.ToString(miktar) + " m3";

                lblTutar.Text = Convert.ToString(tutar) + " TL";

                atikSu = tutar / 2;

                lblAtikSu.Text = Convert.ToString(atikSu) + " TL";

                toplam = miktar + tutar;

                lblToplamdeger.Text = Convert.ToDouble(toplam) + " TL";
            }

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtIlkEndeks_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void txtSonEndeks_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes){
                Application.Exit();
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            lblMiktar.Text = "...m3";

            lblTutar.Text = "...TL";

            lblAtikSu.Text = "...TL";

            lblToplamdeger.Text = "...TL";

            txtIlkEndeks.Text = "";
            txtSonEndeks.Text = "";
            cmbAbone.Text = "";

        }
    }
}
