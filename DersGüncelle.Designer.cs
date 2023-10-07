namespace veri_ödevi1._1
{
    partial class DersGüncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersGüncelle));
            this.guncelleDersKoduGirtxt = new System.Windows.Forms.TextBox();
            this.guncelleDersiGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guncelleDersKoduGirtxt
            // 
            this.guncelleDersKoduGirtxt.Location = new System.Drawing.Point(275, 158);
            this.guncelleDersKoduGirtxt.Name = "guncelleDersKoduGirtxt";
            this.guncelleDersKoduGirtxt.Size = new System.Drawing.Size(113, 22);
            this.guncelleDersKoduGirtxt.TabIndex = 1;
            // 
            // guncelleDersiGuncelle
            // 
            this.guncelleDersiGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guncelleDersiGuncelle.BackgroundImage")));
            this.guncelleDersiGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guncelleDersiGuncelle.ForeColor = System.Drawing.Color.White;
            this.guncelleDersiGuncelle.Location = new System.Drawing.Point(252, 215);
            this.guncelleDersiGuncelle.Name = "guncelleDersiGuncelle";
            this.guncelleDersiGuncelle.Size = new System.Drawing.Size(173, 61);
            this.guncelleDersiGuncelle.TabIndex = 2;
            this.guncelleDersiGuncelle.Text = "Dersi Güncelle";
            this.guncelleDersiGuncelle.UseVisualStyleBackColor = true;
            this.guncelleDersiGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.guncelleDersiGuncelle);
            this.groupBox1.Controls.Add(this.guncelleDersKoduGirtxt);
            this.groupBox1.Location = new System.Drawing.Point(41, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 377);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Güncellemek istediğiniz dersin kodunu giriniz:";
            // 
            // DersGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DersGüncelle";
            this.Text = "DersGüncelle";
            this.Load += new System.EventHandler(this.DersGüncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button guncelleDersiGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox guncelleDersKoduGirtxt;
        private System.Windows.Forms.Label label1;
    }
}