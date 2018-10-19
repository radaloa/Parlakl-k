using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form4 : Form
    {
        Bitmap kaynak, islem;

        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                islem.Save(openFileDialog1.FileName, format);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color normalRenk = kaynak.GetPixel(x, y);
                    Color siralanmis = Color.FromArgb(normalRenk.G, normalRenk.B, normalRenk.R);
                    islem.SetPixel(x, y, siralanmis);

                }
            }islemBox.Image = islem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color normalRenk = kaynak.GetPixel(x, y);
                    Color siralanmisRenk = Color.FromArgb(normalRenk.B, normalRenk.G, normalRenk.R);
                    islem.SetPixel(x, y, siralanmisRenk);

                }
            } islemBox.Image = islem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                    {

                    Color normalRenk = kaynak.GetPixel(x, y);
                    Color siralanmisRenk = Color.FromArgb(normalRenk.B, normalRenk.R, normalRenk.G);
                    islem.SetPixel(x, y, siralanmisRenk);


                }
            }islemBox.Image = islem;
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
