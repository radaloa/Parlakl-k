namespace GoruntuIsleme
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliIşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakBox1 = new System.Windows.Forms.PictureBox();
            this.kaynakBox2 = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fotoğrafıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birleşimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ikiliIşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.fotoğrafıAçToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "1. Fotoğrafı Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // ikiliIşlemlerToolStripMenuItem
            // 
            this.ikiliIşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamaToolStripMenuItem,
            this.çıkarmaToolStripMenuItem,
            this.kesişimToolStripMenuItem,
            this.birleşimToolStripMenuItem});
            this.ikiliIşlemlerToolStripMenuItem.Name = "ikiliIşlemlerToolStripMenuItem";
            this.ikiliIşlemlerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ikiliIşlemlerToolStripMenuItem.Text = "İkili İşlemler";
            this.ikiliIşlemlerToolStripMenuItem.Click += new System.EventHandler(this.ikiliIşlemlerToolStripMenuItem_Click);
            // 
            // kaynakBox1
            // 
            this.kaynakBox1.Location = new System.Drawing.Point(12, 70);
            this.kaynakBox1.Name = "kaynakBox1";
            this.kaynakBox1.Size = new System.Drawing.Size(280, 304);
            this.kaynakBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakBox1.TabIndex = 1;
            this.kaynakBox1.TabStop = false;
            // 
            // kaynakBox2
            // 
            this.kaynakBox2.Location = new System.Drawing.Point(343, 70);
            this.kaynakBox2.Name = "kaynakBox2";
            this.kaynakBox2.Size = new System.Drawing.Size(280, 304);
            this.kaynakBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakBox2.TabIndex = 2;
            this.kaynakBox2.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(665, 70);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(280, 304);
            this.islemBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islemBox.TabIndex = 3;
            this.islemBox.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // fotoğrafıAçToolStripMenuItem
            // 
            this.fotoğrafıAçToolStripMenuItem.Name = "fotoğrafıAçToolStripMenuItem";
            this.fotoğrafıAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fotoğrafıAçToolStripMenuItem.Text = "2. Fotoğrafı Aç";
            this.fotoğrafıAçToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafıAçToolStripMenuItem_Click);
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toplamaToolStripMenuItem.Text = "Toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // çıkarmaToolStripMenuItem
            // 
            this.çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            this.çıkarmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkarmaToolStripMenuItem.Text = "Çıkarma";
            this.çıkarmaToolStripMenuItem.Click += new System.EventHandler(this.çıkarmaToolStripMenuItem_Click);
            // 
            // kesişimToolStripMenuItem
            // 
            this.kesişimToolStripMenuItem.Name = "kesişimToolStripMenuItem";
            this.kesişimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kesişimToolStripMenuItem.Text = "Kesişim";
            this.kesişimToolStripMenuItem.Click += new System.EventHandler(this.kesişimToolStripMenuItem_Click);
            // 
            // birleşimToolStripMenuItem
            // 
            this.birleşimToolStripMenuItem.Name = "birleşimToolStripMenuItem";
            this.birleşimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birleşimToolStripMenuItem.Text = "Birleşim";
            this.birleşimToolStripMenuItem.Click += new System.EventHandler(this.birleşimToolStripMenuItem_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox2);
            this.Controls.Add(this.kaynakBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form11";
            this.Text = "Form11";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiliIşlemlerToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakBox1;
        private System.Windows.Forms.PictureBox kaynakBox2;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birleşimToolStripMenuItem;
    }
}