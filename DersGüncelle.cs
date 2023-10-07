using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veri_ödevi1._1
{
    public partial class DersGüncelle : Form
    {
        public DersGüncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");

        public string yazi;
        private void DersGüncelle_Load(object sender, EventArgs e)
        {          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            GüncellenecekBilgiler güncellenecekBilgiler = new GüncellenecekBilgiler();
            baglanti.Open();
            string kayit = "Select * From DersTablosu Where DersKodu=@DersKodu";
            NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);
            
            komut.Parameters.AddWithValue("@DersKodu", guncelleDersKoduGirtxt.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            güncellenecekBilgiler.guncellenecekDersdt.DataSource = dt;
            baglanti.Close();

            yazi = guncelleDersKoduGirtxt.Text;
            
            güncellenecekBilgiler.textBox1.Text = yazi;

            güncellenecekBilgiler.Show();
            
        }
    }
}
