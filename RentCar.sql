create table Cars(
Id int primary key identity(1,1),
BrandId int,
ColorId int,
ModelYear int,
DailyPrice int,
Description nvarchar(50),
foreign key (BrandId) references Brands(BrandId),
foreign key (ColorId) references Colors(ColorId)
)

create table Brands(
BrandId int primary key identity(1,1),
BrandName varchar(25)
)

create table Colors(
ColorId int primary key identity(1,1),
ColorName varchar(25)
)

insert into Colors(ColorName)
values ('Kırmızı'),('Yeşil'),('Siyah')

insert into Brands(BrandName)
values ('Volkswagen'),('Audi'),('Nissan')

insert into Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
values
(1,1,2021,800,'Volkswagen Tiguan Elegance'),
(1,2,2020,700,'Volkswagen Tiguan Life'),
(2,1,2019,600,'Audi A3 Sedan'),
(2,2,2018,500,'Audi A3 Sportback'),
(3,3,2017,400,'Nissan Juke Tekna')

select * from Cars
select * from Colors
select * from Brands