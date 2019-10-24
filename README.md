# DynEd Helper

DynEd Helper, [DynEd Kayıt Yönetim Sistemi](http://dynedkayityonetimisistemi.meb.gov.tr)'ne öğrenci kaydetmek üzere öğrenci listeleri hazırlama işlemini hızlandırmayı ve böylece hem DynEd ile ilgilenen öğretmenlerimize zaman kazandırmayı hem de  öğrencilerimizin uygulamayı kullanmaya başlamalarını hızlandırmayı amaçladı. ['Quick and Dirty'](https://dictionary.cambridge.org/tr/s%C3%B6zl%C3%BCk/ingilizce/quick-and-dirty) geliştirildiğinden ['as is'](https://dictionary.cambridge.org/tr/s%C3%B6zl%C3%BCk/ingilizce/as-is) olarak kullanılır, bu yüzden [use it at your own risk](https://www.ldoceonline.com/dictionary/at-your-own-risk). Remember that this is tested nowhere except for the computer it is developped :)

DynEd Helper açık kaynak kodlu olduğundan neyi nasıl yaptığını anlayabilir, önerilerinizle (issues, Pull Requests, vb.) geliştirilmesine yardımcı olabilirsiniz.

## [Güncel Sürümü İndir (v1.2.0)](https://github.com/kayagultekin/DynEdHelper/releases/download/v1.2.0/DynEdHelper-1.2.0.zip)

## Sistem Gereksinimleri

1. Windows İşletim Sistemi
2. [.NET Framework 4.6.2](https://www.microsoft.com/net/download/dotnet-framework-runtime/net462) (Birde fazla bilgisayarda kullanacaksanız, yanınıza almanızı tavsiye edebilirim.)

## Nasıl kullanırım

1. E-Okul sisteminden -> öğrenci işleri bölümüne gidip öğrencileri (dersine girdiğiniz sınıfların öğrencilerini veya bir idareci yardımıyla ulaşabilirseniz tüm okul öğrencilerini) listeletin

2. Listeyi tercihen sağ en alttan sol en üste kadar (**Başlık satırının tamamını da alacak şekilde**) seçin, kopyalayın ve yeni bir excel dosyasının **ilk hücresine (A1)** yapıştırıp dosyayı kaydediniz:
    * Öğrenci Seçimi: 
    
        ![Öğrenci Seçimi](https://github.com/kayagultekin/DynEdHelper/blob/master/docs/images/OgrenciSecimi.png)
    * Excel dosyasına yapıştırma (Kaynak Biçimlendirmesini Koru):

         ![Kaynak Biçimlendirmesini Koru - sağ tık menüsü](https://github.com/kayagultekin/DynEdHelper/blob/master/docs/images/KaynakBicimlendirmesiniKoru-RightClick.png)

        Sonuç:
        
         ![Kaynak Biçimlendirmesini Koru](https://github.com/kayagultekin/DynEdHelper/blob/master/docs/images/KaynakBicimlendirmesiniKoru.png)

    * Excel dosyasına yapıştırma (Hedef Biçimlendirmesiyle Eşle):

        ![Hedef Biçimlendirmesiyle Eşle - sağ tık menüsü](https://github.com/kayagultekin/DynEdHelper/blob/master/docs/images/HedefBicimlendirmesiyleEsle-RightClick.png)

        Sonuç:

        ![Hedef Biçimlendirmesiyle Eşle](https://github.com/kayagultekin/DynEdHelper/blob/master/docs/images/HedefBicimlendirmesiyleEsle.png)

        > **Hedef Biçimlendirmesiyle Eşle** yöntemi ile oluşan excel dosyasının işlenmesi çok daha hızlı gerçekleşir, öğrenci sayısı arttıkça bu fark gözle görülür biçimde belirginleşir. Cihazdan cihaza değişmekle birlikte bu yöntemle 15000 civarı kayıt 1 dk altında işlenebilmektedir. (Bu yöntemin çalışmasıyla ilgili bir [*sorun*](https://github.com/kayagultekin/DynEdHelper/issues/4)  [v1.0.1](https://github.com/kayagultekin/DynEdHelper/releases/tag/v1.0.1) sürümüyle giderildiğinden eski sürümleri kullanmamanızı tavsiye ederim. )

3. Uygulama indirip kurmak için [publish.zip](https://github.com/kayagultekin/DynEdHelper/releases/download/v1.0.1/publish.zip) kurulum dosyasını indirip arşivden çıkarın ve setup.exe dosyasını çalıştırıp yönergeleri izleyin.

    > Daha önce yüklü olan sürümü kurulumdan önce kaldırmanız olası yükleme sorunlarının önüne geçecektir.

4. **Dosya Yükle** butonunu kullanarak kaydettiğiniz excel dosyasını seçin.
5. Oluşturulacak e-posta listesi için kullanılacak "@site.net" uzantısını dilediğiniz (geçerli) bir e-posta uzantısıyla değiştirin.
6. Son olarak da **Listeyi İşle ve Kaydet** butonunu tıklayın.
7. İşlem tamamlandıktan sonra uygulama listenizdeki sınıfları tanıyacak ve her bir sınıf için ayrı excel dosyası oluşturup kaynak excel dosyasının bulunduğu klasöre Sınıflar isimli yeni bir klasör oluşturup içine kaydedecek ve dosyaların içinde olduğu klasörü açacaktır.
8. Oluşturulan dosyaları kayıt yönetim sisteminde  yeni sınıfa öğrenci kaydettiğiniz ekrandan sisteme sınıf sınıf göstererek öğrencileri kaydedebilirsiniz.

* PS: Umarım size de zaman kazandırır.

* PPS: Sınıf ya da öğrenci sayısı sınırlaması yok, uygulamanın çalıştığı bilgisayarın kaynakları kadar çok bilgi işleyebilirsiniz.

## Resmi Yazılar

* [Yenilenen DynEd İngilizce Dil Eğitim Sistemi "Kayıt Yönetim Sistemi" ile ilgili Resmi Yazı.](http://tegm.meb.gov.tr/meb_iys_dosyalar/2017_03/30140144_resmi_yazY.pdf)

## Kılavuzlar

* [DynEd Kayıt Yönetim Sistemi Kullanım Kılavuzu](http://tegm.meb.gov.tr/meb_iys_dosyalar/2017_03/30140103_DynEd_KayYt_YoYnetimi_Sitesi_KullanYm_KYlavuzu.pdf)

## Bağlantılar

* [Download and Install DynEd Courseware](http://web2.dyned.com/download/student.shtml.en)

## Lisans

[MIT](https://github.com/kayagultekin/DynEdHelper.Desktop/blob/master/LICENSE)
