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
    public partial class fiyatdegistir : Form
    {
        public fiyatdegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Duzenle f5 = new Duzenle();
            f5.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
            SqlCommand komut;
            SqlDataAdapter da;

            string fiyatdegis_sorgu = "UPDATE silahlar SET silah_fiyati = " + fiyatdegisid_Textbox.Text + " WHERE silah_id = " + silah_id_Textbox.Text + "; ";
            komut = new SqlCommand(fiyatdegis_sorgu, baglanti);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
