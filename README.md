# Sipay Bootcamp Final Projesi

#### Proje bir yönetici ve kullanıcı temelinde oluşturulmuştur. İçeriğinde kişi, daire, aidat ve fatura bilgileri bulunmaktadır.

Projede API geliştirmede .NET teknolojisi kullanılırken veritabanında MsSQL kullanılarak Code First yaklaşımı Entity Framework ile geliştirilmiştir. Ayrıca JWT mimarisi kullanılarak rol bazlı yapı kurulmuştur.

### Proje İçin Gereksinimler
Aşağıdaki gereksinimleri bilgisayara yükledikten sonra projeyi incelemeye başlayabilirsiniz.
- .NET
- MSSQL
- SQL Server Studio
- Visual Studio

### Proje Çalıştırlmadan Önce Yapılacaklar
- Projeyi local ortama çektikten sonra Visual Studio ile açınız.
- FinalProjects.DataAcces katmanında bulunan DataContexts class da bulunan server adresini kendi local server adresiniz ile değiştirin.

### Database Oluşturmak için - Migration İşlemleri
- `dotnet ef mgrations add InitialMigration -s ../FinalProject/` aşağıdaki görseldeki gibi çalıştırınız
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/0c3a05b8-7aa9-417c-bae2-a11ccf8fe04b)
- İkinci adımda proje dizinine giderek `update-database` komutunu çalıştırınız 

Böylece veritabanı başarıyla local ortamınıza kurulmuş olur.

### NOT - Postman 
Postman kullanırken kullanıcı ilk sisteme kayıt olur ve dönen response da bulunan token ı kopyalayıp Header kısmında bulunan Authentication kısmına eklenmesi gerekmekteedir. Böylece JWT mimarisi devreye girer. Yalnız sisteme ilk kayıt olduktan sonra `/api​/Auth​/register` oluşan token ile Role Controller da bulunan `/api/Role/assignmentRole` isteğine Postman da ekleyerek aşağıdaki rollere karşı eşleştirilen Id ile userId yi kullanarak kayıt olan kullanıcıya rol ataması yapılır. (Bu veriler önceden eklenmiştir.)
- admin = 1
- customer(Kullanıcı) = 2 

## Auth Controller - Swagger
- ​/api​/Auth​/register
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/4ff9599a-b6e2-4da0-9fd4-19fab15d5a4d)
Sisteme giren kullanıcı yukarıda bulunan gerekli bilgileri girdikten sonra kullanıcı başarılı bir şekilde kaydedilirken response olarak ise token ve süresi döner.

- ​/api​/Auth​/login
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/3e680690-ab04-4bb3-9c5c-62dd0648124b)
Kullanıcı sisteme giriş yapabilmek için email ve şifresini girmelidir. Sonrasında başarılı bir şekilde giriş yapar.


## Role Controller - Swagger
- api/Role/assignmentRole
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/c918ae45-2072-4857-bb0f-8600b53e5743)
Admin böylece kullanıcılara istediği rolleri atayabilir. Aşağıda swagger ekranında görüldüğü gibi diğer isteklerde bulunarak silebilir ve id ye özel olarak filtreleyebilir.


## User Controller - Swagger
-/api/User/getAll
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/45d45b96-a7dc-434e-a0b6-43420651cd64)

-/api/User/getListByFlats
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/b53db1c9-e849-4cc3-99c5-d5c09b25baa9)

- /api/User/getById
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/e337b537-34a4-4d0d-b2ac-3354862c8aaf)

- Devamında bulunan Add, Delete, Update istekleri aşağıda bulunmaktadır
![image](https://github.com/hilal-coskun/sipay-.net-bootcamp/assets/68516832/8c346ff7-70ae-45ea-baf9-713df4b11ecb)





