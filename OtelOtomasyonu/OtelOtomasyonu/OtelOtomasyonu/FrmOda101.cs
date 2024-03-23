using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace OtelOtomasyonu
{
    public partial class FrmOda101 : Form
    {
        public FrmOda101()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void FrmOda101_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["id"].ToString();
                ekle.SubItems.Add(oku1["Adi"].ToString());
                ekle.SubItems.Add(oku1["Soyadi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
