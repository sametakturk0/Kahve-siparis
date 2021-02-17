namespace KahveciUygulama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKahveler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEkstraShot = new System.Windows.Forms.CheckBox();
            this.cbEkstraSut = new System.Windows.Forms.CheckBox();
            this.cbYumusakIcim = new System.Windows.Forms.CheckBox();
            this.lbKahveler = new System.Windows.Forms.ListBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbKahveler
            // 
            this.cmbKahveler.FormattingEnabled = true;
            this.cmbKahveler.Location = new System.Drawing.Point(13, 209);
            this.cmbKahveler.Name = "cmbKahveler";
            this.cmbKahveler.Size = new System.Drawing.Size(143, 21);
            this.cmbKahveler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEkstraShot);
            this.groupBox1.Controls.Add(this.cbEkstraSut);
            this.groupBox1.Controls.Add(this.cbYumusakIcim);
            this.groupBox1.Location = new System.Drawing.Point(13, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Özellikler";
            // 
            // cbEkstraShot
            // 
            this.cbEkstraShot.AutoSize = true;
            this.cbEkstraShot.Location = new System.Drawing.Point(7, 66);
            this.cbEkstraShot.Name = "cbEkstraShot";
            this.cbEkstraShot.Size = new System.Drawing.Size(112, 17);
            this.cbEkstraShot.TabIndex = 0;
            this.cbEkstraShot.Text = "Ekstra Shot(+4TL)";
            this.cbEkstraShot.UseVisualStyleBackColor = true;
            // 
            // cbEkstraSut
            // 
            this.cbEkstraSut.AutoSize = true;
            this.cbEkstraSut.Location = new System.Drawing.Point(7, 43);
            this.cbEkstraSut.Name = "cbEkstraSut";
            this.cbEkstraSut.Size = new System.Drawing.Size(117, 17);
            this.cbEkstraSut.TabIndex = 0;
            this.cbEkstraSut.Text = "Ekstra Sütlü (+4TL)";
            this.cbEkstraSut.UseVisualStyleBackColor = true;
            // 
            // cbYumusakIcim
            // 
            this.cbYumusakIcim.AutoSize = true;
            this.cbYumusakIcim.Location = new System.Drawing.Point(7, 20);
            this.cbYumusakIcim.Name = "cbYumusakIcim";
            this.cbYumusakIcim.Size = new System.Drawing.Size(126, 17);
            this.cbYumusakIcim.TabIndex = 0;
            this.cbYumusakIcim.Text = "Yumuşak İçim (+2TL)";
            this.cbYumusakIcim.UseVisualStyleBackColor = true;
            // 
            // lbKahveler
            // 
            this.lbKahveler.FormattingEnabled = true;
            this.lbKahveler.Location = new System.Drawing.Point(183, 61);
            this.lbKahveler.Name = "lbKahveler";
            this.lbKahveler.Size = new System.Drawing.Size(266, 342);
            this.lbKahveler.TabIndex = 4;
            this.lbKahveler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbKahveler_MouseClick);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(467, 61);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(136, 31);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(496, 98);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 29);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(183, 452);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(121, 31);
            this.btnSiparisTamamla.TabIndex = 3;
            this.btnSiparisTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(328, 452);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kahveler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seçilen Kahve Fiyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Fiyat : ";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(266, 420);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblToplamFiyat.TabIndex = 5;
            this.lblToplamFiyat.Text = "0";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(464, 164);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(13, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "0";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(534, 164);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(13, 13);
            this.lblSaat.TabIndex = 5;
            this.lblSaat.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "HOŞGELDİNİZ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(121, 381);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "0";
            this.lblFiyat.Click += new System.EventHandler(this.lblFiyat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(13, 452);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 31);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 505);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKahveler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKahveler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbKahveler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEkstraShot;
        private System.Windows.Forms.CheckBox cbEkstraSut;
        private System.Windows.Forms.CheckBox cbYumusakIcim;
        private System.Windows.Forms.ListBox lbKahveler;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Timer timer1;
    }
}

