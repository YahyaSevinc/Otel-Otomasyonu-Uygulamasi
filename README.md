Gördüğünüz Proje Yerel Veritabanı Kullanılarak Geliştirildiği İçin İlk Çalıştırdığınızda Düzgün Bir Sonuç Alamamış Olabilirsiniz.
Veritabanında Kullandığım Tabloların Oluşturma Kodlarını Buraya Bırakacağım.
Paylaştığım Kaynak Kodlarını İnceleyip Sql Bağlantılarını Kendi Bilgisayarınıza Göre Düzenledikten Sonra Ve Tabloları Doğru Şekilde Oluşturduktan Sonra Düzgün Sonuç Alabileceksiniz.

-----------------------------AdminGiris-----------------------------

USE [OtelOtomasyonu]
GO /*Eğer Go lar Hata verirse silmelisiniz.*/

/****** Object:  Table [dbo].[AdminGiris]    Script Date: 23.03.2024 20:15:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AdminGiris](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50),
	[Sifre] [int] 
) ON [PRIMARY]
GO

-----------------------------MusteriEkle,Ayrılanlar,SuresiDolanlar-----------------------------

USE [OtelOtomasyonu]
GO /*Eğer Go lar Hata verirse silmelisiniz.*/

/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 23.03.2024 20:17:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MusteriEkle]( /*"MusteriEkle" ismini "Ayrılanlar" ve "SuresiDolanlar" olarak değiştirip tekrar Query'i çalıştırın.*/
	[Musteriİd] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdı] [varchar](35),
	[MusteriSoyadı] [varchar](40),
	[MusteriTelefon] [varchar](16),
	[MusteriMail] [varchar](50),
	[MusteriTc] [varchar](12),
	[OdaNo] [varchar](5),
	[GirisTarihi] [date] NULL,/*Date türünde ki veriler için Column Properties bölümünden Default Value or Binding bölümüne (getdate()) yazmanız gerekir. (tabloya sağ tıklayıp design bölümünden ilgili yere ulaşırsınız.*/
	[CikisTarihi] [date] NULL,
	[Ucret] [int] 
) ON [PRIMARY]
GO

-----------------------------OdalarOda101v.b-----------------------------

USE [OtelOtomasyonu]
GO /*Eğer Go lar Hata verirse silmelisiniz.*/

/****** Object:  Table [dbo].[Oda101]    Script Date: 23.03.2024 20:19:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Oda101]( /*"Oda101" ismini "Oda102,Oda103,Oda104......." olarak değiştirip tekrar Query'i çalıştırın. Oda 201'e kadar yapmalısınız aksi halde uygulamanın kodları ile oynayıp müşteri ekle sayfasında eklemek istediğiniz kadarını yazmalısınız. Tekrar hata alırsanız 202 no lu odayı da ekleyiniz.*/
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](35),
	[Soyadi] [varchar](40)
) ON [PRIMARY]
GO

---------------------------------------------------------------------------

Tabii Bu İşlemleri Yapabilmek İçin Biraz Vİsual Studio 2022 ve Ssms Kullanmayı Bilmek Gerekiyor Ama Anlattığım İşlemler Gayet Basit Ve İnternette Birçok Örneğini Bulabileceğiniz Şeylerdir.
İyi Çalışmalar.






