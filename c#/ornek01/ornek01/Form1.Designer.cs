
namespace ornek01
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAbone = new System.Windows.Forms.ComboBox();
            this.txtSonEndeks = new System.Windows.Forms.TextBox();
            this.txtIlkEndeks = new System.Windows.Forms.TextBox();
            this.lblSayacTip = new System.Windows.Forms.Label();
            this.lblSonEndeks = new System.Windows.Forms.Label();
            this.lblIlkEndeks = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamdeger = new System.Windows.Forms.Label();
            this.lblAtikSu = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblAtiksuBedeli = new System.Windows.Forms.Label();
            this.lbltuketimTutari = new System.Windows.Forms.Label();
            this.lblTuketimMiktari = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAbone);
            this.groupBox1.Controls.Add(this.txtSonEndeks);
            this.groupBox1.Controls.Add(this.txtIlkEndeks);
            this.groupBox1.Controls.Add(this.lblSayacTip);
            this.groupBox1.Controls.Add(this.lblSonEndeks);
            this.groupBox1.Controls.Add(this.lblIlkEndeks);
            this.groupBox1.Location = new System.Drawing.Point(38, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Girdiler";
            // 
            // cmbAbone
            // 
            this.cmbAbone.FormattingEnabled = true;
            this.cmbAbone.Items.AddRange(new object[] {
            "Konut",
            "Ticari"});
            this.cmbAbone.Location = new System.Drawing.Point(79, 113);
            this.cmbAbone.Name = "cmbAbone";
            this.cmbAbone.Size = new System.Drawing.Size(121, 21);
            this.cmbAbone.TabIndex = 6;
            this.cmbAbone.Text = "Abone Türü";
            // 
            // txtSonEndeks
            // 
            this.txtSonEndeks.Location = new System.Drawing.Point(84, 56);
            this.txtSonEndeks.Name = "txtSonEndeks";
            this.txtSonEndeks.Size = new System.Drawing.Size(116, 20);
            this.txtSonEndeks.TabIndex = 5;
            this.txtSonEndeks.TextChanged += new System.EventHandler(this.txtSonEndeks_TextChanged);
            // 
            // txtIlkEndeks
            // 
            this.txtIlkEndeks.Location = new System.Drawing.Point(84, 28);
            this.txtIlkEndeks.Name = "txtIlkEndeks";
            this.txtIlkEndeks.Size = new System.Drawing.Size(116, 20);
            this.txtIlkEndeks.TabIndex = 4;
            this.txtIlkEndeks.TextChanged += new System.EventHandler(this.txtIlkEndeks_TextChanged);
            // 
            // lblSayacTip
            // 
            this.lblSayacTip.AutoSize = true;
            this.lblSayacTip.Location = new System.Drawing.Point(7, 116);
            this.lblSayacTip.Name = "lblSayacTip";
            this.lblSayacTip.Size = new System.Drawing.Size(66, 13);
            this.lblSayacTip.TabIndex = 3;
            this.lblSayacTip.Text = "Abone Türü:";
            // 
            // lblSonEndeks
            // 
            this.lblSonEndeks.AutoSize = true;
            this.lblSonEndeks.Location = new System.Drawing.Point(7, 63);
            this.lblSonEndeks.Name = "lblSonEndeks";
            this.lblSonEndeks.Size = new System.Drawing.Size(62, 13);
            this.lblSonEndeks.TabIndex = 1;
            this.lblSonEndeks.Text = "Son Endex:";
            // 
            // lblIlkEndeks
            // 
            this.lblIlkEndeks.AutoSize = true;
            this.lblIlkEndeks.Location = new System.Drawing.Point(7, 28);
            this.lblIlkEndeks.Name = "lblIlkEndeks";
            this.lblIlkEndeks.Size = new System.Drawing.Size(54, 13);
            this.lblIlkEndeks.TabIndex = 2;
            this.lblIlkEndeks.Text = "Ilk Endex:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(198, 244);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "&Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamdeger);
            this.groupBox2.Controls.Add(this.lblAtikSu);
            this.groupBox2.Controls.Add(this.lblTutar);
            this.groupBox2.Controls.Add(this.lblMiktar);
            this.groupBox2.Controls.Add(this.lblToplam);
            this.groupBox2.Controls.Add(this.lblAtiksuBedeli);
            this.groupBox2.Controls.Add(this.lbltuketimTutari);
            this.groupBox2.Controls.Add(this.lblTuketimMiktari);
            this.groupBox2.Location = new System.Drawing.Point(308, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ücretler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblToplamdeger
            // 
            this.lblToplamdeger.AutoSize = true;
            this.lblToplamdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamdeger.Location = new System.Drawing.Point(139, 132);
            this.lblToplamdeger.Name = "lblToplamdeger";
            this.lblToplamdeger.Size = new System.Drawing.Size(34, 13);
            this.lblToplamdeger.TabIndex = 7;
            this.lblToplamdeger.Text = "...TL";
            // 
            // lblAtikSu
            // 
            this.lblAtikSu.AutoSize = true;
            this.lblAtikSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtikSu.Location = new System.Drawing.Point(139, 94);
            this.lblAtikSu.Name = "lblAtikSu";
            this.lblAtikSu.Size = new System.Drawing.Size(34, 13);
            this.lblAtikSu.TabIndex = 6;
            this.lblAtikSu.Text = "...TL";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(139, 56);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(34, 13);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "...TL";
            this.lblTutar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(139, 28);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(35, 13);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "...m3";
            this.lblMiktar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(22, 132);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 13);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam";
            // 
            // lblAtiksuBedeli
            // 
            this.lblAtiksuBedeli.AutoSize = true;
            this.lblAtiksuBedeli.Location = new System.Drawing.Point(22, 94);
            this.lblAtiksuBedeli.Name = "lblAtiksuBedeli";
            this.lblAtiksuBedeli.Size = new System.Drawing.Size(73, 13);
            this.lblAtiksuBedeli.TabIndex = 2;
            this.lblAtiksuBedeli.Text = "AtıkSu Bedeli:";
            this.lblAtiksuBedeli.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltuketimTutari
            // 
            this.lbltuketimTutari.AutoSize = true;
            this.lbltuketimTutari.Location = new System.Drawing.Point(19, 56);
            this.lbltuketimTutari.Name = "lbltuketimTutari";
            this.lbltuketimTutari.Size = new System.Drawing.Size(78, 13);
            this.lbltuketimTutari.TabIndex = 1;
            this.lbltuketimTutari.Text = "Tüketim Tutarı:";
            // 
            // lblTuketimMiktari
            // 
            this.lblTuketimMiktari.AutoSize = true;
            this.lblTuketimMiktari.Location = new System.Drawing.Point(16, 28);
            this.lblTuketimMiktari.Name = "lblTuketimMiktari";
            this.lblTuketimMiktari.Size = new System.Drawing.Size(81, 13);
            this.lblTuketimMiktari.TabIndex = 0;
            this.lblTuketimMiktari.Text = "Tüketim miktarı:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(308, 244);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(406, 244);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "&Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 294);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Su Faturası hesaplama programı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAbone;
        private System.Windows.Forms.TextBox txtSonEndeks;
        private System.Windows.Forms.TextBox txtIlkEndeks;
        private System.Windows.Forms.Label lblSayacTip;
        private System.Windows.Forms.Label lblSonEndeks;
        private System.Windows.Forms.Label lblIlkEndeks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblAtiksuBedeli;
        private System.Windows.Forms.Label lbltuketimTutari;
        private System.Windows.Forms.Label lblTuketimMiktari;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblAtikSu;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblToplamdeger;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
    }
}

