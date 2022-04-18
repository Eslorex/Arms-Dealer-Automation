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
    public partial class MermiEkleSil : Form
    {
        public MermiEkleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO mermiler(mermi_tipi,mermi_kalibresi,mermi_stoksayisi,tedarikciNo,mermi_fiyati) VALUES (@mermi_tipi,@mermi_kalibresi,@mermi_stoksayisi,@tedarikciNo,@mermi_fiyati)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@mermi_tipi", mermitipi_textbox.Text);
            komut.Parameters.AddWithValue("@mermi_kalibresi", mermikalibresi_textbox.Text);
            komut.Parameters.AddWithValue("@mermi_stoksayisi", stokarttirma_textbox.Text);
            komut.Parameters.AddWithValue("@tedarikciNo", tedarikciNo_textbox.Text);
            komut.Parameters.AddWithValue("@mermi_fiyati", mermifiyati_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM mermiler WHERE mermi_id = @mermi_id";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@silah_id", Convert.ToInt32(mermiid_textbox.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void MermiEkleSil_Load(object sender, EventArgs e)
        {

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
