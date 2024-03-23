Gördüğünüz Proje Yerel Veritabanı Kullanılarak Geliştirildiği İçin İlk Çalıştırdığınızda Düzgün Bir Sonuç Alamamış Olabilirsiniz.
Veritabanında Kullandığım Tabloların Oluşturma Kodlarını Buraya Bırakacağım.
Paylaştığım Kaynak Kodlarını İnceleyip Sql Bağlantılarını Kendi Bilgisayarınıza Göre Düzenledikten Sonra Ve Tabloları Doğru Şekilde Oluşturduktan Sonra Düzgün Sonuç Alabileceksiniz.

-----------------------------AdminGiris-----------------------------

USE [OtelOtomasyonu]
GO

/****** Object:  Table [dbo].[AdminGiris]    Script Date: 23.03.2024 20:15:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AdminGiris](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [int] NULL
) ON [PRIMARY]
GO

-----------------------------MusteriEkle,Ayrılanlar,SuresiDolanlar-----------------------------

USE [OtelOtomasyonu]
GO

/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 23.03.2024 20:17:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MusteriEkle]( //"MusteriEkle" ismini "Ayrılanlar" ve "SuresiDolanlar" olarak değiştirip tekrar Query'i çalıştırın.
	[Musteriİd] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdı] [varchar](35) NULL,
	[MusteriSoyadı] [varchar](40) NULL,
	[MusteriTelefon] [varchar](16) NULL,
	[MusteriMail] [varchar](50) NULL,
	[MusteriTc] [varchar](12) NULL,
	[OdaNo] [varchar](5) NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL,
	[Ucret] [int] NULL
) ON [PRIMARY]
GO

-----------------------------OdalarOda101v.b-----------------------------

USE [OtelOtomasyonu]
GO

/****** Object:  Table [dbo].[Oda101]    Script Date: 23.03.2024 20:19:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Oda101]( //"Oda101" ismini "Oda102,Oda103,Oda104......." olarak değiştirip tekrar Query'i çalıştırın.
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](35) NULL,
	[Soyadi] [varchar](40) NULL
) ON [PRIMARY]
GO

---------------------------------------------------------------------------

Tabii Bu İşlemleri Yapabilmek İçin Biraz Vİsual Studio 2022 ve Ssms Kullanmayı Bilmek Gerekiyor Ama Anlattığım İşlemler Gayet Basit Ve İnternette Birçok Örneğini Bulabileceğiniz Şeylerdir.
İyi Çalışmalar.






