
namespace WindowsFormsApp5
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaniye = new System.Windows.Forms.TextBox();
			this.cmbHizSecme = new System.Windows.Forms.ComboBox();
			this.btnBasla = new System.Windows.Forms.Button();
			this.btnDur = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKalanSure = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(236, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kronometrem";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Süreyi girin ( saniye )";
			// 
			// txtSaniye
			// 
			this.txtSaniye.Location = new System.Drawing.Point(121, 65);
			this.txtSaniye.Name = "txtSaniye";
			this.txtSaniye.Size = new System.Drawing.Size(100, 20);
			this.txtSaniye.TabIndex = 2;
			this.txtSaniye.TextChanged += new System.EventHandler(this.txtSaniye_TextChanged);
			// 
			// cmbHizSecme
			// 
			this.cmbHizSecme.FormattingEnabled = true;
			this.cmbHizSecme.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000"});
			this.cmbHizSecme.Location = new System.Drawing.Point(15, 94);
			this.cmbHizSecme.Name = "cmbHizSecme";
			this.cmbHizSecme.Size = new System.Drawing.Size(206, 21);
			this.cmbHizSecme.TabIndex = 3;
			this.cmbHizSecme.Text = "Hız Seçin";
			this.cmbHizSecme.SelectedIndexChanged += new System.EventHandler(this.cmbHizSecme_SelectedIndexChanged);
			// 
			// btnBasla
			// 
			this.btnBasla.Location = new System.Drawing.Point(12, 223);
			this.btnBasla.Name = "btnBasla";
			this.btnBasla.Size = new System.Drawing.Size(100, 23);
			this.btnBasla.TabIndex = 4;
			this.btnBasla.Text = "Başla";
			this.btnBasla.UseVisualStyleBackColor = true;
			this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
			// 
			// btnDur
			// 
			this.btnDur.Location = new System.Drawing.Point(121, 223);
			this.btnDur.Name = "btnDur";
			this.btnDur.Size = new System.Drawing.Size(100, 23);
			this.btnDur.TabIndex = 5;
			this.btnDur.Text = "Dur";
			this.btnDur.UseVisualStyleBackColor = true;
			this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(239, 158);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(338, 121);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kalan Süre:";
			// 
			// lblKalanSure
			// 
			this.lblKalanSure.AutoSize = true;
			this.lblKalanSure.Location = new System.Drawing.Point(399, 107);
			this.lblKalanSure.Name = "lblKalanSure";
			this.lblKalanSure.Size = new System.Drawing.Size(13, 13);
			this.lblKalanSure.TabIndex = 8;
			this.lblKalanSure.Text = "0";
			this.lblKalanSure.Click += new System.EventHandler(this.lblKalanSure_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 306);
			this.Controls.Add(this.lblKalanSure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnDur);
			this.Controls.Add(this.btnBasla);
			this.Controls.Add(this.cmbHizSecme);
			this.Controls.Add(this.txtSaniye);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaniye;
		private System.Windows.Forms.ComboBox cmbHizSecme;
		private System.Windows.Forms.Button btnBasla;
		private System.Windows.Forms.Button btnDur;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblKalanSure;
		private System.Windows.Forms.Timer timer1;
	}
}

