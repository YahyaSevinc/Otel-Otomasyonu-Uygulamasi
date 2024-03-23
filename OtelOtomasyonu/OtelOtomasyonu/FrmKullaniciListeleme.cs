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
    public partial class FrmKullaniciListeleme : Form
    {
        public FrmKullaniciListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H3TH5TN\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AdminGiris", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["KullaniciAdi"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void FrmKullaniciListeleme_Load(object sender, EventArgs e)
        {

        }
    }
}
