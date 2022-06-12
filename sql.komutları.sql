create database PromosyonSepeti

create table SistemMagaza
(
id int identity(1,1) primary key,
tanim nvarchar(100),
adres nvarchar(100),
yetkiliKisi nvarchar(100),
kullaniciAdi nvarchar(50) unique,
sifre nvarchar(50)
)

insert into SistemMagaza values ('Sefak�y AVM Ma�aza-1','Sefak�y','Cengiz Atilla','cengizatilla','1')
insert into SistemMagaza values ('Sefak�y AVM Ma�aza-2','Sefak�y','Deniz K�kenli','denizk�kenli','1')
insert into SistemMagaza values ('Bayrampa�a AVM Ma�aza','Bayrampa�a','Berk Do�an','berkdogan','2')

select * from SistemMagaza

create table PotansiyelMusteri
(
id int identity(1,1) primary key,
tcKimlikNo nvarchar(11),
isim nvarchar(50),
soyisim nvarchar(50),
dogumTarih datetime,
cinsiyet int,
meslek nvarchar(100),
emailAdres nvarchar(100),
emailBildirimOnay bit,
telefon nvarchar(15),
telefonBildirimOnay bit,
olusturmaTarihi datetime,
olusturanMagaza int
)

select * from PotansiyelMusteri

create table PromosyonUrun
(
id int identity(1,1) primary key,
tanim nvarchar(100),
aciklama nvarchar(250),
gecerlilikTarihi datetime,
kullanimDurum bit,
)

insert into PromosyonUrun values ('%10','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%20','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%30','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%40','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%50','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%60','indirim t�m ma�azalarda ge�erli','2023.12.01',0)
insert into PromosyonUrun values ('%70','indirim t�m ma�azalarda ge�erli','2023.12.01',0)

select top 30* from PromosyonUrun where kullanimDurum=0 order by NEWID()
--burada order by NEWID() dedi�imiz i�in ilk 30 sat�r s�rekli de�i�im g�sterecek

create table KatilimciPromosyon
(
id int identity(1,1) primary key,
potansiyelMusteriId int,
promosyonUrunId int,
olusturmaTarih datetime,
magazaId int
)
select * from KatilimciPromosyon