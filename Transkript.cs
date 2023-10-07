using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace veri_ödevi1._1
{
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");
        private void Transkript_Load(object sender, EventArgs e)
        {
            string sorgu = ("select * from DersTablosu");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gano1 ganoListBox = new gano1();
            ganoListBox.ganoTablo.Items.Clear();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select  deger, kredi from ganohesapla", baglanti);
            DataTable datatable = new DataTable();
            adtr.Fill(datatable);
            float toplam = 0;
            float toplamKredi = 0;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                ganoListBox.ganoTablo.Items.Add(datatable.Rows[i][0] + "   " + datatable.Rows[i][1]);
                toplam += Convert.ToInt64(datatable.Rows[i][0]) * Convert.ToInt64(datatable.Rows[i][1]);
                toplamKredi += Convert.ToInt64(datatable.Rows[i][1]);
            }
            toplam /= toplamKredi;
            ganoNotuTxt.Text = toplam.ToString();
            baglanti.Close();
        }
    }
}
