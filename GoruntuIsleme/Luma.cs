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
    public partial class Luma : Form
    {
        Bitmap islem, kaynak;
        public Luma()
        {
            InitializeComponent();
        }

        private void kApatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    double luma = orjinal.R * 0.3 + orjinal.G * 0.59 + orjinal.B * 0.11;
                    int lumasayisi = Convert.ToInt16(luma);
                    Color islemsonrasi = Color.FromArgb(lumasayisi, lumasayisi, lumasayisi);
                    islem.SetPixel(x, y, islemsonrasi);

                }
            }islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.png;*jpg;*;*.jpeg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK) 
            {
                kaynak=new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

          

            }

        }
    }
}
