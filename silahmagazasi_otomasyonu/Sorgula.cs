using System;
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
    public partial class Sorgula : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public Sorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa f1 = new Anasayfa();
            f1.ShowDialog();
            this.Close();
        }

        private void listele_buton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(silahid_Textbox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_id = " + silahid_Textbox.Text + ";", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else if (!string.IsNullOrWhiteSpace(adi_Textbox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_adi = '" + adi_Textbox.Text + "';", baglanti);
                DataTable tablo1 = new DataTable();
                da.Fill(tablo1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
            }
            else if (!string.IsNullOrWhiteSpace(model_combobox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_modeli = '" + model_combobox.Text + "';", baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            else if (!string.IsNullOrWhiteSpace(fiyati_Textbox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_fiyati = '" + fiyati_Textbox.Text + "';", baglanti);
                DataTable tablo2 = new DataTable();
                da.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            else if (!string.IsNullOrWhiteSpace(ulke_combobox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_ulkesi = '" + ulke_combobox.Text + "';", baglanti);
                DataTable tablo3 = new DataTable();
                da.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
                baglanti.Close();
            }
            else if (!string.IsNullOrWhiteSpace(atishizi_textbox.Text))
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM silahlar WHERE silah_atishizi = " + atishizi_textbox.Text + ";", baglanti);
                DataTable tablo4 = new DataTable();
                da.Fill(tablo4);
                dataGridView1.DataSource = tablo4;
                baglanti.Close();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
