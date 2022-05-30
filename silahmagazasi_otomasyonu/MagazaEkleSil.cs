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
    public partial class MagazaEkleSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public MagazaEkleSil()
        {
            InitializeComponent();
        }

        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {
            string ekle_sorgu = "INSERT INTO magazalar(magazaAdres,magazaTelNo) VALUES (@magazaAdres,@magazaTelNo)";
            komut = new SqlCommand(ekle_sorgu, baglanti);
            komut.Parameters.AddWithValue("@magazaAdres", magazaadres_textbox.Text);
            komut.Parameters.AddWithValue("@magazaTelNo", magazaTelNo_textbox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            string sil_sorgu = "DELETE FROM magazalar WHERE magaza_id = @magaza_id";
            komut = new SqlCommand(sil_sorgu, baglanti);
            komut.Parameters.AddWithValue("@magaza_id", Convert.ToInt32(magazaid_textbox.Text));
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
