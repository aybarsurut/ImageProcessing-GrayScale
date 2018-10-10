namespace WindowsFormsApp3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709AlgoritmsasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lumaAlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.grayScaleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT709AlgoritmsasıToolStripMenuItem,
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem,
            this.lumaAlgoritmasıToolStripMenuItem,
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem,
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem});
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            // 
            // bT709AlgoritmsasıToolStripMenuItem
            // 
            this.bT709AlgoritmsasıToolStripMenuItem.Name = "bT709AlgoritmsasıToolStripMenuItem";
            this.bT709AlgoritmsasıToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.bT709AlgoritmsasıToolStripMenuItem.Text = "BT-709 Algoritmsası";
            this.bT709AlgoritmsasıToolStripMenuItem.Click += new System.EventHandler(this.bT709AlgoritmsasıToolStripMenuItem_Click);
            // 
            // ortalamaAverageDeğerAlgoritmasıToolStripMenuItem
            // 
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem.Name = "ortalamaAverageDeğerAlgoritmasıToolStripMenuItem";
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem.Text = "Ortalama (Average) Değer Algoritması";
            this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.ortalamaAverageDeğerAlgoritmasıToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 387);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(373, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 387);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lumaAlgoritmasıToolStripMenuItem
            // 
            this.lumaAlgoritmasıToolStripMenuItem.Name = "lumaAlgoritmasıToolStripMenuItem";
            this.lumaAlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.lumaAlgoritmasıToolStripMenuItem.Text = "Luma Algoritması";
            this.lumaAlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.lumaAlgoritmasıToolStripMenuItem_Click);
            // 
            // açıklıkDesaturationAlgoritmasıToolStripMenuItem
            // 
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem.Name = "açıklıkDesaturationAlgoritmasıToolStripMenuItem";
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem.Text = "Açıklık (Desaturation) Algoritması ";
            this.açıklıkDesaturationAlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.açıklıkDesaturationAlgoritmasıToolStripMenuItem_Click);
            // 
            // kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem
            // 
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kırmızıRToolStripMenuItem,
            this.yeşilGToolStripMenuItem,
            this.maviBToolStripMenuItem});
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem.Name = "kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem";
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem.Text = "Kanal çıkarımı (Extract Channel) Algoritması ";
            // 
            // kırmızıRToolStripMenuItem
            // 
            this.kırmızıRToolStripMenuItem.Name = "kırmızıRToolStripMenuItem";
            this.kırmızıRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kırmızıRToolStripMenuItem.Text = "Kırmızı(R)";
            this.kırmızıRToolStripMenuItem.Click += new System.EventHandler(this.kırmızıRToolStripMenuItem_Click);
            // 
            // yeşilGToolStripMenuItem
            // 
            this.yeşilGToolStripMenuItem.Name = "yeşilGToolStripMenuItem";
            this.yeşilGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeşilGToolStripMenuItem.Text = "Yeşil(G)";
            this.yeşilGToolStripMenuItem.Click += new System.EventHandler(this.yeşilGToolStripMenuItem_Click);
            // 
            // maviBToolStripMenuItem
            // 
            this.maviBToolStripMenuItem.Name = "maviBToolStripMenuItem";
            this.maviBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maviBToolStripMenuItem.Text = "Mavi(B)";
            this.maviBToolStripMenuItem.Click += new System.EventHandler(this.maviBToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709AlgoritmsasıToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ortalamaAverageDeğerAlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaAlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkDesaturationAlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıExtractChannelAlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviBToolStripMenuItem;
    }
}

