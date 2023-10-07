namespace veri_ödevi1._1
{
    partial class DersSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersSilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.silmeDersiSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.silmeDersKoduAl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.silmeDersKoduAl);
            this.groupBox1.Controls.Add(this.silmeDersiSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // silmeDersiSil
            // 
            this.silmeDersiSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silmeDersiSil.BackgroundImage")));
            this.silmeDersiSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silmeDersiSil.ForeColor = System.Drawing.Color.White;
            this.silmeDersiSil.Location = new System.Drawing.Point(389, 191);
            this.silmeDersiSil.Name = "silmeDersiSil";
            this.silmeDersiSil.Size = new System.Drawing.Size(100, 36);
            this.silmeDersiSil.TabIndex = 2;
            this.silmeDersiSil.Text = "Dersi Sil";
            this.silmeDersiSil.UseVisualStyleBackColor = true;
            this.silmeDersiSil.Click += new System.EventHandler(this.silmeDersiSil_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz dersin kodunu giriniz :\r\n\r\n";
            // 
            // silmeDersKoduAl
            // 
            this.silmeDersKoduAl.Location = new System.Drawing.Point(389, 113);
            this.silmeDersKoduAl.Name = "silmeDersKoduAl";
            this.silmeDersKoduAl.Size = new System.Drawing.Size(100, 22);
            this.silmeDersKoduAl.TabIndex = 3;
            // 
            // DersSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DersSilme";
            this.Text = "DersSilme";
            this.Load += new System.EventHandler(this.DersSilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button silmeDersiSil;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox silmeDersKoduAl;
    }
}