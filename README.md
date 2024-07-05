# Dosya İşlemleri ile Resim Üzerine Yazı Yazma Uygulaması

Bu proje, kullanıcıların seçtikleri bir resmin üzerine metin yazmalarını ve bu resmi kaydetmelerini sağlayan bir Windows Forms uygulamasıdır.

## Özellikler

- **Resim Seçme:** Kullanıcı, bilgisayarındaki bir resim dosyasını seçebilir.
- **Renk Seçme:** Yazının rengini belirlemek için renk seçici kullanabilir.
- **Yazı Ekleme:** Kullanıcı, seçtiği resim üzerine belirlediği boyutta ve renkte metin ekleyebilir.
- **Resmi Görüntüleme:** Üzerine yazı eklenmiş resmi uygulama penceresinde görüntüleyebilir.
- **Resmi Kaydetme:** Kullanıcı, oluşturduğu resmi farklı dosya formatlarında (.jpg, .png, .bmp) kaydedebilir.

## Kullanılan Teknolojiler

- **Programlama Dili:** C#
- **Geliştirme Ortamı:** Visual Studio 2022
- **Framework:** .NET Framework
- **Arayüz Bileşenleri:** Windows Forms
- **Grafik İşlemleri:** System.Drawing kütüphanesi

## Kurulum ve Kullanım

1. **Proje Dosyalarını İndirme:**
git clone https://github.com/kullanici-adi/proje-adi.git
cd proje-adi


2. **Visual Studio ile Projeyi Açma:**
- `Dosya` -> `Aç` -> `Proje/Çözüm Aç` menüsünden projenin `.sln` dosyasını seçin.

3. **Bağımlılıkların Yüklenmesi:**
- Proje açıldığında gerekli tüm bağımlılıklar otomatik olarak yüklenecektir.

4. **Uygulamayı Çalıştırma:**
- `Ctrl + F5` tuşlarına basarak veya `Başlat` butonuna tıklayarak uygulamayı çalıştırabilirsiniz.

## Kullanım Kılavuzu

1. **Resim Seçme:**
- `Resim Seç` butonuna tıklayarak bilgisayarınızdan bir resim dosyası seçin.

2. **Renk Seçme:**
- `Renk Seç` butonuna tıklayarak metin için bir renk seçin.

3. **Metin Ekleme:**
- Yazmak istediğiniz metni `richTextBox` alanına girin.
- Metin boyutunu `txtBoyut` alanına girin.
- `Yazdır` butonuna tıklayarak metni resmin üzerine ekleyin.

4. **Resmi Kaydetme:**
- `Kaydet` butonuna tıklayarak dosya formatını seçin ve resmi bilgisayarınıza kaydedin.

## Kod Açıklamaları

### Form1 Sınıfı

`Form1` sınıfı, uygulamanın ana formunu temsil eder ve tüm kullanıcı etkileşimlerini yönetir. Bu sınıf, formun bileşenlerini ve olaylarını tanımlar.

### Form1 Constructor

- `InitializeComponent()`: Form bileşenlerinin başlatılmasını sağlar.

### btnResimSec_Click Olayı

- `openFileDialog1.ShowDialog()`: Kullanıcının bir resim dosyası seçmesi için dosya seçici dialogunu açar.
- `resim = openFileDialog1.FileName`: Seçilen resmin dosya yolunu alır.

### btnRenkSec_Click Olayı

- `colorDialog1.ShowDialog()`: Kullanıcının bir renk seçmesi için renk seçici dialogunu açar.
- `renk = colorDialog1.Color`: Seçilen rengi alır ve `renk` değişkenine atar.

### btnYazdir_Click Olayı

- **Boyut Kontrolü:**
- Eğer kullanıcı metin boyutunu girmediyse, bir uyarı mesajı gösterir ve işlemi durdurur.
- **Bitmap Oluşturma:**
- `bmp = new Bitmap(resim)`: Seçilen resmi `Bitmap` formatında alır.
- **Grafik Nesnesi Oluşturma:**
- `Graphics gr = Graphics.FromImage(bmp)`: Grafik nesnesi oluşturarak resim üzerine çizim yapmayı sağlar.
- **Metin Çizimi:**
- `gr.DrawString()`: Kullanıcının girdiği metni, belirlenen yazı tipi, boyutu ve renkle resmin üzerine çizer.
- **Resmi Gösterme:**
- `pictureBox1.Image = bmp`: Üzerine yazı eklenmiş resmi `PictureBox` bileşeninde gösterir.

### btnKaydet_Click Olayı

- **Dosya Formatı Seçimi:**
- `saveFileDialog1.Filter`: Kaydedilecek dosya türlerini belirtir.
- **Dosya Kaydetme:**
- `saveFileDialog1.ShowDialog()`: Dosya kaydetme dialogunu açar.
- `bmp.Save(saveFileDialog1.FileName)`: Üzerine yazı eklenmiş resmi belirtilen dosya adı ve formatıyla kaydeder.

## İlgili Projeye Ait Ekran Görüntüsü

![yazdırma](https://github.com/huseynaktas/Dosya_Islemleri_Ile_Resim_Uzerine_Yaz-_Yazma/assets/114494075/4509d878-e0e0-4899-b618-511e608f1fa3)

*Ana ekran görüntüsü*

