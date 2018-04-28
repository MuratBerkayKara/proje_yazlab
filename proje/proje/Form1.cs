using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        Bitmap ilk_resim = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                ilk_resim = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                pictureBox1.Image = ilk_resim;
                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//boyutlandırma

        {
            Bitmap boyutlandirma = new Bitmap(ilk_resim, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            pictureBox1.Image = boyutlandirma;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button3_Click(object sender, EventArgs e)//tersleme
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            Bitmap tersleme = new Bitmap(resim);
            for (int y = 0; (y <= (resim.Height - 1)); y++)
             {
                 for (int x = 0; (x <= (resim.Width - 1)); x++)
                 {
                     Color inv = resim.GetPixel(x, y);
                     inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                     tersleme.SetPixel(x, y, inv);
                 }
             }
            pictureBox1.Image = tersleme;
        }

        private void button4_Click(object sender, EventArgs e)//aynalama sağ
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            int width = resim.Width;
            int height = resim.Height;
            Bitmap aynalama = new Bitmap(width, height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color renkler = resim.GetPixel(width - j - 1, i);
                    aynalama.SetPixel(j, i, renkler);
                }
                    
            }    
            pictureBox1.Image = aynalama;
        }

        private void button5_Click(object sender, EventArgs e)//aynalama yukarı
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            int width = resim.Width;
            int height = resim.Height;
            Bitmap aynalama = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renkler = resim.GetPixel(i, height - j - 1);
                    aynalama.SetPixel(i, j, renkler);
                }

            }
            pictureBox1.Image = aynalama;
        }

        private void button6_Click(object sender, EventArgs e)//soladöndürme
        {
            Bitmap dondur = new Bitmap(pictureBox1.Image);            
            dondur.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = dondur;

            /*Bitmap resim = new Bitmap(degisen_resim);
             Bitmap dondurme = new Bitmap(degisen_resim.Width,degisen_resim.Height);
             int width = dondurme.Width;
             int height = dondurme.Height;
             Graphics g = Graphics.FromImage(dondurme);
                 g.TranslateTransform((float)width / 2, (float)height / 2); //donus noktası
                 g.RotateTransform(90);
                 g.TranslateTransform(-(float)width / 2, -(float)height / 2); //donme noktasını geri yukle
                 g.DrawImage(resim, new Point(0, 0)); //draw the image on the new bitmap

             pictureBox1.Image = dondurme;
             pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;*/


        }

        private void button7_Click(object sender, EventArgs e)//sağadöndürme
        {
            Bitmap dondur = new Bitmap(pictureBox1.Image);
            dondur.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = dondur;

            /*Bitmap rotatedImage = new Bitmap(ilk_resim);
            int width = rotatedImage.Width;
            int height = rotatedImage.Height;
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(width / 2, height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(-90); //rotate
                g.TranslateTransform(-width / 2, -height / 2); //restore rotation point into the matrix
                g.DrawImage(pictureBox1.Image, new Point(0, 0)); //draw the image on the new bitmap
            }
            pictureBox1.Image = null;
            pictureBox1.Image = rotatedImage;*/
        }

        private void button8_Click(object sender, EventArgs e)//gritonlama
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            Bitmap gri = new Bitmap(resim.Width, resim.Height);
            int width = gri.Width;
            int height = gri.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renk = resim.GetPixel(i, j);
                    int grirenk = (int)((renk.R * 0.3) + (renk.G * 0.59) + (renk.B * 0.11));
                    Color renk2 = Color.FromArgb(renk.A, grirenk, grirenk, grirenk);
                    gri.SetPixel(i, j, renk2);
                }
            }
            pictureBox1.Image = gri;
        }

        private void button9_Click(object sender, EventArgs e)// kırmızı renk kanalı
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            Bitmap renklendirme= new Bitmap(resim.Width,resim.Height);
            int width = renklendirme.Width;
            int height = renklendirme.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renkler = resim.GetPixel(i, j);
                    Color kanal = Color.FromArgb(renkler.R, 0, 0);
                    renklendirme.SetPixel(i, j, kanal);
                }
            }
            pictureBox1.Image = renklendirme;
           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button10_Click(object sender, EventArgs e)//Yeşil Renk kanalı
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            Bitmap renklendirme = new Bitmap(resim.Width, resim.Height);
            int width = renklendirme.Width;
            int height = renklendirme.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renkler = resim.GetPixel(i, j);
                    Color kanal = Color.FromArgb(0, renkler.G, 0);
                    renklendirme.SetPixel(i, j, kanal);
                }
            }
            pictureBox1.Image = renklendirme;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button11_Click(object sender, EventArgs e)//Mavi renk kanalı
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            Bitmap renklendirme = new Bitmap(resim.Width, resim.Height);
            int width = renklendirme.Width;
            int height = renklendirme.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renkler = resim.GetPixel(i, j);
                    Color kanal = Color.FromArgb(0, 0, renkler.B);
                    renklendirme.SetPixel(i, j, kanal);
                }
            }
            pictureBox1.Image = renklendirme;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button12_Click(object sender, EventArgs e)//sıfırlama
        {
            Bitmap resim = new Bitmap(ilk_resim);
            pictureBox1.Image = null;
            pictureBox1.Image = resim;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button13_Click(object sender, EventArgs e)//kaydetme
        {           
            kaydetme.Filter = "JPG images (*.jpg)|*.jpg";
            if (kaydetme.ShowDialog() == DialogResult.OK)
            {           
                Bitmap bmp = new Bitmap(pictureBox1.Image);                
                bmp.Save(kaydetme.FileName);
            }
        }
        
        private void button14_Click(object sender, EventArgs e)//histogram
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);//tüm piksellerdeki renkleri alır ve renkleri diziye atar
            int width = resim.Width;
            int height = resim.Height;
            int[,] kirmizi = new int[width,height];
            int[,] yesil = new int[width, height];
            int[,] mavi = new int[width, height];
            int[,] gri = new int[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color renkler = resim.GetPixel(i, j);
                    kirmizi[i,j] = (int)renkler.R;
                    yesil[i,j] = (int)renkler.G;
                    mavi[i,j] = (int)renkler.B;
                    gri[i,j] = (int)((renkler.R * 0.3) + (renkler.G * 0.59) + (renkler.B * 0.11));
                }
            }
          
            Form2 goster = new Form2();
            for (int i = 0; i < width; i=i+20)
            {
                for (int j = 0; j < height; j=j+20)//diziye atılan renkleri grafige aktarır
                {
                    goster.grafik1.Series["Red"].Points.AddY(kirmizi[i,j]);
                    goster.grafik2.Series["Green"].Points.AddY(yesil[i, j]);
                    goster.grafik3.Series["Blue"].Points.AddY(mavi[i, j]);
                    goster.grafik4.Series["Grey"].Points.AddY(gri[i, j]);
                }
            }


            goster.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
