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
    public partial class Form1 : Form
    {
        public static List<string> kahveAdlari = new List<string>();

        int filtreKahveFiyat = 10;        
        int yumusakIcim = 2;
        int ekstraShot = 4;
        int ekstraSutlu = 4;
        int toplamSatis = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            KahveEkle ekle = new KahveEkle();
            ekle.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kahveAdlari.Count; i++)
            {
                cmbKahveler.Items.Add(kahveAdlari[i]);
            }
            MessageBox.Show("Ürünler Başarılı Bir Şekilde Güncellendi !");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            


            if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && (cbEkstraShot.Checked && cbEkstraSut.Checked && cbYumusakIcim.Checked))
            {
                lblFiyat.Text = (filtreKahveFiyat + yumusakIcim + ekstraShot + ekstraSutlu).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && (cbEkstraShot.Checked && cbEkstraSut.Checked))
            {
                lblFiyat.Text = (filtreKahveFiyat + ekstraShot + ekstraSutlu).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && (cbEkstraShot.Checked && cbYumusakIcim.Checked))
            {
                lblFiyat.Text = (filtreKahveFiyat + ekstraShot + yumusakIcim).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && (cbEkstraSut.Checked && cbYumusakIcim.Checked))
            {
                lblFiyat.Text = (filtreKahveFiyat + ekstraSutlu + yumusakIcim).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && (cbEkstraSut.Checked || cbEkstraShot.Checked))
            {
                lblFiyat.Text = (filtreKahveFiyat + ekstraSutlu).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve" && cbYumusakIcim.Checked)
            {
                lblFiyat.Text = (filtreKahveFiyat + yumusakIcim).ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
            }
            else if (cmbKahveler.SelectedItem.ToString() == "Filtre Kahve")
            {
                lblFiyat.Text = filtreKahveFiyat.ToString();
                lbKahveler.Items.Add(lblFiyat.Text + " TL = Filtre Kahve");
                toplamSatis += int.Parse(lblFiyat.Text);
               
            }

            lblToplamFiyat.Text = toplamSatis.ToString();

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblToplamFiyat.Text) > 50)
            {
                MessageBox.Show("50 TL ve Üzeri Sipariş Gerçekleştirilemez !!");
            }
            else
            {
                lbKahveler.Items.Clear();
                MessageBox.Show("Sipariş Başarılı Bir Şekilde Tamamlandı !");
                lblFiyat.Text = "0";
                lblToplamFiyat.Text = "0";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lbKahveler.SelectedIndex;
            lbKahveler.Items.RemoveAt(index);
            toplamSatis -= int.Parse(lblFiyat.Text);
            lblToplamFiyat.Text = toplamSatis.ToString();
        }

        private void lbKahveler_MouseClick(object sender, MouseEventArgs e)
        {
            string parcalanmisFiyat = lbKahveler.SelectedItem.ToString().Substring(0, 2);
            lblFiyat.Text = parcalanmisFiyat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblFiyat_Click(object sender, EventArgs e)
        {

        }
    }
}
