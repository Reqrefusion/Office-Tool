# Office Açıklaması Dağıt

Burada, şu anda yüklü olan Office ürünlerini ve dil paketlerini yönetebilirsiniz. Office yüklü değilse, yeni bir yükleme yapabilirsiniz. ** Microsoft kısıtlamaları nedeniyle, Office yalnızca sistem diskine yüklenebilir. **

Şu anda sürüm bilgisinde bulunan her kanaldaki Office sürümünün sürümünü ve yayınlanma tarihini sorgulayabilirsiniz. Sorgu tamamlandıktan sonra, indirme veya yükleme sırasında geçmiş sürümü seçebilirsiniz. En son sürüm varsayılan olarak yüklenir.

## dizin

---

1. Kurulum modülü açıklaması
2. Kanal ayar talimatları
3. Yeni kurulum talimatları
4. Ürün ekleme ve silme / dil tanımı
5. Office 365 Ürün Kimliği Karşılaştırma Tablosu
6. Kurulum dosyası açıklaması
7. Ofis yapılandırma talimatları

## Kurulum Modülü Açıklama

---

Office Dağıtım Aracı, Office Tool Plus'ın neredeyse tüm parametre ayarlarını desteklediği Office dağıtımı için kullanılan bir Microsoft resmi yayın aracıdır.
Office Tool Plus modülü, Office'i yüklemek için kendimiz yazdığımız küçük bir modüldür.O Office dağıtım aracının tüm işlevlerine sahip olmasa da, Office'in sorunsuz bir şekilde yüklenmesini de sağlar.

