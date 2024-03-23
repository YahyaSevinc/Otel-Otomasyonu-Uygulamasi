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
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=SEVINC24\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriKayit", baglanti);
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
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void BtnVerileriGoster_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        int id2 = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMusteriAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMusteriSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            mskTxtMusteriTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMusteriMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMusteriTc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[9].Text;
            id2 = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMusteriAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMusteriSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            
            if (txtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("DELETE FROM Oda101", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("DELETE FROM Oda102", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut5.ExecuteNonQuery();
                SqlCommand komut6 = new SqlCommand("DELETE FROM Oda103", baglanti);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut7 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut7.ExecuteNonQuery();
                SqlCommand komut8 = new SqlCommand("DELETE FROM Oda104", baglanti);
                komut8.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut9 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut9.ExecuteNonQuery();
                SqlCommand komut10 = new SqlCommand("DELETE FROM Oda105", baglanti);
                komut10.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut11 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut11.ExecuteNonQuery();
                SqlCommand komut12 = new SqlCommand("DELETE FROM Oda106", baglanti);
                komut12.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut12 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut12.ExecuteNonQuery();
                SqlCommand komut13 = new SqlCommand("DELETE FROM Oda107", baglanti);
                komut13.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut14 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut14.ExecuteNonQuery();
                SqlCommand komut15 = new SqlCommand("DELETE FROM Oda108", baglanti);
                komut15.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            else if (txtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut16 = new SqlCommand("delete from MusteriKayit where Musteriİd=(" + id + ")", baglanti);
                komut16.ExecuteNonQuery();
                SqlCommand komut17 = new SqlCommand("DELETE FROM Oda109", baglanti);
                komut17.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }
    }
}
