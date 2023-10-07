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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veri_ödevi1._1
{
    public partial class DersSilme : Form
    {
        public DersSilme()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");
        public string dersKoduAl;
        
        private void DersSilme_Load(object sender, EventArgs e)
        {
                      
        }

        private void silmeDersiSil_Click(object sender, EventArgs e)
        {
          if(MessageBox.Show("Dersi silmek istediğinizden emin misiniz?","SİL",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("delete from DersTablosu where DersKodu=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", silmeDersKoduAl.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ders kaydı başarıyla silinmiştir.");
            }
            else
            {
                MessageBox.Show("İşlem iptal edilmiştir.");
                this.Close();
            }

        }
    }
}
