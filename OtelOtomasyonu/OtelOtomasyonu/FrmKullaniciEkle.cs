using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace OtelOtomasyonu
{
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
       // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void FrmKullaniciEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AdminGiris where KullaniciAdi='" + txtKullaniciAdi.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (txtKullaniciAdi.Text == oku["KullaniciAdi"].ToString())
                {
                    MessageBox.Show("Kullanıcı adı aynı olamaz");
                }
                baglanti.Close();
            }
            else
            {
                con.Open();
                SqlCommand komut2 = new SqlCommand("insert into AdminGiris(KullaniciAdi,Sifre) values('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "')", con);
                komut2.ExecuteNonQuery();
                con.Close();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
            
            
    }
    }
}

