# Office Açıklamasını Etkinleştir

Bu araçla etkinleştiremezseniz, önce işleminizin doğru olup olmadığını kontrol edin Aşağıdaki talimatlar Office'in etkinleştirme adımlarını açıklar.Eğer işleminizin doğru olduğundan eminseniz ancak Office'i etkinleştiremiyorsanız, herhangi bir sorun için sistemi kontrol etmeniz önerilir. Etkinleştirme başarılı olduktan sonra, Office'in tüm işlevleri normal bir şekilde kullanılabilir, Microsoft hesabına giriş yapabilirsiniz.

## dizin

---

1. Sertifikayı yükleyin (dönüşüm yetkisi)
2. Sertifikayı etkinleştirin (Office'i etkinleştirin)
3. KMS kullanılabilirliğini kontrol edin
4. Sorgu etkinleştirme durumu
5. Office etkinleştirme bilgilerini temizleyin
6. Yaygın hatalar ve çözümler
7. GVLK listesi

## Bir sertifika yükleme

---

Bir sertifikayı yükledikten sonra, sertifikayı sağlayan anahtarla etkinleştirebilirsiniz.
Örneğin, Office 2016 Retail -> Office 2016 Volume ürününü dönüştürmek için, dönüştürmeyi tamamlamak üzere doğrudan Office 2016 Cilt lisansını yükleyin.
Kurulum tamamlandıktan sonra eski sertifikanın üzerine yazılmayacaktır, bu sayede bu işlem çoklu sertifika yetkilendirme bir arada bulunabilmektedir.

Seçimi özelleştirmek ve sertifikayı yüklemek için yanındaki üç nokta düğmesini tıklatın.

`Not: OTP, Office sertifikasını okur ve yalnızca bilgisayarın Çalıştırmak için Tıkla sürümünde Office yüklüyse açılan kutuda görüntüler. Aksi takdirde, OTP yalnızca dahili Birim (birim) sertifikasını görüntüler. '

## Office aktivasyon yöntemi ve adımları

---

`Lütfen dikkat: Tüm Office 365 ürünleri yalnızca bir oturum açma hesabıyla etkinleştirilebilir: Office Tool Plus, yalnızca yönetim etkinleştirmesini destekler ve etkinleştirmeden sorumlu değildir. '

### Anahtar çevrimiçi aktivasyon adımı

`Etkinleştirmeden önce, lütfen anahtarınızın geçerli olduğundan ve Office sürümünün uygun olduğundan emin olun. `Anahtarı girin ve Anahtar Yükle'ye tıklayın, ardından Etkinleştir'e tıklayın, Office başarıyla etkinleştirilecektir. Bu işlem ayrıca Ofis içinde de yapılabilir.
Etkinleştirme başarılı olduktan sonra, Office etkin kalacaktır.

### Telefon aktivasyon adımları

Anahtarı takın, `telefon aktivasyonu için kullanılabildiğinden emin olun '. Anahtar düğmesini yükleme menüsünde, Kurulum Kimliğini Göster'i tıklatın, onay kimliğini Microsoft tarafından sağlanan şekilde almak için bu kimliği kullanın ve ardından onay kimliğini yükleyin. Onay kimliği ve yükleme kimliği karşılık gelirse, Office çevrimdışı olarak başarıyla etkinleştirilebilir.
Etkinleştirme başarılı olduktan sonra, Office etkin kalacaktır.

### KMS aktivasyon adımları

Etkinleştirmeden önce lütfen Office'inizin toplu sürüm olduğundan emin olun .. Emin değilseniz, lütfen ilgili Birim sertifikasını kurun Örneğin, Office 2016'yı etkinleştirmek istiyorsanız, Office 2016 Birim sertifikasını yükleyin ve ardından bir KMS adresi belirleyin. Yapılandırma doğruysa, ağ normaldir ve sunucu normalse etkinleştirme düğmesini tıklayın; Office etkinleştirilecektir.

KMS aktivasyonu başarılı olduktan sonra, Office her 7 günde bir sunucuya bağlanacak ve otomatik olarak yenileyecek, maksimum sürekli aktivasyon süresi 180 gündür. Bu adım, Windows tarafından kendisi tarafından insan müdahalesi olmadan ve herhangi bir zindan olmadan yapılır. '

## KMS kullanılabilirliğini algılama

---

Bir KMS adresi girin ve düğme menüsünden KMS Kullanılabilirliğini Algıla'yı tıklayın.

Genel olarak, aşağıdaki sonuçlar iade edilecektir:
192.168.123.1:1688’e bağlanma ... başarılı
Aktivasyon isteği gönderme (KMS V4) 1/1 -> 03612-00206-524-247319-03-1100-14393.0000-2802018

Başarılı olduğunda, sunucunun normal olarak sunucuya bağlanabileceği ve Etkinleştirme isteğinin gönderilmesi, sunucunun etkinleştirme isteğine normal şekilde yanıt verebileceği anlamına gelir.

Test bir sonuç döndürmezse ya da döndürülen sonuç eksikse, bu KMS sunucusunda veya ağında bir sorun olabilir.

## Query Office aktivasyon durumu

---

Yüklü anahtarın lisans bilgilerini sorgulamak için * Etkinleştirme bilgilerini göster * seçeneğine tıklayın.
`Lisans durumu --- İzinli --- olduğunda, Office'in etkin olduğu ve diğer tüm durumların etkin olmadığı anlamına gelir. '

## Office Aktivasyon Bilgi Yönetimi

---

### Office Ürün Anahtarlarını Kaldırma

Yüklü anahtarın lisansı hakkında bilgi sorgulamak için * Etkinleştirme bilgilerini göster * seçeneğine tıklayın.

İstenmeyen yetkilendirmenin son beş basamaklı anahtarını kopyalayın, anahtar kutusuna yapıştırın ve etkinleştirme bilgilerini silmek için düğme menüsünde Anahtar Kaldır'ı seçin.

! [Ürün Anahtarını Kaldır] (https://coolhub.top/wp-content/uploads/2019/11/Uninstall Product Key.png)

### Office Ürün Anahtarlarını Temizle

Anahtar yönetiminin düğme menüsünde, tüm anahtarlar kaldırılabilir.
Tüm anahtarları kaldırdıktan sonra, Office etkin olmayan durumuna döner ve Office'i yeniden etkinleştirmeniz gerekir.

### Clear Office lisansı

Sertifika yönetiminin düğme menüsünden tüm lisanslar silinebilir.
Lisansınızı temizledikten sonra, bir Office uygulamasını ilk açtığınızda, varsayılan lisansı yeniden yüklemek için düzeltmeniz gerekir.
Ya da lisansı manuel olarak kurabilir ve kurulumdan sonra Office'i yeniden etkinleştirebilirsiniz.

** Etkinleştirme durumunu silmek, anahtarı ve sertifikayı birlikte siler. **

## Yaygın hatalar ve çözümler

---

Hata kodu: 0xC004F074
Hatanın nedeni: Bilinmiyor
Çözüm: 'Orijinal' sistemi yeniden yükleyin ve `Windows'u etkinleştirmek için KMS çatlama yazılımını kullanmayın.

Hata kodu 1: 0x8007007B
Neden: Dosya adı, dizin adı veya birim etiketi sözdizimi hatalı.
Hata kodu 2: 0x8007232B
Neden: DNS adı mevcut değil.
Hata kodu 3: 0x8007000D
Hatanın nedeni: geçersiz veri
Çözüm: Office aktivasyonunu araç kutusundan düzeltin, ardından KMS sunucu adresini ayarlayın, ardından etkinleştirin.

Hata mesajı: Bu bilgisayarda Office Toplu Lisans bulunamadı
Neden: Office Toplu Lisans yüklenmemiş ve MAK veya KMS kullanılarak etkinleştirilemiyor
Geçici Çözüm: Office Birimi Lisansını Yükleme (Birim)

Hata mesajı: Yazılım Lisanslama Servis Raporu Lisansı kurulu değil
Neden: Bu lisans varsayılan anahtarla birlikte yüklenir.
Çözüm: Deneme lisansını etkinleştirmeye çalışıyorsanız (sözde Office 365), bu sorunun çözülmesi gerekmez.
Aksi takdirde, geçerli bir anahtarı değiştirmeniz gerekir.

Hata mesajı: Yazılım Yetkilendirme Servisi raporu, ürün SKU'sunu bulamadı
Neden: Lisans yüklü değil veya anahtar ile sertifika uygun değil
Çözüm: İlgili yetkilendirme sertifikasını kurun veya başka bir anahtarı değiştirin.
Sertifikanın yüklenmesi sırasında bu hatayı alırsanız, aşağıdaki geçici çözümü izlemelisiniz

Hata 1: Bilinmeyen bir hata oluştu
Hata 2: Yazılım Yetkilendirme Hizmeti, lisans kullanımının başarısız olduğunu bildirdi
Neden: Windows Insider hatası, Office'in etkinleştirme bilgilerini doğrulamamasına neden oldu
Çözüm: Yazılım Koruma hizmetini durdurun ve C: \ Windows \ System32 \ spp \ store_test \ 2.0 altındaki üç (.dat) dosyasını silin (gizli bir tane var). Sonra tüm aktivasyonları tekrar yap

Hata mesajı: Bağlantı kurulurken bir hata oluştu.
Hata kodu: -2147023838
Neden: Sistem kritik hizmeti devre dışı
Geçici Çözüm: Hizmette Windows Yönetim Araçları hizmetini etkinleştirin ve etkinleştirildiğinde işlemi tekrar deneyin.

## GVLK listesi

---

GVLK'yi kullanmadan önce, Office'in hacimli olduğundan emin olun.
Toplu sürüm olup olmadığını bilmiyorsanız, lütfen ilgili Birim sertifikasını kurun ve sonra GVLK'yi kullanın.
KMS ile etkinleştirme, KMS sunucu adresinin yapılandırılmasını gerektirir, aksi takdirde Office etkinleştirilemez.

Daha fazla bilgi için, lütfen [Office 2019 ve Office 2016 için KMS ve Active Directory Etkinleştirmesi için GVLK] adresini ziyaret edin (https://docs.microsoft.com/en-us/DeployOffice/vlactivation/gvlks)

`Txt
Office 2019 GVLK

Office Pro Plus 2019 NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP
Office Standardı 2019 6NWWJ-YQWMR-QKGCB-6TMB3-9D9HK
Proje Pro 2019 B4NPR-3FKK7-T2MBV-FRQ4W-PKD2B
Proje Std 2019 C4F7P-NCP8C-6CQPT-MQHV9-JXD2M
Visio Pro 2019 9BGNQ-K37YR-RQHF2-38RQ3-7VCBB
Visio Std 2019 7TQNQ-K3YQQ-3PFH7-CCPPM-X4VQ2
Erişim 2019 9N9PT-27V4Y-VJ2PD-YXFMF-YTFQT
Excel 2019 TMJWT-YYNMB-3BKTF-644FC-RVXBD
Görünüm 2019 7HD7K-N4PVK-BHBCQ-YWQRW-XW4VK
PowerPoint 2019 RRNCX-C64HY-W2MM7-MCH9G-TJHMQ
Yayımcı 2019 G2KWX-3NW6P-PY93R-JXK2T-C9Y9V
İşletmeler için Skype NCJ33-JHBBY-HTK98-MYCV8-HMKHJ
Kelime 2019 PBX3G-NWMT6-Q7XBW-PYJGG-WXD33

Office 2016 GVLK

Ofis Pro Artı 2016 XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99
Ofis Standartları 2016 JNRGM-WHDWX-FJJG3-K47QV-DRTFM
Ofis Mondo 2016 HFTND-W9MK4-8B7MJ-B6C4G-XQBR2
Proje Pro 2016 WGT24-HCNMF-FQ7XH-6M8K7-DRTW9
Proje Std 2016 D8NRQ-JTYM3-7J2DX-646CT-6836M
Visio Pro 2016 69WXN-MBYV6-22PQG-3WGHK-RM6XC
Visio Std 2016 NY48V-PPYYH-3F4PX-XJRKJ-W4423
Erişim 2016 GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW
Excel 2016 9C2PK-NWTVB-JMPW8-BFT28-7FTBF
OneNote 2016 DR92N-9HTF2-97XKM-XW2WJ-XW3J6
Outlook 2016 R69KK-NTPKF-7M3Q4-QYBHW-6MT9B
PowerPoint 2016 J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6
Yayımcı 2016 F47MM-N3XJP-TQXJ9-BP99D-8K837
İşletmeler için Skype 869NQ-FJ69K-466HW-QYCP2-DDBV6
Kelime 2016 WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6
`

### Office 365 Pro Plus Normal Anahtar

DRNV7-VGMM2-B3G9T-4BF84-VMFTK

Ne anlama geldiğini anlamadıysanız, lütfen yine de kullanmayın, Office'i etkinleştirmek için kullanamazsınız.