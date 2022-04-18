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
    public partial class Duzenle : Form
    {

        public Duzenle()
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stoksayisi f6 = new stoksayisi();
            f6.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fiyatdegistir f7 = new fiyatdegistir();
            f7.ShowDialog();
            this.Close();
        }
    }
}
