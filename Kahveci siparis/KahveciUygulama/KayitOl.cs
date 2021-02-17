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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Giris.kullaniciAdi.Add(txtKayitAd.Text);
            Giris.sifreler.Add(txtKayitSifre.Text);

            txtKayitAd.Clear();
            txtKayitSifre.Clear();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti");
            KayitOl.ActiveForm.Hide();
        }
    }
}
