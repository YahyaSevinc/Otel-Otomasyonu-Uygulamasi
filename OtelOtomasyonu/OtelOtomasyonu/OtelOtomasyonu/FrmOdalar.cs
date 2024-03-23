using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UUOUMLQ\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            FrmOda101 od = new FrmOda101();
            od.Show();
            Visible = false;
            
        }
    }
}
