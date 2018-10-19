using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form11 : Form
    {
        Bitmap kaynak1, kaynak2, islem;
        public Form11()
        {
            InitializeComponent();
        }

        private void ikiliIşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak1 = new Bitmap(openFileDialog1.FileName);
                kaynakBox1.Image = kaynak1;
            }

        }

        private void toplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                int yukseklik = kaynak1.Height;
                int genislik = kaynak1.Width;
            int red, green, blue;
                islem = new Bitmap(genislik, yukseklik);

                for (int y = 0; y < yukseklik; y++)
                {
                    for (int x = 0; x < genislik; x++)
                    {
                    Color renk1 = kaynak1.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    red = renk1.R + renk2.R;
                    green = renk1.G + renk2.G;
                    blue = renk1.B + renk2.B;

                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;

                    Color yenirenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yenirenk);


                    }
                }
                islemBox.Image = islem;
            }

        private void çıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yukseklik = kaynak1.Height;
            int genislik = kaynak1.Width;
            int red, green, blue;
            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renk1 = kaynak1.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    red = renk1.R - renk2.R;
                    green = renk1.G - renk2.G;
                    blue = renk1.B - renk2.B;

                    if (red<0) red = 0;
                    if (green <0) green = 0;
                    if (blue <0) blue = 0;

                    Color yenirenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yenirenk);


                }
            }
            islemBox.Image = islem;
        }

        private void kesişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yukseklik = kaynak1.Height;
            int genislik = kaynak1.Width;
            int red, green, blue;
            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renk1 = kaynak1.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);


                    if (renk1.R > renk2.R) { red = renk2.R;}
                    else { red = renk1.R; }

                    if (renk1.G > renk2.G) { green = renk2.G; }
                    else { green = renk1.G; }
                    if (renk1.B > renk2.B) { blue = renk2.B; }
                    else { blue = renk1.B; }
                    Color yenirenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yenirenk);


                }
            }
            islemBox.Image = islem;
        }

        private void birleşimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yukseklik = kaynak1.Height;
            int genislik = kaynak1.Width;
            int red, green, blue;
            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renk1 = kaynak1.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);


                    if (renk1.R < renk2.R) { red = renk2.R; }
                    else { red = renk1.R; }

                    if (renk1.G < renk2.G) { green = renk2.G; }
                    else { green = renk1.G; }
                    if (renk1.B < renk2.B) { blue = renk2.B; }
                    else { blue = renk1.B; }
                    Color yenirenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yenirenk);


                }
            }
            islemBox.Image = islem;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fotoğrafıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog2.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak2 = new Bitmap(openFileDialog2.FileName);
                kaynakBox2.Image = kaynak2;

            }
        }
    }
}
