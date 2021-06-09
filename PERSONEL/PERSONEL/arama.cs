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
    public partial class arama : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DENEME.accdb");
        public arama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANAFORMM menu = new ANAFORMM();
            menu.Show();
            this.Hide();
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
        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "select * from kayitlar where tc='" + textBox1.Text + "'";
            listele(sql);
        }
    }
}
