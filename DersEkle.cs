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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");
       
        private void DersEkle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ekleKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into DersTablosu (DersKodu, DersAdi, Kredi, AKTS, OgretimUyesi, Donem, HarfNotu) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", ekleDersKodutxt.Text);
            komut.Parameters.AddWithValue("@p2", ekleDersAditxt.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(ekleDersinKredisitxt.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(ekleAKTStxt.Text));
            komut.Parameters.AddWithValue("@p5", ekleOgretimUyesitxt.Text);
            komut.Parameters.AddWithValue("@p6", ekleDonemtxt.Text);
            komut.Parameters.AddWithValue("@p7", ekleHarfNotutxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders başarıyla eklenmiştir.");
        }
    }
}
