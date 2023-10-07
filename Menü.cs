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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Dersler;User Id=postgres;Password=1234");
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transkriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transkript transkript = new Transkript();
            transkript.MdiParent = this;
            transkript.Show();
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersGüncelle dersGüncelle = new DersGüncelle();
            dersGüncelle.MdiParent = this;
            dersGüncelle.Show();
        }

        private void dersSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersSilme dersSilme = new DersSilme();
            dersSilme.MdiParent = this;
            dersSilme.Show();
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            dersler.MdiParent = this;
            dersler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.MdiParent = this;
            dersEkle.Show();
        }
    }

}
