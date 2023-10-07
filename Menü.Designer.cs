namespace veri_ödevi1._1
{
    partial class Menü
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menü));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derslerToolStripMenuItem,
            this.dersİşlemleriToolStripMenuItem,
            this.transkriptToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // dersİşlemleriToolStripMenuItem
            // 
            this.dersİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersEkleToolStripMenuItem,
            this.dersGüncelleToolStripMenuItem,
            this.dersSilmeToolStripMenuItem});
            this.dersİşlemleriToolStripMenuItem.Name = "dersİşlemleriToolStripMenuItem";
            this.dersİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.dersİşlemleriToolStripMenuItem.Text = "Ders İşlemleri";
            // 
            // dersEkleToolStripMenuItem
            // 
            this.dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            this.dersEkleToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dersEkleToolStripMenuItem.Text = "Ders Ekle";
            this.dersEkleToolStripMenuItem.Click += new System.EventHandler(this.dersEkleToolStripMenuItem_Click);
            // 
            // dersGüncelleToolStripMenuItem
            // 
            this.dersGüncelleToolStripMenuItem.Name = "dersGüncelleToolStripMenuItem";
            this.dersGüncelleToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dersGüncelleToolStripMenuItem.Text = "Ders Güncelle";
            this.dersGüncelleToolStripMenuItem.Click += new System.EventHandler(this.dersGüncelleToolStripMenuItem_Click);
            // 
            // dersSilmeToolStripMenuItem
            // 
            this.dersSilmeToolStripMenuItem.Name = "dersSilmeToolStripMenuItem";
            this.dersSilmeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dersSilmeToolStripMenuItem.Text = "Ders Silme";
            this.dersSilmeToolStripMenuItem.Click += new System.EventHandler(this.dersSilmeToolStripMenuItem_Click);
            // 
            // transkriptToolStripMenuItem
            // 
            this.transkriptToolStripMenuItem.Name = "transkriptToolStripMenuItem";
            this.transkriptToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.transkriptToolStripMenuItem.Text = "Transkript";
            this.transkriptToolStripMenuItem.Click += new System.EventHandler(this.transkriptToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menü";
            this.Text = "Anamenü";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transkriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersEkleToolStripMenuItem;
    }
}

