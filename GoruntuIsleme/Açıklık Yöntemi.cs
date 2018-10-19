using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace GoruntuIsleme
{
    public partial class Form7 : Form
    {
        Bitmap kaynak, islem;
        public Form7()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for(int y = 0; y < yukseklik; y++)
            {
                for(int x = 0; x < genislik; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    int maksimum = Math.Max(orjinal.R, orjinal.G);
                    int sonmaksimum = Math.Max(maksimum, orjinal.B);
                    int minimum = Math.Min(orjinal.R, orjinal.G);
                    int sonminumum = Math.Min(orjinal.B, minimum);
                    int sonuc = (sonmaksimum + sonminumum) / 2;
                    Color sonrenk = Color.FromArgb(sonuc, sonuc, sonuc);
                    islem.SetPixel(x, y, sonrenk);

                }
            }islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.jpeg;*.png;*.jpg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }
    }
}
