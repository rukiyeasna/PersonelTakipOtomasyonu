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
    public partial class silme_güncelleme : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public silme_güncelleme()
        {
            InitializeComponent();
        }
        public void listele(string sqll)
        {
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adptr = new OleDbDataAdapter(sqll, baglanti);
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

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
            string sql = "select * from kayitlar where tc like '" + textBox22.Text + "%'";
            listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from kayitlar where tc='"+textBox22.Text+"'";
            calistir(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ANAFORMM menu = new ANAFORMM();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = " update kayitlar set adi='" + textBox2.Text + "',soyadi='" + textBox3.Text + "',dogum_yeri='" + comboBox1.Text + "',dogum_tarihi='" + textBox4.Text + "',memleket='" + comboBox2.Text + "',cinsiyet='" + comboBox3.Text + "',meslek='" + textBox5.Text + "',egitim_durumu='" + comboBox4.Text + "',medeni_hali='" + comboBox7.Text + "',anne_adi='" + textBox19.Text + "',baba_adi='" + textBox20.Text + "',cocuk_sayisi=" + textBox21.Text + ",ise_giris_tarihi='" + textBox6.Text + "',birim='" + textBox7.Text + "',emekli_mi='" + comboBox5.Text + "',cep_tel='" + textBox8.Text + "',ev_tel='" + textBox9.Text + "',diger_tel='" + textBox10.Text + "',e_posta='" + textBox11.Text + "',adres='" + textBox12.Text + "',banka='" + textBox13.Text + "',sube='" + textBox14.Text + "',hesap_no=" + textBox15.Text + ",maas=" + textBox16 + " where tc='" + textBox1.Text + "'";
            calistir(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox19.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox20.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox21.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
            
            
            
            


        }

        
    }
}
