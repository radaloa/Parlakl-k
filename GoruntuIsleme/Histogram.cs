using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace GoruntuIsleme
{
    public partial class Histogram : Form
    {
        Bitmap kaynak, islem;

        public Histogram()
        {
            InitializeComponent();
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

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void değerGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int genislik = kaynak.Width;
            int yukseklik = kaynak.Height;
            int[] histogramDizisiRed = new int[256];
            int[] histogramDizisiGreen = new int[256];
            int[] histogramDizisiBlue = new int[256];
            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkler = kaynak.GetPixel(x, y);
                    for (int m = 0; m < histogramDizisiRed.Length; m++)
                    {
                        if (m == renkler.R)
                        {
                            histogramDizisiRed[m] = histogramDizisiRed[m] + 1;
                        }
                        if (m == renkler.G)
                        {
                            histogramDizisiGreen[m] = histogramDizisiGreen[m] + 1;
                        }
                        if (m == renkler.B)
                        {
                            histogramDizisiBlue[m] = histogramDizisiBlue[m] + 1;
                        }
                    }

                }
            }

            chart1.Titles.Add("HİSTOGRAM");
            chart1.Series.Add("Red");
            chart1.Series["Red"].ChartType = SeriesChartType.Line;
            chart1.Series["Red"].Color = Color.Red;
            chart1.Series.Add("Green");
            chart1.Series["Green"].ChartType = SeriesChartType.Line;
            chart1.Series["Green"].Color = Color.Green;
            chart1.Series.Add("Blue");
            chart1.Series["Blue"].ChartType = SeriesChartType.Line;
            chart1.Series["Blue"].Color = Color.Blue;

            for(int i = 0; i < histogramDizisiBlue.Length; i++)
            {
                chart1.Series["Red"].Points.Add(histogramDizisiGreen[i]);
                chart1.Series["Red"].Points[i].AxisLabel = i.ToString();
                chart1.Series["Blue"].Points.Add(histogramDizisiBlue[i]);
                chart1.Series["Blue"].Points[i].AxisLabel = i.ToString();
                chart1.Series["Green"].Points.Add(histogramDizisiGreen[i]);
                chart1.Series["Green"].Points[i].AxisLabel = i.ToString();
            }
           // for (int i = 0; i < histogramDizisiRed.Length; i++)
            {
            //    Console.WriteLine("R"+i + " " + histogramDizisiRed[i]);
              //  Console.WriteLine("G"+i + " " + histogramDizisiGreen[i]);
               // Console.WriteLine("B"+i + " " + histogramDizisiBlue[i]);
            }
        }
    }
}