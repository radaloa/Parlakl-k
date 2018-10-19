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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkBulmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkbul = new Form2();
            renkbul.ShowDialog();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ortalamaGri = new Form3();
            ortalamaGri.ShowDialog();
        }

        private void kanalSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 kanalSiralama = new Form4();
            kanalSiralama.ShowDialog();
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 bt709 = new Form5();
            bt709.ShowDialog();

        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luma luma = new Luma();
            luma.ShowDialog();
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 aciklik = new Form7();
            aciklik.ShowDialog();

        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 kanalcikarim = new Form8();
            kanalcikarim.ShowDialog();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram();
            histogram.ShowDialog();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invert invert = new Invert();
            invert.ShowDialog();
        }

        private void ikiliGörüntüİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 ikiliislemler = new Form11();
            ikiliislemler.ShowDialog();
        }

        private void parlaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parlaklık parlaklik = new Parlaklık();
            parlaklik.ShowDialog();
        }
    }
}
