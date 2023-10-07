using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace veri_ödevi1._1
{
    public partial class GüncellenecekBilgiler : Form
    {
        public GüncellenecekBilgiler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");
        
        private void GüncellenecekBilgiler_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guncellenecekKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("update derstablosu set DersAdi=@p1, AKTS=@p2, Kredi=@p3, OgretimUyesi=@p4, Donem=@p5, HarfNotu=@p6 where DersKodu=@p7", baglanti);
            komut4.Parameters.AddWithValue("@p1", guncellenecekDersAditxt.Text);
            komut4.Parameters.AddWithValue("@p2", int.Parse(guncellenecekAKTStxt.Text));
            komut4.Parameters.AddWithValue("@p3", int.Parse(guncellenecekDersinKredisitxt.Text));
            komut4.Parameters.AddWithValue("@p4", guncellenecekOgretimUyesitxt.Text);
            komut4.Parameters.AddWithValue("@p5", guncellenecekDonemtxt.Text);
            komut4.Parameters.AddWithValue("@p6", guncellenecekHarfNotutxt.Text);
            komut4.Parameters.AddWithValue("@p7", textBox1.Text);

            komut4.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ders güncelleme başarıyla tamamlandı");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
