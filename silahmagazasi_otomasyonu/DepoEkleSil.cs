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
    public partial class DepoEkleSil : Form
    {
        public DepoEkleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkleSil f1 = new EkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO depolar(depoAdres, depoBuyukluk, depoTelNo) VALUES (@depoAdres, @depoBuyukluk, @depoTelNo)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@depoAdres", depoAdres_textbox.Text);
            komut.Parameters.AddWithValue("@depoBuyukluk", depoBuyukluk_comboBox1.Text);
            komut.Parameters.AddWithValue("@depoTelNo", depoTelNo_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM depolar WHERE depoNo = @depoNo";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@depoNo", Convert.ToInt32(depoID_textbox.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
