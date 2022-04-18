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
    public partial class EklentiEkleSil : Form
    {
        public EklentiEkleSil()
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
            string ekle_sorgu = "INSERT INTO eklentiler(eklenti_adi,eklenti_fiyati,tedarikciNo,eklenti_stoksayisi) VALUES (@eklenti_adi,@eklenti_fiyati,@tedarikciNo,@eklenti_stoksayisi)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@eklenti_adi", eklentiadi_textbox.Text);
            komut.Parameters.AddWithValue("@eklenti_fiyati", eklentifiyati_textbox.Text);
            komut.Parameters.AddWithValue("@tedarikciNo", tedarikciNo_textbox.Text);
            komut.Parameters.AddWithValue("@eklenti_stoksayisi", stokarttirma_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM eklentiler WHERE eklenti_id = @eklenti_id";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@eklenti_id", Convert.ToInt32(mermiid_textbox.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
