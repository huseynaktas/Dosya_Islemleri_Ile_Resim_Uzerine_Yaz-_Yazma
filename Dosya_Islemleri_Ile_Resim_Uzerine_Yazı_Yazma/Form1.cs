using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Islemleri_Ile_Resim_Uzerine_Yazı_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim; // Resim dosyasının yolunu tutmak için

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Resim seçme işlemi
            resim = openFileDialog1.FileName; // Seçilen resmin yolunu al
        }

        Color renk; // Yazı rengi için
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); // Renk seçme işlemi
            renk = colorDialog1.Color; // Seçilen rengi al
        }

        Bitmap bmp; // Resmi Bitmap formatında tutmak için
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if(txtBoyut.Text == "") // Eğer boyut girilmediyse
            {
                MessageBox.Show("Lütfen boyut giriniz!"); // Uyarı mesajı ver
                return; // Metodu sonlandır
            }
            else
            {
                bmp = new Bitmap(resim); // Bitmap formatında resmi al
                Graphics gr = Graphics.FromImage(bmp); // Resmin üzerine yazı yazmak için
                gr.DrawString(richTextBox1.Text, new Font("Segoe IO", Convert.ToInt16(txtBoyut.Text)), new SolidBrush(renk), new PointF(10, 10)); //yazıyı nereye yazacağını belirtiyoruz, yazı tipi ve rengini belirtiyoruz, yazıyı nereye yazacağını belirtiyoruz
                pictureBox1.Image = bmp; // Resmi göster
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Dosyası|*.jpg|PNG Dosyası|*.png|BMP Dosyası|*.bmp"; // Kaydedilecek dosya türlerini belirt
            saveFileDialog1.ShowDialog(); // Resmi kaydetme işlemi
            bmp.Save(saveFileDialog1.FileName); // Resmi kaydet
        }
    }
}
