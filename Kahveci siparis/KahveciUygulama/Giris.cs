using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveciUygulama
{
    public partial class Giris : Form
    {
        public static List<string> kullaniciAdi = new List<string>();
        public static List<string> sifreler = new List<string>();

        public Giris()
        {
            InitializeComponent();
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girisKullaniciAdi = txtKullaniciAdi.Text;
            string girisSifre = txtSifre.Text;

            txtKullaniciAdi.Clear();
            txtSifre.Clear();

            for (int i = 0; i < kullaniciAdi.Count; i++)
            {
                if (girisKullaniciAdi == kullaniciAdi[i] && girisSifre == sifreler[i])
                {
                    MessageBox.Show("Giriş Başarılı");
                    Form1 frm = new Form1();
                    frm.Show();
                    return;
                }
            }
            MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");

           
        }
    }
}