[Office Dağıtım Araçları resmi web sitesi] (https://aka.ms/ODT)

[Office Dağıtım Araçları için Yapılandırma Seçenekleri] (https://docs.microsoft.com/en-us/DeployOffice/configuration-options-for-the-office-2016-deployment-tool)

[Office Özelleştirme Aracı] (https://config.office.com)

** Office 2019 Premium Edition'ı Windows 7'den yüklemek için Office Tool Plus modülünü kullandığınızdan emin olun! **

`Office Dağıtım Araçları ile yükleme yaparken çözülmemiş bir sorunla karşılaştığınızda, Office Tool Plus yükleme modülünü deneyin! '

## Kanal Ayarları Açıklama

---

Office, Visio, Project 2019 cilt sürümü yalnızca Office 2019 Enterprise Uzun Vadeli kanalında desteklenir ve diğer ürünlerle (Office 365 gibi) karıştırılamaz.
Office 365'i yüklerken Visio'yu kullanmak istiyorsanız, Visio 2016 Retail veya 2016 Volume (Project) seçeneğini seçin.

Office 2016/2019 (perakende) / 365 ürünleri diğer kanalları seçebilir (Office 2019 kurumsal uzun vadeli sürümü olmadığı sürece), aylık kanalı kullanmanız önerilir ve yeni özellikleri önemsemeyen ofis çalışanları yarım yıllık kanalı seçebilir. ** Office ile ilgili sorun yaşıyorsanız, yönlendirilmiş bir kanal veya bir beta kanalı kullandığınızdan, lütfen kendiniz çözün. **

## Yeni kurulum talimatları

---

Yeni bir kurulum için, Ürün Ekle'ye tıklayın ve kurmak istediğiniz ürünü seçin. Ürün bir veya daha fazla uygulama içerebilir ve kurmak istemiyorsanız işaretini kaldırın. ** Bunlar arasında, Groove OneDrive İş'in ve Lync Skype'ın İşin kısaltmasıdır. **

Yeni bir kurulumda bir dil paketi belirtmezseniz, Office Tool Plus, sistem diliyle varsayılan olarak eşleşir. Office mevcut sistemin diline tam olarak uymuyorsa, [en-us] - İngilizce (ABD) varsayılan olarak ana dil olarak eklenir.
Dil eklerken, bir ana dil seçtiğinizden emin olun. '

Yeni bir kurulum kurarken, ** Office 2019 toplu sürümünü seçtiyseniz, kanalınızın Office 2019 kurumsal uzun vadeli kanal olduğundan emin olun, aksi takdirde düzgün şekilde kurulmaz! ** Office 2019 perakende sürümü diğer kanalları seçebilir.

## Ürün ekle / sil / dil tanımı

---

Office bilgisayarınıza önceden yüklendiğinde, Office Tool Plus aracılığıyla ürünleri ekleyebilir ve kaldırabilirsiniz.

### Ürün / dil ekle

Bir ürün veya dil eklemeniz gerekirse, ürünü / dili doğrudan ekleyin ve doğrudan kendi fikir / gereksinimlerinize göre seçin. `Not: Sorunları önlemek için, lütfen bir ürünü / dili tekrar tekrar kurmayın. '

### Uygulamayı değiştirme

Uygulamayı değiştirmeniz gerekirse, önce ürünü seçin, ardından istenmeyen uygulamaların işaretini kaldırın, eklemek istediklerinizi seçin ve ardından dağıtımı başlatın.

### Ürün / dil kaldırılıyor

Listede, kaldırmak istediğiniz ürünü / dili kontrol edin, ardından Dağıtımı Başlat düğmesinin sağındaki menüyü tıklayın ve * Seçili ürünü / dili kaldır * 'ı tıklayın.

## Office 365 Ürün Kimliği Karşılaştırma Tablosu

---

`Txt
Office 365 Professional Plus O365ProPlusPerakende
Office 365 Kurumsal E3 O365ProPlusPerakende
Office 365 Kurumsal E4 O365ProPlusPerakende
Office 365 Enterprise E5 O365ProPlusPerakende
Office 365 Orta O365ProPlusPerakende
Office 365 Business Edition O365İletişimPerakende
Office 365 Business Premium O365İş Yeri
Office Small Business Premium Sürüm O365KüçükBusPremPerakende
Office 365 Home Edition O365HomePremRetail
Office 365 Kişisel Sürüm O365HomePremRetail
`

Daha fazla bilgi için, lütfen [Office Dağıtım Araçları Desteklenen Ürün Kimlikleri] 'ni ziyaret edin (https://docs.microsoft.com/en-us/office365/troubleshoot/administration/product-ids-supported-office-deployment-click-to- run)

## Kurulum Dosyası Açıklaması

---

Yükleme dosyası, adından da anlaşılacağı gibi, Office için yükleme paketidir. Office Tool Plus, Office yükleme dosyalarının Microsoft Office CDN Sunucusundan indirilmesini ve ISO dosyalarına dönüştürülmesini destekler. Kurulum dosyalarını indirdikten sonra, bant genişliğinden tasarruf etmek veya zaman azaltmak için çevrimdışı kurulumu kullanabilir veya kurulum dosyalarını diğer kullanıcılarla paylaşabilirsiniz.

Yükleme dosyaları arasında Office, Visio ve Project bulunur: Office 2019 Enterprise Uzun Vadeli kanalından indirilen yükleme dosyaları yalnızca Office 2019'u toplu olarak kurmak için kullanılabilir ve diğer kanal yükleme dosyaları Office 2016, 365 ve 2019 perakende satışını yüklemek için kullanılabilir.

Office yükleme dosyalarını indirmek için mimariyi, kanalı ve dili, varsayılan olarak sistem diliyle eşleşecek şekilde yapılandırın. Office Tool Plus varsayılan olarak ayarlanmıştır ve yükleme dosyalarını doğrudan indirmeye başlayabilirsiniz.

! [Kurulum Dosyasını İndir] (https://coolhub.top/wp-content/uploads/2019/11/QQ截图20191107202304-1.png)

### Daha fazla bilgi için, lütfen aşağıdaki web sitesini ziyaret edin

[Office 365 için güncelleme kanalına genel bakış] (https://docs.microsoft.com/en-us/DeployOffice/overview-of-update-channels-for-office-365-proplus)

[Office 365 güncelleme geçmişi] (https://docs.microsoft.com/en-us/officeupdates/update-history-office365-proplus-by-date)

[Office 2019 Güncelleme Kanalına Genel Bakış] (https://docs.microsoft.com/en-us/DeployOffice/office2019/update#update-channel-for-office-2019)

## Kurulum dosyasını indirin

---

Yükleme dosyalarını indirmek için Office Dağıtım Araçları'nın kullanımını desteklemenin yanı sıra, Office Tool Plus ayrıca kullanıcıların Office yükleme dosyalarını hızlı bir şekilde indirmelerini sağlayan bir Thunder programı da içerir. İkisi arasındaki temel işlevlerde fark yoktur, ancak yalnızca Thunder desteği indirme ilerlemesini destekler, hız sınırlarını ayarlamayı ve proxy'yi ayrı olarak ayarlamayı destekler. `Thunder indirme işleminde bir sorun varsa, motoru Office Dağıtım Aracı'na getirin.

### Thunder indirme hızı limit ayarı

Thunder yüklemesini kullanırken hız sınırını ayarlamak için, lütfen indirme sırasında indirme hızını tıklayın ve ardından açılır penceredeki hız sınırını ayarlayın. Hız sınırını iptal etmek için 0 girin.

## Office Yapılandırma Talimatları

---

Dağıtım sayfasının en sağında, Ofis Yapılandırma panelini çağırabilirsiniz. '
Office Tool Plus, Office güncelleme kanalında yapılan değişiklikleri ve Office'te görüntülenen hesap sahibinin değiştirilmesini de destekler. Düzenlendikten sonra ayarları uygulamak için Kaydet'i tıklayın.

Office'iniz çalışmıyorsa, Office'i burada düzeltmeyi deneyebilirsiniz.

** Not: Yeniden oku'yu tıklarsanız, soldaki ürün ve dil verileri yeniden yüklenir ve bazı ayarlar varsayılan değerlerine sıfırlanır. **