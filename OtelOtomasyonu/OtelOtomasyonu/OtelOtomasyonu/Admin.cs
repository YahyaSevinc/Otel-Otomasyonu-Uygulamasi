using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKAd.Text=="admin" && txtSifre.Text == "1453")
            {
                AnaMenu an = new AnaMenu();
                an.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                {
                    
                    txtSifre.PasswordChar = '\0';
                }
                
                else
                {
                    txtSifre.PasswordChar = '*';
                }
            }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        }
    }

