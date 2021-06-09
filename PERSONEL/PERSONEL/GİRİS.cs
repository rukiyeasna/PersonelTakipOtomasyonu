using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PERSONEL
{
    public partial class GİRİS : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public GİRİS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!");
            }
            else
            {
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM kullanici WHERE kullanici_adi='" + textBox1.Text.ToString() + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    if (textBox1.Text.ToString() == okuyucu["kullanici_adi"].ToString())
                    {
                        if (textBox2.Text.ToString() == okuyucu["sifre"].ToString())
                        {
                            MessageBox.Show("Giriş Başarılı");
                            ANAFORMM menu = new ANAFORMM();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Bu Kullanıcı Adı Şifresi Yanlıştır!!");
                        }
                    }
                }
                baglanti.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GİRİS_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar='*';
        }
    }
}
