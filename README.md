# DynEd Helper

DynEd Helper, [DynEd Kayıt Yönetim Sistemi](http://dynedkayityonetimisistemi.meb.gov.tr)'ne öğrenci kaydetmek üzere öğrenci listeleri hazırlama işlemini ve böylece hem DynEd ile ilgilenen öğretmenlerimize zaman kazandırmayı hem de  öğrencilerimizin uygulamayı kullanmaya başlamalarını hızlandırmayı amaçladı. ['Quick and Dirty'](https://dictionary.cambridge.org/tr/s%C3%B6zl%C3%BCk/ingilizce/quick-and-dirty) geliştirildiğinden ['as is'](https://dictionary.cambridge.org/tr/s%C3%B6zl%C3%BCk/ingilizce/as-is) olarak kullanılır, bu yüzden [use it at your own risk](https://www.ldoceonline.com/dictionary/at-your-own-risk). Remember that this is tested nowhere except for the computer it is developped :)

DynEd Helper açık kaynak kodlu olduğundan neyi nasıl yaptığını anlayabilir, önerilerinizle (issues, Pull Requests, vb.) geliştirilmesine yardımcı olabilirsiniz.

## Sistem Gereksinimleri
style("ordered")
1. Windows İşletim Sistemi
2. [.NET Framework 4.6.2](https://www.microsoft.com/net/download/dotnet-framework-runtime/net462)

## Nasıl kullanırım

1. E-Okul sisteminden -> öğrenci işleri bölümüne gidip öğrencileri (dersine girdiğiniz sınıfların öğrencilerini veya bir idareci yardımıyla ulaşabilirseniz tüm okul öğrencilerini) listeletin
2. Listeyi tercihen alttan en üste kadar (**Başlık satırının tamamını da alacak şekilde**) kopyalayıp yeni bir excel dosyasının **ilk hücresine (A1)** yapıştırıp dosyayı kaydediniz.
3. 
    * [DynEdHelper.zip](https://github.com/kayagultekin/DynEdHelper.Desktop/raw/master/dist/DynEdHelper.zip) dosyasını indirip arşivden çıkarın ve çıkan klasör içinden DynEdHelper.exe dosyasını çalıştırın. (USB bellekte taşınabilir, portable sürüm)

    * [DynEdHelper-Installer.zip](https://github.com/kayagultekin/DynEdHelper.Desktop/raw/master/dist/DynEdHelper-Installer.zip) dosyasını indirip arşivden çıkarın ve setup.exe dosyasını çalıştırıp yönergeleri izleyin. (Kurulabilir sürüm.)
4. **Dosya Yükle** butonunu kullanarak kaydettiğiniz excel dosyasını seçin.
5. Oluşturulacak e-posta listesi için kullanılacak "@site.net" uzantısını dilediğiniz (geçerli) bir e-posta uzantısıyla değiştirin.
6. Son olarak da **Listeyi İşle ve Kaydet** butonunu tıklayın.
7. İşlem tamamlandıktan sonra uygulama listenizdeki sınıfları tanıyacak ve her biri için ayrı excel dosyası oluşturup kaydedecek ve dosyaları içinde olduğu klasörü açacaktır.
8. Oluşturulan dosyaları kayıt yönetim sisteminde  yeni sınıfa öğrenci kaydettiğiniz ekrandan sisteme tek tek göstererek öğrencileri kaydedebilirsiniz.

PS: Umarım size de zaman kazandırır.

## Lisans

[MIT](https://github.com/kayagultekin/DynEdHelper.Desktop/blob/master/LICENSE)
