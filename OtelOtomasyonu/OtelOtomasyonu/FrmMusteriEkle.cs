using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace OtelOtomasyonu
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
       // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            
            if (txtMusteriAd.Text == "")
            {
                MessageBox.Show("Lütfen İsim Giriniz.");
                return;
            }
            else if (txtMusteriSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Soyad Giriniz.");
                return;
            }
            else if (txtMusteriTc.Text == "")
            {
                MessageBox.Show("Lütfen T.C. Giriniz.");
                return;
            }
            else if (cmbOdaNo.Text == "")
            {
                MessageBox.Show("Oda Seçiniz.");
                return;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Lütfen Olgunluğunuzu Seçin.");
                return;
            }
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(MusteriAdı,MusteriSoyadı,MusteriTelefon,MusteriMail,MusteriTc,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "','" + mskTxtMusteriTelefon.Text + "','" + txtMusteriMail.Text + "','" + txtMusteriTc.Text + "','" + cmbOdaNo.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı");
            if (cmbOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into Oda101(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                btnOda101.BackColor = Color.Green;
                cmbOdaNo.Text = "101";
            }
            else if (cmbOdaNo.Text=="102")
            {
                cmbOdaNo.Text = "102";
                baglanti.Open();
                SqlCommand komut102 = new SqlCommand("insert into Oda102(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut102.ExecuteNonQuery();
                baglanti.Close();
                btnOda102.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "103")
            {
                cmbOdaNo.Text = "103";
                baglanti.Open();
                SqlCommand komut103 = new SqlCommand("insert into Oda103(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut103.ExecuteNonQuery();
                baglanti.Close();
                btnOda103.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "104")
            {
                cmbOdaNo.Text = "104";
                baglanti.Open();
                SqlCommand komut104 = new SqlCommand("insert into Oda104(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut104.ExecuteNonQuery();
                baglanti.Close();
                btnOda104.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "105")
            {
                cmbOdaNo.Text = "105";
                baglanti.Open();
                SqlCommand komut105 = new SqlCommand("insert into Oda105(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut105.ExecuteNonQuery();
                baglanti.Close();
                btnOda105.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "106")
            {
                cmbOdaNo.Text = "106";
                baglanti.Open();
                SqlCommand komut106 = new SqlCommand("insert into Oda106(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut106.ExecuteNonQuery();
                baglanti.Close();
                btnOda106.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "107")
            {
                cmbOdaNo.Text = "107";
                baglanti.Open();
                SqlCommand komut107 = new SqlCommand("insert into Oda107(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut107.ExecuteNonQuery();
                baglanti.Close();
                btnOda107.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "108")
            {
                cmbOdaNo.Text = "108";
                baglanti.Open();
                SqlCommand komut108 = new SqlCommand("insert into Oda108(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut108.ExecuteNonQuery();
                baglanti.Close();
                btnOda108.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "109")
            {
                cmbOdaNo.Text = "109";
                baglanti.Open();
                SqlCommand komut109 = new SqlCommand("insert into Oda109(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut109.ExecuteNonQuery();
                baglanti.Close();
                btnOda109.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "201")
            {
                cmbOdaNo.Text = "201";
                baglanti.Open();
                SqlCommand komut201 = new SqlCommand("insert into Oda201(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut201.ExecuteNonQuery();
                baglanti.Close();
                btnOda201.BackColor = Color.Green;
            }
            else if (cmbOdaNo.Text == "202")
            {
                cmbOdaNo.Text = "202";
                baglanti.Open();
                SqlCommand komut202 = new SqlCommand("insert into Oda202(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
                komut202.ExecuteNonQuery();
                baglanti.Close();
                btnOda202.BackColor = Color.Green;
            }
            /*btnOda101.Enabled = true;
            btnOda102.Enabled = true;
            btnOda103.Enabled = true;
            btnOda104.Enabled = true;
            btnOda105.Enabled = true;
            btnOda106.Enabled = true;
            btnOda107.Enabled = true;
            btnOda108.Enabled = true;
            btnOda109.Enabled = true;
            btnOda201.Enabled = true;
            btnOda202.Enabled = true;*/

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Class2.yetiskin = 1;
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            TimeSpan sonuc;
            sonuc = buyuktarih - kucuktarih;
            label10.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text) *6000;
            txtUcret.Text = ucret.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Class2.cocuk = 1;
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            TimeSpan sonuc;
            sonuc = buyuktarih - kucuktarih;
            label10.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text) * 5500;
            txtUcret.Text = ucret.ToString();
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            btnOda101.BackColor = Color.FromArgb(224, 224, 224);
            btnOda102.BackColor = Color.FromArgb(224, 224, 224);
            btnOda103.BackColor = Color.FromArgb(224, 224, 224);
            btnOda104.BackColor = Color.FromArgb(224, 224, 224);
            btnOda105.BackColor = Color.FromArgb(224, 224, 224);
            btnOda106.BackColor = Color.FromArgb(224, 224, 224);
            btnOda107.BackColor = Color.FromArgb(224, 224, 224);
            btnOda108.BackColor = Color.FromArgb(224, 224, 224);
            btnOda109.BackColor = Color.FromArgb(224, 224, 224);
            btnOda201.BackColor = Color.FromArgb(224, 224, 224);
            btnOda202.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Visible = false;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = "Dolu";
                btnOda101.Enabled = false;
            }
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = "Dolu";
                btnOda102.Enabled = false;
            }
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = "Dolu";
                btnOda103.Enabled = false;
            }
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = "Dolu";
                btnOda104.Enabled = false;
            }
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = "Dolu";
                btnOda105.Enabled = false;
            }
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = "Dolu";
                btnOda106.Enabled = false;
            }
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = "Dolu";
                btnOda107.Enabled = false;
            }
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = "Dolu";
                btnOda108.Enabled = false;
            }
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = "Dolu";
                btnOda109.Enabled = false;
            }
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda201
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                btnOda201.Text = "Dolu";
                btnOda201.Enabled = false;
            }
            if (btnOda201.Text != "201")
            {
                btnOda201.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda202
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                btnOda202.Text = "Dolu";
                btnOda202.Enabled = false;
            }
            if (btnOda202.Text != "202")
            {
                btnOda202.BackColor = Color.Red;
            }
            baglanti.Close();
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Oda101(Ad,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            btnOda101.BackColor = Color.Green;*/
            cmbOdaNo.Text = "101";
            btnOda101.BackColor = Color.Green;
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            // SoundPlayer ses = new SoundPlayer(@"C:\Users\Sevinc\Desktop\2022 Uygulamalar\OtelOtomasyonu\OtelOtomasyonu\bin\Debug");
            //ses.Play();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            /* cmbOdaNo.Text = "102";
             baglanti.Open();
             SqlCommand komut102 = new SqlCommand("insert into Oda102(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
             komut102.ExecuteNonQuery();
             baglanti.Close();*/
            cmbOdaNo.Text = "102";
            btnOda102.BackColor = Color.Green; 
           // SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
           // ses.Play();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "103";
            /*cmbOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("insert into Oda103(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut103.ExecuteNonQuery();
            baglanti.Close();
            btnOda103.BackColor = Color.Green;*/
            btnOda103.BackColor = Color.Green;
            //  SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            // ses.Play();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "104";
            /*cmbOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("insert into Oda104(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut104.ExecuteNonQuery();
            baglanti.Close();
            btnOda104.BackColor = Color.Green;*/
            btnOda104.BackColor = Color.Green;
            //SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //ses.Play();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "105";
            /*cmbOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("insert into Oda105(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut105.ExecuteNonQuery();
            baglanti.Close();
            btnOda105.BackColor = Color.Green;*/
            btnOda105.BackColor = Color.Green;
            // SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            // ses.Play();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "106";
            /*cmbOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("insert into Oda106(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut106.ExecuteNonQuery();
            baglanti.Close();
            btnOda106.BackColor = Color.Green;*/
            btnOda106.BackColor = Color.Green;
            //   SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            // ses.Play();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "107";
            /*cmbOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("insert into Oda107(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut107.ExecuteNonQuery();
            baglanti.Close();
            btnOda107.BackColor = Color.Green;*/
            btnOda107.BackColor = Color.Green;
            //   SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //  ses.Play();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "108";
            /*cmbOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("insert into Oda108(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut108.ExecuteNonQuery();
            baglanti.Close();
            btnOda108.BackColor = Color.Green;*/
            btnOda108.BackColor = Color.Green;
            //SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //ses.Play();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "109";
            /*cmbOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("insert into Oda109(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut109.ExecuteNonQuery();
            baglanti.Close();
            btnOda109.BackColor = Color.Green;*/
            btnOda109.BackColor = Color.Green;
            // SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //ses.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void btnOda201_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "201";
            /*cmbOdaNo.Text = "201";
            baglanti.Open();
            SqlCommand komut201 = new SqlCommand("insert into Oda201(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut201.ExecuteNonQuery();
            baglanti.Close();
            btnOda201.BackColor = Color.Green;*/
            btnOda201.BackColor = Color.Green;
            // SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //ses.Play();
        }

        private void btnOda202_Click(object sender, EventArgs e)
        {
            btnOda101.Enabled = false;
            btnOda102.Enabled = false;
            btnOda103.Enabled = false;
            btnOda104.Enabled = false;
            btnOda105.Enabled = false;
            btnOda106.Enabled = false;
            btnOda107.Enabled = false;
            btnOda108.Enabled = false;
            btnOda109.Enabled = false;
            btnOda201.Enabled = false;
            btnOda202.Enabled = false;
            cmbOdaNo.Text = "202";
            /*cmbOdaNo.Text = "202";
            baglanti.Open();
            SqlCommand komut202 = new SqlCommand("insert into Oda202(Adi,Soyadi) values('" + txtMusteriAd.Text + "','" + txtMusteriSoyad.Text + "')", baglanti);
            komut202.ExecuteNonQuery();
            baglanti.Close();
            btnOda202.BackColor = Color.Green;*/
            btnOda202.BackColor = Color.Green;
            // SoundPlayer ses = new SoundPlayer(@"C:\Users\sevinç\Desktop\OtelOtomasyonu\OtelOtomasyonu\Ding-Sound-Effect-_-Free-Download-_.wav");
            //ses.Play();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //btnOda101.BackColor = Color.FromArgb(224, 224, 224);
            btnOda101.BackColor = Color.FromArgb(224, 224, 224);
            btnOda102.BackColor = Color.FromArgb(224, 224, 224);
            btnOda103.BackColor = Color.FromArgb(224, 224, 224);
            btnOda104.BackColor = Color.FromArgb(224, 224, 224);
            btnOda105.BackColor = Color.FromArgb(224, 224, 224);
            btnOda106.BackColor = Color.FromArgb(224, 224, 224);
            btnOda107.BackColor = Color.FromArgb(224, 224, 224);
            btnOda108.BackColor = Color.FromArgb(224, 224, 224);
            btnOda109.BackColor = Color.FromArgb(224, 224, 224);
            btnOda201.BackColor = Color.FromArgb(224, 224, 224);
            btnOda202.BackColor = Color.FromArgb(224, 224, 224);
            //btnOda101.BackColor = Color.LightGray;
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            mskTxtMusteriTelefon.Clear();
            txtMusteriMail.Clear();
            txtMusteriTc.Clear();
            cmbOdaNo.Text = "";
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";
            txtUcret.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = "Dolu";
                btnOda101.Enabled = false;
            }
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = "Dolu";
                btnOda102.Enabled = false;
            }
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = "Dolu";
                btnOda103.Enabled = false;
            }
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = "Dolu";
                btnOda104.Enabled = false;
            }
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = "Dolu";
                btnOda105.Enabled = false;
            }
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = "Dolu";
                btnOda106.Enabled = false;
            }
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = "Dolu";
                btnOda107.Enabled = false;
            }
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = "Dolu";
                btnOda108.Enabled = false;
            }
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = "Dolu";
                btnOda109.Enabled = false;
            }
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda201
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                btnOda201.Text = "Dolu";
                btnOda201.Enabled = false;
            }
            if (btnOda201.Text != "201")
            {
                btnOda201.BackColor = Color.Red;
            }
            baglanti.Close();
            //oda202
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                btnOda202.Text = "Dolu";
                btnOda202.Enabled = false;
            }
            if (btnOda202.Text != "202")
            {
                btnOda202.BackColor = Color.Red;
            }
            baglanti.Close();
            btnOda101.Enabled = true;
            btnOda102.Enabled = true;
            btnOda103.Enabled = true;
            btnOda104.Enabled = true;
            btnOda105.Enabled = true;
            btnOda106.Enabled = true;
            btnOda107.Enabled = true;
            btnOda108.Enabled = true;
            btnOda109.Enabled = true;
            btnOda201.Enabled = true;
            btnOda202.Enabled = true;
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
        
            txtMusteriAd.Clear();
          //  txtMusteriSoyad.Clear();
            mskTxtMusteriTelefon.Clear();
            txtMusteriMail.Clear();
            txtMusteriTc.Clear();
          //  cmbOdaNo.Text = "";
          //  dtpGirisTarihi.Text = "";
          //  dtpCikisTarihi.Text = "";
            txtUcret.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




