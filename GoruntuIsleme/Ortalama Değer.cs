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
    public partial class Form3 : Form
    {
        Bitmap kaynak,islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.jpeg;*.png;*.jpg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int genislik = kaynak.Width;
            int yukseklik = kaynak.Height;

            islem = new Bitmap(genislik, yukseklik);

            for(int y=0;y<yukseklik;y++)
            {
                for(int x=0;x<genislik;x++)
                {
                    Color renkler = kaynak.GetPixel(x, y);
                    int gri = (renkler.R + renkler.G + renkler.B) / 3;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y,griRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
        
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }
    }
}
