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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu
{
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();

        }
       // SqlConnection baglanti = new SqlConnection(@"Data Source=SEVINC24\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        // SqlConnection baglanti = new SqlConnection(@"Data Source=SEVINC24\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
     //    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
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
            dtpGirisTarihi.Value.ToString("");
            dtpCikisTarihi.Value.ToString("");
           /* verilerigoster();
            DateTime cikisgunu = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            int durum = DateTime.Compare(buyuktarih, cikisgunu);
            if (durum <= 0)
            {
                MessageBox.Show("Süresi Dolmuştur");
            }
            else
            {
                MessageBox.Show("Süresi Dolmamıştır");
            }*/
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
            //id2 = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            //txtMusteriAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //txtMusteriSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            
            if (txtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("DELETE FROM Oda101", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("DELETE FROM Oda102", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut5.ExecuteNonQuery();
                SqlCommand komut6 = new SqlCommand("DELETE FROM Oda103", baglanti);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut7 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut7.ExecuteNonQuery();
                SqlCommand komut8 = new SqlCommand("DELETE FROM Oda104", baglanti);
                komut8.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut9 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut9.ExecuteNonQuery();
                SqlCommand komut10 = new SqlCommand("DELETE FROM Oda105", baglanti);
                komut10.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut11 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut11.ExecuteNonQuery();
                SqlCommand komut12 = new SqlCommand("DELETE FROM Oda106", baglanti);
                komut12.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut12 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut12.ExecuteNonQuery();
                SqlCommand komut13 = new SqlCommand("DELETE FROM Oda107", baglanti);
                komut13.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut14 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut14.ExecuteNonQuery();
                SqlCommand komut15 = new SqlCommand("DELETE FROM Oda108", baglanti);
                komut15.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut16 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut16.ExecuteNonQuery();
                SqlCommand komut17 = new SqlCommand("DELETE FROM Oda109", baglanti);
                komut17.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut18 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut18.ExecuteNonQuery();
                SqlCommand komut19 = new SqlCommand("DELETE FROM Oda201", baglanti);
                komut19.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (txtOdaNo.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut20 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                komut20.ExecuteNonQuery();
                SqlCommand komut21 = new SqlCommand("DELETE FROM Oda202", baglanti);
                komut21.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                baglanti.Open();
                SqlCommand komut149 = new SqlCommand("insert into Ayrılanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                komut149.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where MusteriAdı like '%" + txtAra.Text + "%'", baglanti);
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

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (txtOdaNo.Text == "102")
            {
                //baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Oda102 set Adi='" + txtMusteriAd.Text + "',Soyadi='" + txtMusteriSoyad.Text + "'where id=" + id + "", baglanti);
                komut2.ExecuteNonQuery();
               // baglanti.Close();
               // verilerigoster();
            }
            else if (txtOdaNo.Text == "103")
            {
                SqlCommand komut3 = new SqlCommand("update Oda103 set Adi='" + txtMusteriAd.Text + "',Soyadi='" + txtMusteriSoyad.Text + "'where id=" + id + "", baglanti);
                komut3.ExecuteNonQuery();
            }
            SqlCommand komut = new SqlCommand("update MusteriEkle set MusteriAdı='" + txtMusteriAd.Text + "',MusteriSoyadı='" + txtMusteriSoyad.Text + "',MusteriTelefon='" + mskTxtMusteriTelefon.Text + "',MusteriMail='" + txtMusteriMail.Text + "',MusteriTc='" + txtMusteriTc.Text + "',OdaNo='" + txtOdaNo.Text + "',GirisTarihi='" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "',Ucret='" + txtUcret.Text + "'where Musteriİd=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            
            MessageBox.Show("Veriler Başarıyla Güncellendi");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime today = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime cik = Convert.ToDateTime(dtpCikisTarihi.Value);
            TimeSpan fark = cik - today;
            int toplamgun = fark.Days;
            int gungun = toplamgun + 1;
            //int ucret;
            DateTime cikisgunu = Convert.ToDateTime(dateTimePicker1.Text);
            //DateTime çıkış = DateTime.Now;
            //DateTime kucuktarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            //TimeSpan sonuc;
            //TimeSpan gun;
            
            int durum = DateTime.Compare(buyuktarih, cikisgunu);
            //durum = buyuktarih - çıkış;
            if (durum > 0)
            {
                //label11.Text = Convert.ToString(durum);
                MessageBox.Show("Süresi Dolmamıştır Dolmasına "+gungun+" Gün Kaldı.");
                return;

                // baglanti.Open();
                // SqlCommand komut = new SqlCommand("insert into");
            }
            else
            {
                MessageBox.Show("Süresi Dolmuştur");
                if (txtOdaNo.Text == "101")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("DELETE FROM Oda101", baglanti);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (txtOdaNo.Text == "102")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut3 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut3.ExecuteNonQuery();
                        SqlCommand komut4 = new SqlCommand("DELETE FROM Oda102", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {

                        return;
                        
                    }
                    
                }
                else if (txtOdaNo.Text == "103")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut5 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut5.ExecuteNonQuery();
                        SqlCommand komut6 = new SqlCommand("DELETE FROM Oda103", baglanti);
                        komut6.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "104")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut7 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut7.ExecuteNonQuery();
                        SqlCommand komut8 = new SqlCommand("DELETE FROM Oda104", baglanti);
                        komut8.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "105")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut9 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut9.ExecuteNonQuery();
                        SqlCommand komut10 = new SqlCommand("DELETE FROM Oda105", baglanti);
                        komut10.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }

                }
                else if (txtOdaNo.Text == "106")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut11 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut11.ExecuteNonQuery();
                        SqlCommand komut12 = new SqlCommand("DELETE FROM Oda106", baglanti);
                        komut12.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }

                }
                else if (txtOdaNo.Text == "107")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut12 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut12.ExecuteNonQuery();
                        SqlCommand komut13 = new SqlCommand("DELETE FROM Oda107", baglanti);
                        komut13.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "108")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut14 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut14.ExecuteNonQuery();
                        SqlCommand komut15 = new SqlCommand("DELETE FROM Oda108", baglanti);
                        komut15.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "109")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut16 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut16.ExecuteNonQuery();
                        SqlCommand komut17 = new SqlCommand("DELETE FROM Oda109", baglanti);
                        komut17.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "201")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut18 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut18.ExecuteNonQuery();
                        SqlCommand komut19 = new SqlCommand("DELETE FROM Oda201", baglanti);
                        komut19.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else if (txtOdaNo.Text == "202")
                {
                    DialogResult result1 = MessageBox.Show("Müşterinin Süresi Dolmuştur Kaydını Silmek İstermisiniz ?", "Confractus Hotel", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand komut20 = new SqlCommand("delete from MusteriEkle where Musteriİd=(" + id + ")", baglanti);
                        komut20.ExecuteNonQuery();
                        SqlCommand komut21 = new SqlCommand("DELETE FROM Oda202", baglanti);
                        komut21.ExecuteNonQuery();
                        baglanti.Close();
                        verilerigoster();
                        baglanti.Open();
                        SqlCommand komut149 = new SqlCommand("insert into SuresiDolanlar(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + txtOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
                        komut149.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        return;
                    }
                    
                }
            }
            //sonuc = buyuktarih - kucuktarih;
            //label10.Text = sonuc.TotalDays.ToString();
            //ucret = Convert.ToInt32(label10.Text) * 300;
           // txtUcret.Text = ucret.ToString() + "TL";

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtMusteriMail.Clear();
            txtMusteriTc.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            mskTxtMusteriTelefon.Clear();
            txtAra.Clear();


        }
    }
}





