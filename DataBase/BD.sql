use master 
go

if exists(Select * FROM SysDataBases WHERE name='ecommerce')
BEGIN
DROP DATABASE ecommerce
END
go

------------------------------------------------------------

create database ecommerce
on
(
name = ecommerce,
filename ='c:\BASE_DE_DATOS\ecommerce.mdf'
)
go

------------------------------------------------------------

use ecommerce
go

create table PeriodPeriod
(
IdPeriod int not null primary key ,
NamePeriod Varchar(25) not null,
StatusPeriod bit not null
)
go

use ecommerce
go

create table Photo
(
IdPhoto int not null primary key ,
NamePhoto Varchar(25),
TicketIdPhoto int
)
go

use ecommerce
go

create table Ticket
(
IdTicket int not null primary key ,
TitleTicket Varchar(25) not null,
CreateDate date not null,
StatusId int not null,
CategoryId int not null,
PeriodId int not null,
EmployeeId int,
SupportedId int not null,
)
go

create table Category
(
IdCategory int not null primary key ,
NameCategory Varchar(25) not null,
StatusCategory bit not null
)
go

create table Account
(
IdAccount int not null primary key ,
Username Varchar(25) not null,
Pw varchar(25) not null,
FullName varchar(25) not null,
StatusAccount bit not null,
Email varchar(25) not null,
RoleId int not null,


)
go

create table Discussion
(
IdDiscussion int not null primary key ,
[Content] text,
CreatedDate date,
TicketIdDiscussion int,
AccountId int

)
go

create table StatusStatus
(
IdStatus int not null primary key ,
NameStatus Varchar(25) not null,
Display bit not null

)
go

create table RoleRole
(
IdRole int not null primary key,
NameRole Varchar(25) not null

)
go