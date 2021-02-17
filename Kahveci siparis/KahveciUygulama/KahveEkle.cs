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
    public partial class KahveEkle : Form
    {
        public KahveEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form1.kahveAdlari.Add(txtKahveEkle.Text);
            txtKahveEkle.Clear();
            MessageBox.Show("Kahve Adı Başarılı Bir Şekilde Eklendi !");
            KahveEkle.ActiveForm.Hide();
     
        }
    }
}
