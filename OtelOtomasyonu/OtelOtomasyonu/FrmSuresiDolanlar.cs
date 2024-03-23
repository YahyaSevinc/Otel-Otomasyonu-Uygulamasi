using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class FrmSuresiDolanlar : Form
    {
        int id = 0;
        public FrmSuresiDolanlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        //    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Ayrılanlar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = oku2["Musteriİd"].ToString();
                ekle2.SubItems.Add(oku2["MusteriAdı"].ToString());
                ekle2.SubItems.Add(oku2["MusteriSoyadı"].ToString());
                ekle2.SubItems.Add(oku2["MusteriTelefon"].ToString());
                ekle2.SubItems.Add(oku2["MusteriMail"].ToString());
                ekle2.SubItems.Add(oku2["MusteriTc"].ToString());
                ekle2.SubItems.Add(oku2["OdaNo"].ToString());
                ekle2.SubItems.Add(oku2["GirisTarihi"].ToString());
                ekle2.SubItems.Add(oku2["CikisTarihi"].ToString());
                //ekle.SubItems.Add(oku["Ucret"].ToString());
                listView2.Items.Add(ekle2);
            }
            baglanti.Close();
        }
        private void verilerigoster2()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SuresiDolanlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriİd"].ToString();
                ekle.SubItems.Add(oku["MusteriAdı"].ToString());
                ekle.SubItems.Add(oku["MusteriSoyadı"].ToString());
                ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                ekle.SubItems.Add(oku["MusteriMail"].ToString());
                ekle.SubItems.Add(oku["MusteriTc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                //ekle.SubItems.Add(oku["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FrmSuresiDolanlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
            verilerigoster2();
        }
    }
}
