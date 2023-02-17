-- create table Customers
use Market -- open database
go
create table customers
(
customerID int identity(10,1) primary Key not null,
customerContact varchar(50) not null,
customerCity    varchar(50) not null,
customerBirthDay datetime

)