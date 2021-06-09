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
    public partial class Form2 : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public Form2()
        {
            InitializeComponent();
        }
        public void calistir(string sqll)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sqll,baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("KAYIT GERÇEKLEŞTİRİLMİŞTİR.");
            baglanti.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ANAFORMM menu = new ANAFORMM();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into kayitlar values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "','" + comboBox4.Text + "','" + comboBox7.Text + "','" + textBox19.Text + "','" + textBox20.Text + "'," + Int32.Parse(textBox21.Text) + ",'" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox5.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "'," + Int32.Parse(textBox15.Text) + "," + Int32.Parse(textBox16.Text) + ")";            
            calistir(sql);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;

        }      
        
    }
}
