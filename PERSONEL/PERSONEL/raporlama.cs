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
    public partial class raporlama : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public raporlama()
        {
            InitializeComponent();
        }
        public void listele(string sqll)
        {
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adptr = new OleDbDataAdapter(sqll,baglanti);
            adptr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ANAFORMM menu = new ANAFORMM();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                int s1 = Int32.Parse(textBox1.Text);
                if (radioButton7.Checked == true)
                {
                    string sqll = "select maas from kayitlar where >= '" + s1 + "' order by maas asc";
                }
                if (radioButton8.Checked == true)
                {
                    string sqll = "select maas from kayitlar where < '" + s1 + "' order by maas desc";
                }
            }
            string sql = "select * from kayitlar";
            listele(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                string sql = "select * from kayitlar where cinsiyet='" + textBox1.Text + "'";
                listele(sql);
            }
            if (radioButton2.Checked == true)
            {
                string sql = "select * from kayitlar where  maas=" + textBox1.Text + "";
                listele(sql);
            }
            if (radioButton3.Checked == true)
            {
                string sql = "select * from kayitlar where  birim like '" + textBox1.Text + "%'";
                listele(sql);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select adi,soyadi,birim,cinsiyet,meslek from kayitlar order by birim asc";
            listele(sql);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select * from kayitlar order by adi asc";
            listele(sql);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string sqll = "select adi,soyadi,meslek,maas from kayitlar order by maas asc";
            listele(sqll);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
