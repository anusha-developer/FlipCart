Create database Filpcart;
Create table Tbl_Products1(
ProductId int Identity(1,1) primary key,
Name varchar(100),
Description varchar(150),
Price decimal);

Select * from Tbl_Products1;

insert into Tbl_Products1 values('Vivo','VivoY55',15000);
insert into Tbl_Products1(Name,Description,Price)values('Oppo','Oppo 10pro',17000);

select Count (*) Name,Name from Tbl_Products1 GROUP BY Name;
---count means number of values
----First Name is the Count
---Second Name is the What column name we have to display we will give that name

--Query is used for to display above 14000 values
Select * from  Tbl_Products1 where Price >14000;

--Query is used for to display below 14000 values
Select * from  Tbl_Products1 where Price <14000;

--Query is used for to display  Greater than or equal to 14000 values
Select * from  Tbl_Products1 where Price >=14000;

--Query is used for between values(15000-20000)
select * from Tbl_Products1 where Price  Between 15000 And 20000;

