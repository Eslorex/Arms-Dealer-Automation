﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silahmagazasi_otomasyonu
{
    public partial class FaturaEkleSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public FaturaEkleSil()
        {
            InitializeComponent();
        }

        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO faturalar(musteriNo, fatura_tipi,siparisNo , fatura_tarihi) VALUES (@musteriNo, @fatura_tipi,@siparisNo, @fatura_tarihi,)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriNo", musterino_textbox.Text);
            komut.Parameters.AddWithValue("@fatura_tipi", faturatipi_textbox.Text);
            komut.Parameters.AddWithValue("@siparisNo", siparisno_textbox.Text);
            komut.Parameters.AddWithValue("@fatura_tarihi", dateTimePicker1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM faturalar WHERE faturaNo = @faturaNo";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@faturaNo", Convert.ToInt32(faturaid_textbox.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkleSil f1 = new EkleSil();
            f1.ShowDialog();
            this.Close();
        }
    }
}
