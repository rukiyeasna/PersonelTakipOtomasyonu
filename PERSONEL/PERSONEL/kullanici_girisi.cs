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
    public partial class kullanici_girisi : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public kullanici_girisi()
        {
            InitializeComponent();
        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            ANAFORMM menu = new ANAFORMM();
            menu.Show();
            this.Hide();
        }
        public void calistir(string sqll)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sqll,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ALANLARI BOŞ BIRAKMAYINIZ");
            }
            else
            {
                if (textBox2.Text == textBox3.Text)
                {
                    string sql = "insert into kullanici(kullanici_adi,sifre)values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    calistir(sql);
                    MessageBox.Show("KAYIT İŞLEMİ GERÇEKLEŞTİRİLMİŞTİR.");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("ŞİFRELERİ AYNI GİRİNİZ.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {                
                string sql = "delete from kullanici where kullanici_adi='" + textBox1.Text + "'" + " and sifre='" + textBox2.Text + "'";             
                MessageBox.Show("KULLANICI SİLİNMİŞTİR");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void kullanici_girisi_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar='*';
        }
    }
}
