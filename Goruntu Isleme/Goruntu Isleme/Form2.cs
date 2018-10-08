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

namespace Goruntu_Isleme
{
    public partial class Form2 : Form
    {
        Bitmap kaynak_resim, islem;
        public Form2()
        {
            InitializeComponent();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    double gri = (renkliRenk.R * 0.2125) + (renkliRenk.G * 0.7154) + (renkliRenk.B * 0.072);
                    int renk = Convert.ToInt32(gri);
                    Color griRenk = Color.FromArgb(renk, renk, renk);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    int gri = (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    double gri = (renkliRenk.R * 0.3) + (renkliRenk.G * 0.59) + (renkliRenk.B * 0.11);
                    int renk = Convert.ToInt32(gri);
                    Color griRenk = Color.FromArgb(renk, renk, renk);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    int gri = renkliRenk.R;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }


        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            saveFileDialog1.Filter = "JPG|*.jpg";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            ImageFormat format2 = ImageFormat.Jpeg;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
                islem.Save(saveFileDialog1.FileName, format2);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    int gri = renkliRenk.R;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void gÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    int gri = renkliRenk.G;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void bÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak_resim.Width;
            int yuk = kaynak_resim.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak_resim.GetPixel(x, y);
                    int gri = renkliRenk.B;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void resimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak_resim = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = kaynak_resim;
            }
        }
    }
}
