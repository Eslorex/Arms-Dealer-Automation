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
    public partial class SilahEkleSil : Form
    {
        public SilahEkleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO silahlar(silah_adi,silah_modeli,silah_ulkesi,silah_fiyati,silah_atishizi,silah_kalibresi,silah_stoksayisi) VALUES (@silah_adi, @silah_modeli, @silah_ulkesi, @silah_fiyati, @silah_atishizi, @silah_kalibresi, @silah_stoksayisi)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@silah_adi", adi_Textbox.Text);
            komut.Parameters.AddWithValue("@silah_modeli", model_combobox.Text);
            komut.Parameters.AddWithValue("@silah_ulkesi", ulke_combobox.Text);
            komut.Parameters.AddWithValue("@silah_fiyati", fiyati_Textbox.Text);
            komut.Parameters.AddWithValue("@silah_atishizi", atishizi_textbox.Text);
            komut.Parameters.AddWithValue("@silah_kalibresi", kalibresi_Textbox.Text);
            komut.Parameters.AddWithValue("@silah_stoksayisi", stokarttirma_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM silahlar WHERE silah_id = @silah_id";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@silah_id", Convert.ToInt32(silahid_Textbox.Text));
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
