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
    public partial class EkleSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESLOREX\\SQLEXPRESS;Initial Catalog=silahmagaza;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        Anasayfa anasayfa = new Anasayfa(); 
        public EkleSil()
        {
            InitializeComponent();    
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa f1 = new Anasayfa();
            f1.ShowDialog();
            this.Close();
        }
        private void Ekleme_butonu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SilahEkleSil f1 = new SilahEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MermiEkleSil f1 = new MermiEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EklentiEkleSil f1 = new EklentiEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepoEkleSil f1 = new DepoEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TedarikciEkleSil f1 = new TedarikciEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalisanEkleSil f1 = new CalisanEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagazaEkleSil f1 = new MagazaEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriEkleSil f1 = new MusteriEkleSil();
            f1.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaturaEkleSil f1 = new FaturaEkleSil();
            f1.ShowDialog();
            this.Close();
        }
    }
}
