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
    
    public partial class Invert : Form
    {
        Bitmap kaynak, islem;
        public Invert()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK) ;
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int genislik = kaynak.Width;
            int yukseklik = kaynak.Height;

            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkler = kaynak.GetPixel(x, y);
                    int gri = ((255-renkler.R) + (255-renkler.G)+ (255-renkler.B));
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }islemBox.Image = islem;
        }
    }
}

