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
    public partial class Parlaklık : Form
    {
        Bitmap kaynak, islem;
        public Parlaklık()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parlaklıkArttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.TickFrequency =25;
            trackBar1.LargeChange =50;
            trackBar1.SmallChange =25;
           textBox1.Text = "" + trackBar1.Value;
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    int ekle = Convert.ToInt32(textBox1.Text);
                    int red = orjinal.R + ekle;
                    int green = orjinal.G + ekle;
                    int blue = orjinal.B + ekle;
                    
                    
                    if (red>255)
                    {
                        red = 255;
                    }
                    if (red < 0)
                    {
                        red = 0;
                    }
                    if (green>255)
                    {
                        green=255;
                    }
                    if (green<0)
                    {
                      green = 0;
                    }
                    if (blue> 255)
                    {
                      blue = 255;
                    }
                    if (blue< 0)
                    {
                       blue = 0;
                    }
                    Color parlaklik = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, parlaklik);


                }
            }islemBox.Image = islem;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntü Dosyaları|*.jpeg;*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
