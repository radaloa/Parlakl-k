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
using Accord.Imaging.Filters;

namespace GoruntuIsleme
{
    public partial class Form5 : Form
    {
        Bitmap kaynak, islem;
        public Form5()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
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
                    Color renkli = kaynak.GetPixel(x, y);
                    double algoritma = renkli.R * (0.2125) + renkli.G * (0.7154) + renkli.B * (0.072);
                    int bt709 = Convert.ToInt16(algoritma);
                    Color teknik = Color.FromArgb(bt709, bt709, bt709);
                    islem.SetPixel(x, y, teknik);


                }
            }islemBox.Image = islem;
            
            
       
            

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.png;*.jpeg;*.jpg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }
    }
}
