using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Bitmap kaynak, islem;
        public Form1()
        {

            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = kaynak;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void ortalamaAverageDeğerAlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32((renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void lumaAlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // G = (R * 0.3 + G * 0.59 + B * 0.11) 
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32((renkliRenk.R *0.3) + (renkliRenk.G * 0.59) + (renkliRenk.G * 0.11));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            pictureBox2.Image = islem;
        }

        private void açıklıkDesaturationAlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //G=(max(R,G,B)+min(R,G,B) )  / 2
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int grimax = renkliRenk.R;
                    if (grimax < renkliRenk.B)
                    {
                        grimax = renkliRenk.B;
                    }
                    if (grimax < renkliRenk.G)
                    {
                        grimax = renkliRenk.G;
                    }

                    int grimin = renkliRenk.R;
                    if (grimin < renkliRenk.B)
                    {
                        grimin = renkliRenk.B;
                    }
                    if (grimin < renkliRenk.G)
                    {
                        grimin = renkliRenk.G;
                    }
                    int gri =Convert.ToInt32 ((grimin + grimax) / 2);

                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                    
                }
            }

            pictureBox2.Image = islem;
        }

        private void kırmızıRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32(renkliRenk.R);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            pictureBox2.Image = islem;
        }

        private void yeşilGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32(renkliRenk.G);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            pictureBox2.Image = islem;
        }

        private void maviBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32(renkliRenk.B);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            pictureBox2.Image = islem;
        }

        private void bT709AlgoritmsasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32((renkliRenk.R * 0.2125) + (renkliRenk.G * 0.7154) + (renkliRenk.G * 0.072));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            pictureBox2.Image = islem;
        }
    }
}
