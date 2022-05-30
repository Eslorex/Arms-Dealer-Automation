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
    public partial class MusteriEkleSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;

        public MusteriEkleSil()
        {
            InitializeComponent();
        }

        private void MusteriEkleSil_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO musteriler(musteriAdi, musteriTelNo, musteriMail) VALUES (@musteriAdi, @musteriTelNo, @musteriMail)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriAdi", musteriadi_textbox.Text);
            komut.Parameters.AddWithValue("@musteriTelNo", musteritelno_textbox.Text);
            komut.Parameters.AddWithValue("@musteriMail", musterimail_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM musteriler WHERE musteriNo = @musteriNo";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriNo", Convert.ToInt32(musteriid_textbox.Text));
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
