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
    public partial class Form8 : Form
    {
        Bitmap islem,kaynak;
        public Form8()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
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
            // Kırmızı Kanal Çıkarımı
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for(int y = 0; y < yukseklik; y++)
            {
                for(int x = 0; x < genislik; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color son = Color.FromArgb(orjinal.R, orjinal.R, orjinal.R);
                    islem.SetPixel(x, y, son);
                    

                }
            }islemBox.Image = islem;
        }

        private void button3_Click(object sender, EventArgs e)
            //Yeşil Kanal Çıkarımı
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color son = Color.FromArgb(orjinal.G,orjinal.G,orjinal.G);
                    islem.SetPixel(x, y, son);

                }
            }
            islemBox.Image = islem;
        }

        private void button2_Click(object sender, EventArgs e)
            //Mavi Kanal Çıkarımı
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color son = Color.FromArgb(orjinal.B,orjinal.B,orjinal.B);
                    islem.SetPixel(x, y, son);

                }
            }
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.png;*.jpeg;*.jpg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
