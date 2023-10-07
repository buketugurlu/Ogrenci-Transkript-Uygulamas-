namespace veri_ödevi1._1
{
    partial class Dersler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dersler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.derslerDataView = new System.Windows.Forms.DataGridView();
            this.goruntuleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.derslerDataView);
            this.groupBox1.Controls.Add(this.goruntuleBtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Listesi";
            // 
            // derslerDataView
            // 
            this.derslerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.derslerDataView.Location = new System.Drawing.Point(20, 32);
            this.derslerDataView.Name = "derslerDataView";
            this.derslerDataView.RowHeadersWidth = 51;
            this.derslerDataView.RowTemplate.Height = 24;
            this.derslerDataView.Size = new System.Drawing.Size(705, 269);
            this.derslerDataView.TabIndex = 5;
            // 
            // goruntuleBtn
            // 
            this.goruntuleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goruntuleBtn.BackgroundImage")));
            this.goruntuleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goruntuleBtn.ForeColor = System.Drawing.Color.White;
            this.goruntuleBtn.Location = new System.Drawing.Point(295, 317);
            this.goruntuleBtn.Name = "goruntuleBtn";
            this.goruntuleBtn.Size = new System.Drawing.Size(169, 61);
            this.goruntuleBtn.TabIndex = 1;
            this.goruntuleBtn.Text = "Görüntüle";
            this.goruntuleBtn.UseVisualStyleBackColor = true;
            this.goruntuleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dersler";
            this.Text = "Dersler";
            this.Load += new System.EventHandler(this.Dersler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goruntuleBtn;
        private System.Windows.Forms.DataGridView derslerDataView;
    }
}