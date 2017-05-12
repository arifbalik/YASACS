create database mikro
use mikro

create table ogrenci
(
o_id int primary key identity(1,1),
o_adi nvarchar(50),
o_soyadi nvarchar(50),
o_kartid text
)