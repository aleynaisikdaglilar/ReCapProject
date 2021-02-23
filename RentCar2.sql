create table Users(
Id int primary key identity(1,1),
FirstName nvarchar(25),
LastName nvarchar(25),
Email nvarchar(50),
Password nvarchar(25)
)

create table Customers(
Id int primary key identity(1,1),
UserId int,
CompanyName nvarchar(50),
foreign key (UserId) references Users(Id),
)

create table Rentals(
Id int primary key identity(1,1),
CarId int,
CustomerId int,
RentDate Datetime,
ReturnDate Datetime,
foreign key (CarId) references Cars(Id),
foreign key (CustomerId) references Customers(Id),
)