using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
      //  SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtPersonelSayisi.Text == "Personel Sayısını Giriniz.")
            {
                MessageBox.Show("Boş Alan Bırakmayınız.");
                return;
            }
            else if (txtMesaiSayisi.Text == "Mesai Sayısını Giriniz.")
            {
                MessageBox.Show("Boş Alan Bırakmayınız.");
                return;
            }
            else if (txtFaturalar.Text == "Bu Ayın Fatura Tutarını Giriniz.")
            {
                MessageBox.Show("Boş Alan Bırakmayınız.");
                return;
            }
            int maas1 = Convert.ToInt32(txtPersonelSayisi.Text);
            int maas2 = Convert.ToInt32(txtMesaiSayisi.Text);
            int maas3;
            maas3 = maas1 * 10000;
            int maas4;
            maas4 = maas2 * 400;
            int maas;
            maas = maas3 + maas4;
            lblPersonelMaas.Text = (maas+"TL").ToString();
            int fatura1 = Convert.ToInt32(txtFaturalar.Text);
            lblFaturalar.Text = (fatura1+"TL").ToString();
            int sonuc = maas + fatura1;
            lblGider.Text = (sonuc+"TL").ToString();
            int toplam = Convert.ToInt32(lblmusterigelir.Text);
            int sonucson = toplam - sonuc;
            lblSonuc.Text = (sonucson + "TL").ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            txtPersonelSayisi.Text = "Personel Sayısını Giriniz.";
            txtPersonelSayisi.ForeColor = Color.LightGray;
            txtMesaiSayisi.Text = "Mesai Sayısını Giriniz.";
            txtMesaiSayisi.ForeColor = Color.LightGray;
            txtFaturalar.Text = "Bu Ayın Fatura Tutarını Giriniz.";
            txtFaturalar.ForeColor = Color.LightGray;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblmusterigelir.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
        }

        private void txtPersonelSayisi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPersonelSayisi_DoubleClick(object sender, EventArgs e)
        {
            txtPersonelSayisi.Text = "";
            txtPersonelSayisi.ForeColor = Color.Black;
        }

        private void txtMesaiSayisi_DoubleClick(object sender, EventArgs e)
        {
            txtMesaiSayisi.Text = "";
            txtMesaiSayisi.ForeColor = Color.Black;
        }

        private void txtFaturalar_DoubleClick(object sender, EventArgs e)
        {
            txtFaturalar.Text = "";
            txtFaturalar.ForeColor = Color.Black; 
        }
    }
}
