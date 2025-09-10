# [Blogging Platform API](https://roadmap.sh/projects/blogging-platform-api)

## Proje Amacı

Bu proje "roadmap.sh" websitesinin başlangıç seviye projelerinden birisidir. Restful API ile temel CRUD işlemlerinin yapılmasını beklemektedir.

## Proje Hedefleri

- En iyi uygulamalar ve kurallar dahil olmak üzere RESTful API'lerin ne olduğunu öğrenmek.
- RESTful API oluşturmayı öğrenmek.
- GET, POST, PUT, PATCH, DELETE gibi yaygın HTTP yöntemleri hakkında bilgi edinmek.
- API'lerde durum kodları ve hata yönetimi hakkında bilgi edinmek.
- API kullanarak CRUD işlemlerini nasıl gerçekleştireceğinizi öğrenmek.
- Veritabanlarıyla nasıl çalışacağınızı öğrenmek.

## Proje Açıklaması

ASP.NET Core Web API ile geliştirilmiştir. Katmanlı mimari ile modeller, veri tabanı işlemler, iş mantığı işlemleri ve controller yapıları birbirinden ayrılmıştır. Basitçe yapılacak işlemler olduğu için AutoMapper vb. bir kütüphane kullanılmamıştır.

## Dosya Yapısı

```
/BloggingPersonalAPI
  /Entities
    /DTOs
    /Entities
  /Repositories
    /Configs
    /Contexts
    /Implementations
    /Interfaces
  /Services
    /Implementations
    /Interfaces
  /WebApi
    /ContextFactory
    /Controllers
    /Migrations
```
