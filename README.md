MeetingApp - ASP.NET Core Toplantı Katılım Uygulaması

Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş basit bir toplantı katılım (RSVP) uygulamasıdır. Kullanıcıların bir toplantıya katılıp katılmayacaklarını bildirmelerine, gönderilen başvuruları listelemelerine ve katılımcı sayısını ana sayfada görmelerine olanak tanır.

Bu proje, ASP.NET Core temellerini anlamak için harika bir başlangıç noktasıdır:
-MVC (Model-View-Controller) deseni
-Routing (Yönlendirme)
-View'lara model gönderme (ViewBag ve strongly-typed modeller)
-Form işlemleri (GET ve POST metodları)
-Model Binding
-Veri Doğrulama (Validation)

🚀 Özellikler:
-Dinamik Ana Sayfa: Günün saatine göre kullanıcıyı "Günaydın" veya "İyi günler" gibi farklı mesajlarla karşılar.
-Toplantı Bilgisi: Ana sayfada toplantının yeri, tarihi ve katılım durumu onaylanmış toplam kişi sayısını gösterir.
-Katılım Formu (RSVP): Kullanıcıların ad, telefon, e-posta bilgilerini girdiği ve toplantıya katılıp katılmayacaklarını seçebildikleri bir form içerir.
-Veri Doğrulama: Form gönderildiğinde girilen verilerin geçerli olup olmadığını kontrol eder.
-Katılımcı Listesi: Toplantıya başvuru yapmış tüm kullanıcıları ve katılım durumlarını gösteren bir liste sayfası.
-Katılımcı Detayları: Listeden seçilen bir kullanıcının detay bilgilerini gösteren ayrı bir sayfa.

🛠️ Kullanılan Teknolojiler:
-Backend: C#, ASP.NET Core MVC
-Frontend: HTML, CSS, Bootstrap
-Platform: .NET
--------------------------------------------------------ENGLISH----------------------------------------------------

MeetingApp - ASP.NET Core Meeting Participation Application

This project is a simple meeting participation (RSVP) application developed using ASP.NET Core MVC. It allows users to indicate whether they will attend a meeting, list submitted applications, and view the number of participants on the homepage.

This project is a great starting point for understanding ASP.NET Core fundamentals: - The MVC (Model-View-Controller) pattern - Routing - Sending models to views (ViewBag and strongly-typed models) - Form operations (GET and POST methods) - Model Binding - Data Validation

🚀 Features: - Dynamic Home Page: Greets the user with different messages, such as "Good morning" or "Good afternoon," depending on the time of day. - Meeting Information: The homepage displays the meeting location, date, and total number of confirmed participants. -Registration Form (RSVP): This form allows users to enter their name, phone number, and email address, and choose whether or not to attend the meeting. -Data Validation: This checks whether the data entered is valid when the form is submitted. -Attendee List: A list page showing all users who have applied for the meeting and their attendance status. -Attendee Details: A separate page showing detailed information about a user selected from the list.

🛠️ Technologies Used: -Backend: C#, ASP.NET Core MVC -Frontend: HTML, CSS, Bootstrap -Platform: .NET
