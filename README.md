# Cihaz Takip ve Entegrasyon Programı (DTI - Device Tracking Integration)

Bu proje, **Bilgi İşlem** birimlerinin cihaz envanter takibini ve yönetimini kolaylaştırmak amacıyla geliştirilmiştir. Proje, cihazların grup bazlı tanımları, teknik özellikleri ve personel cihaz ilişkilerini yönetmek için bir çözüm sunar. Ayrıca, sistem odası cihazları ve entegrasyon süreçlerini de organize etmeye yönelik özellikler içerir.

![Cihaz Takip Görseli](https://user-images.githubusercontent.com/37664100/185788974-e69b4f23-e149-4c0b-a73a-0409f1567bf5.png)

---

## Özellikler
- **Cihaz Yönetimi**:
  - Cihazların grup bazlı tanımlanması.
  - Teknik özelliklerin kaydedilmesi ve görüntülenmesi.
  - Cihazların sistem odası veya farklı lokasyonlara atanması.
- **Personel Yönetimi**:
  - Personelin kullandığı cihazların takibi.
  - Cihaz ve kullanıcı ilişkilerinin detaylı yönetimi.
- **Entegrasyon Süreçleri**:
  - Entegrasyon tanımları ve takip mekanizmaları.
  - Sistem odası ekipmanlarının entegrasyonu.
- **Teknik Görüntüleme**:
  - Teknik özelliklerin detaylı olarak incelenebilmesi.
- **Raporlama ve Analiz**:
  - Envanter durumunun ve cihaz hareketlerinin raporlanması.

---

## Teknolojiler
- **Dil**: C# (Windows Forms Application)
- **Veritabanı**: Microsoft SQL Server
- **Arayüz**: Windows Forms ile geliştirilen kullanıcı dostu bir arayüz.

---

## Kurulum ve Kullanım
1. **Veritabanı Kurulumu**:
   - `SQL DATABASE` klasöründeki SQL dosyasını kullanarak veritabanı tablolarını oluşturun.
2. **Proje Ayarları**:
   - `App.config` dosyasındaki veritabanı bağlantı bilgilerini kendi ortamınıza göre düzenleyin.
3. **Çalıştırma**:
   - Projeyi Visual Studio veya benzer bir geliştirme ortamında açarak çalıştırın.


- **Forms**:
  - **FormAnaEntegrasyon**: Programın ana yönetim ekranı.
  - **FormCihazGrupTanımları**: Cihaz gruplarının tanımlandığı ekran.
  - **FormCihazTanımla**: Yeni cihaz kayıt ekranı.
  - **FormCihazTeknik**: Cihaz teknik detaylarının görüntülendiği ekran.
  - **FormSistemOdası**: Sistem odasına özel cihazların yönetim ekranı.
  - **FormPersonelTanımlama**: Personel cihaz ilişkilerinin yönetildiği ekran.

