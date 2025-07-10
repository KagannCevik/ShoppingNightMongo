🛍️ MongoDB ile E-Ticaret Sitesi
Bu repository, M&Y Yazılım Akademi bünyesinde gerçekleştirdiğim üçüncü proje olan MongoDB tabanlı dinamik E-Ticaret uygulamasını içermektedir.

🛒 Proje Hakkında
Bu uygulama, ASP.NET Core MVC ve MongoDB teknolojileri kullanılarak geliştirilmiş tam işlevsel bir alışveriş sistemidir. Amaç, modern alışveriş ihtiyaçlarını karşılayacak esnek bir yapı sunmaktır. NoSQL mimarisi sayesinde ürün ve kategori gibi veriler dinamik olarak yönetilmektedir.

🧩 Uygulama Yapısı
Uygulama 2 temel bölümden oluşmaktadır:</br>
👤 Admin Paneli: Kategori, ürün, slider ve kullanıcı işlemlerini yöneten, içerik yönetimi sağlayan bir arayüzdür.</br>
📱 Vitrin Paneli: Ziyaretçilerin ürünleri kategori bazında filtreleyerek detaylara ulaşabildiği, sepet işlemleri yapabildiği kullanıcı odaklı bölümdür.</br>
Çoklu ürün görseli, dinamik ürün detayı ve yorum altyapısı ile modern e-ticaret ihtiyaçlarına cevap vermektedir.

🗄️ MongoDB ve Veri İşlemleri
Proje boyunca veri yönetimi için MongoDB kullanılmıştır. Veri işlemleri MongoDB.Driver ve MongoDB.Bson üzerinden yönetilmiştir.</br>

Kullanılan bazı MongoDB metotları:</br>
💎 Create → InsertOneAsync()</br>
💎 Read → Find(), FindAsync()</br>
💎 Update → UpdateOneAsync(), ReplaceOneAsync()</br>
💎 Delete → DeleteOneAsync()</br>
Entity ve DTO yapılarıyla birlikte veriler kontrollü şekilde aktarılmıştır.

🔧 Teknik Yapı ve Mimarisi
Proje tek katmanlı gibi görünse de iç mimaride şu şekilde yapılandırılmıştır:</br>
💎 Entities — Veri modelleri</br>
💎 DTOs — Veri transfer nesneleri</br>
💎 Services — İş mantığı</br>
💎 Controllers & Views — MVC yapısı</br>
💎 ViewComponents — Modüler yapı</br>
Arayüzde Bootstrap 5 ile responsive tasarım yapılmış, AutoMapper ile model dönüşümleri kolaylaştırılmıştır.</br>

📬 Ekstra Özellikler
💎 E-posta bildirimi (SMTP ile)</br>
💎 Abonelik sonrası kupon oluşturma</br>
💎 AJAX ve Fetch API ile veri güncellemeleri</br>
💎 Çoklu ürün görseli yönetimi</br>
💎 Gelişmiş arama ve filtreleme</br>

🛠️ Kullanılan Teknolojiler
💎 ASP.NET Core 8.0</br>
💎 MongoDB</br>
💎 MongoDB.Driver & MongoDB.Bson</br>
💎 AutoMapper</br>
💎 Razor Pages / MVC</br>
💎 HTML5, CSS3, JavaScript</br>
💎 Bootstrap 5</br>
💎 ViewComponent</br>

Bu proje ile hem MongoDB ile çalışmayı öğrendim hem de gerçek bir e-ticaret projesini baştan sona geliştirme tecrübesi kazandım. Açık kaynak olarak geliştirmeye açıktır.

🧩 Projeden Ekran Görüntüleri
🎀 Vitrin Paneli

<img width="1917" height="941" alt="Ekran görüntüsü 2025-07-11 015329" src="https://github.com/user-attachments/assets/1312c074-78ca-4109-9769-12d70ff27570" />
<br>
<img width="1905" height="435" alt="Ekran görüntüsü 2025-07-11 015648" src="https://github.com/user-attachments/assets/fbb9f67d-88c2-47c8-895f-4c7177689c93" />

<img width="1915" height="947" alt="Ekran görüntüsü 2025-07-11 015730" src="https://github.com/user-attachments/assets/22a2d884-a2bf-4d8f-b579-2c1de4a36f2b" />

<img width="1917" height="854" alt="Ekran görüntüsü 2025-07-11 015740" src="https://github.com/user-attachments/assets/580dddd8-d3b9-4157-a1d5-2f54011f7fec" />

<img width="1899" height="469" alt="Ekran görüntüsü 2025-07-11 021635" src="https://github.com/user-attachments/assets/d9075670-114a-4162-9743-d09c3d45d505" />

### 💌 Gerçek Zamanlı İndirim Kuponu Gönderilen Mail
<img width="711" height="704" alt="Ekran görüntüsü 2025-07-11 015816" src="https://github.com/user-attachments/assets/fdfadd63-bf4c-4302-9329-46c03ee2aaa1" />


### 💻 Admin Paneli
<img width="1914" height="941" alt="Ekran görüntüsü 2025-07-11 015931" src="https://github.com/user-attachments/assets/53050583-4eb5-4654-abc6-364de870d81c" />

<img width="1915" height="947" alt="Ekran görüntüsü 2025-07-11 015940" src="https://github.com/user-attachments/assets/cfab2b53-bd2b-4aff-a7a7-eb516ea24344" />


<img width="1917" height="936" alt="Ekran görüntüsü 2025-07-11 015951" src="https://github.com/user-attachments/assets/f6ea4c30-639c-4a0e-93df-99869a0c21dc" />

<img width="1914" height="946" alt="Ekran görüntüsü 2025-07-11 015958" src="https://github.com/user-attachments/assets/71170803-24a1-461c-8b80-3fd075849c38" />

