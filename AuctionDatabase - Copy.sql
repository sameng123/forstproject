create database Auction 
use Auction

create table Users(
User_Id int Primary Key identity(1,1),
User_Name nvarchar(50),
User_Email nvarchar(50),
User_Password nvarchar(50),
Items_Uploaded int,
);

create table Category(
Cat_id int primary Key identity(1,1),
Cat_Name nvarchar(50),
);

insert into Category values('Property');
insert into Category values('Accessories');
insert into Category values('Painting');
insert into Category values('Furniture');
insert into Category values('Vehicle');
select * from Category

create table Items(
Item_Id int Primary Key identity(1,1),
Item_Title nvarchar(50),
Item_description nvarchar(50),
Bid_Status nvarchar(50),
Bid_Sdate date,
Bid_Edate date,
Bid_Inc int,
Min_Bid int,
Cat_id int Foreign Key References Category(Cat_id),
);
