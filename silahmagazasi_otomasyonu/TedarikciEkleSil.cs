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
    public partial class TedarikciEkleSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public TedarikciEkleSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkleSil f1 = new EkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO tedarikciler(tedarikciAdi, tedarikciTelNo) VALUES (@tedarikciAdi, @tedarikciTelNo)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@tedarikciAdi", tedarikciAdi_textbox.Text);
            komut.Parameters.AddWithValue("@tedarikciTelNo", tedarikciTelNo_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM tedarikciler WHERE tedarikciNo = @tedarikciNo";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@tedarikciNo", Convert.ToInt32(tedarikciID_textbox.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
