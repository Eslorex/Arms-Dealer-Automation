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
    public partial class stoksayisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public stoksayisi()
        {
            InitializeComponent();
        }

        private void geri_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Duzenle f5 = new Duzenle();
            f5.ShowDialog();
            this.Close();
        }

        private void arttir_buton_Click(object sender, EventArgs e)
        {
            string arttir_sorgu = "UPDATE silahlar SET silah_stoksayisi= (silah_stoksayisi + " + miktar_Textbox.Text + ") WHERE silah_id =" + silahid_Textbox.Text + ";";
            komut = new SqlCommand(arttir_sorgu, baglanti);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void azalt_buton_Click(object sender, EventArgs e)
        {
            string azalt_sorgu = "UPDATE silahlar SET silah_stoksayisi= (silah_stoksayisi - " + miktar_Textbox.Text + ") WHERE silah_id =" + silahid_Textbox.Text + ";";
            komut = new SqlCommand(azalt_sorgu, baglanti);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
