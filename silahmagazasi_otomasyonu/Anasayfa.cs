using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace silahmagazasi_otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public void gridyenile()
        {
            this.silahlarTableAdapter.Fill(this.silahmagazaDataSet.silahlar);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=silahmagaza;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            gridyenile();
        }

        private void ekle_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkleSil f2 = new EkleSil();
            f2.ShowDialog();
            this.Close();
        }

        private void duzenle_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Duzenle f3 = new Duzenle();
            f3.ShowDialog();
            this.Close();
        }

        private void sorgula_buton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorgula f3 = new Sorgula();
            f3.ShowDialog();
            this.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
