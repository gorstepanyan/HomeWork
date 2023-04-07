use [master]
GO
DROP DATABASE Hospital
GO

create database Hospital;
GO
use [Hospital]
GO

create table Users
(
	Id int not null identity(1,1),
	FirstName nvarchar(50),
	Lastname nvarchar(50),
	PatronymicName nvarchar(50),
	BirthDate date,
	Primary key clustered (Id)
)

declare @FirstName nvarchar(50),
		@LastName nvarchar(50),
		@PatronimycName nvarchar(50),
		@Profession nvarchar(50),
		@BirthDate date,
		@Salary decimal,
		@Count as int = 1;

while(@Count <= 20)
Begin
	set @FirstName = 'UF_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @LastName = 'UL_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @PatronimycName = 'UP_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @BirthDate = cast(cast((rand()*70 + 1950) as int) as nvarchar(4)) + '-' + ltrim(rtrim(cast(cast((rand()*12+1) as int) as nvarchar(2)))) + '-' + ltrim(rtrim(cast(cast((rand()*28+1) as int) as nvarchar(2))))
	INSERT INTO Users(FirstName,Lastname,PatronymicName,BirthDate) values(@FirstName, @LastName, @PatronimycName, @BirthDate)
	set @Count = @Count + 1
End


create table Doctors
(
	Id int not null identity(1,1),
	FirstName nvarchar(50),
	Lastname nvarchar(50),
	PatronymicName nvarchar(50),
	Profession nvarchar(50),
	Salary decimal,
	Primary key clustered (Id)
)
set @Count = 1;
while(@Count <= 5)
Begin
	set @FirstName = 'DF_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @LastName = 'DL_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @PatronimycName = 'DP_' + (select char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65))+char((rand()*25 + 65)))
	set @Profession = 'Profession' + cast(@count as nvarchar(1))
	set @Salary = rand()*1000000+1
	INSERT INTO Doctors(FirstName,Lastname,PatronymicName,Profession, Salary) values(@FirstName, @LastName, @PatronimycName, @Profession, @Salary)
	set @Count = @Count + 1
End

create table Diagnoses
(
	Id int not null identity(1,1),
	DiagnoseName nvarchar(100),
	Primary key clustered (Id)
)




declare @Diagnose nvarchar(100)
set @Count = 1;
while(@Count < 10)
Begin
	set @Diagnose = 'Diagnose' + ltrim(rtrim(cast(@count as nvarchar(1))))
	print @Diagnose
	INSERT INTO Diagnoses(DiagnoseName) values(@Diagnose)
	set @Count = @Count + 1
End



create table Anketa
(
	Id int not null identity(1,1),
	UserId int not null,
	DoctorId int not null,
	CreatedDate DateTime not null,
	DiagnoseId int not null,
	Price decimal null,
	Paid bit not null default(0),
	foreign key (UserId) references Users(Id),
	foreign key (DoctorId) references Doctors(Id)
)



set @Count = 1;
declare @UserId int,
		@DoctorId int,
		@DiagnoseId int,
		@CreatedDate datetime,
		@Price decimal,
		@Paid decimal

while(@Count <= 50)
Begin
	set @UserId = cast(rand()*10 + 1 as int)
	set @DoctorId = cast(rand()*5 + 1 as int)
	set @DiagnoseId = cast(rand()*10 + 1 as int)
	set @CreatedDate = '2023' + '-' + ltrim(rtrim(cast(cast((rand()*3+1) as int) as nvarchar(2)))) + '-' + ltrim(rtrim(cast(cast((rand()*28+1) as int) as nvarchar(2))))
	set @Price = cast(rand()*200000+200000 as int)
	set @Paid = round(rand() * 1,0)
	INSERT INTO Anketa(UserId,DoctorId, CreatedDate, DiagnoseId,Price, Paid) values(@UserId, @DoctorId, @CreatedDate, @DiagnoseId, @Price, @Paid)
	set @Count = @Count + 1
End


select ROW_NUMBER() Over(order by Ank.Id) Id, Ank.CreatedDate, 
U.FirstName + ' ' + Left(U.LastName,1) + '. ' + U.PatronymicName as UserName,
D.FirstName + ' ' + D.LastName as DoctorName,
Diag.DiagnoseName, Ank.Price, Ank.Paid
from Anketa Ank
inner join Users U on U.Id = Ank.UserId
inner join Doctors D on D.Id = Ank.DoctorId
inner join Diagnoses Diag on Diag.Id = Ank.DiagnoseId
where Ank.CreatedDate between '2023-03-01' and '2023-03-10'

/*
select * from Users
select * from Doctors
select * from Diagnoses
select * from Anketa
*/


