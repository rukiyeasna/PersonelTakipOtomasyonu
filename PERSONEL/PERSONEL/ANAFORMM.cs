using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PERSONEL
{
    public partial class ANAFORMM : Form
    {
        public ANAFORMM()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kayit = new Form2();
            kayit.Show();
            this.Hide();
        }      
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            arama arama = new arama();
            arama.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            silme_güncelleme sil_güncelle = new silme_güncelleme();
            sil_güncelle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanici_girisi giris = new kullanici_girisi();
            giris.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            raporlama rapor = new raporlama();
            rapor.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

