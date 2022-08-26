--Applying foreign key
--For fk2
alter table OrderItem 
add constraint OrderItem_ProductId_FK
foreign key (ProductId) references Product (Id)

--For fk1
alter table OrderItem 
add constraint OrderItem_OrderId_FK
foreign key (OrderId) references OrderTable (Id)

--For fk
alter table OrderTable 
add constraint OrderTable_CustomerId_FK
foreign key (CustomerId) references Customer (Id)


--Insertion of records
insert into Customer Values (11010,'Sammy','Singh','New Delhi','India','1234567890')
insert into Customer Values (1011,'Robert','Cullen','Berlin','Germany','1234567800')
insert into Customer Values (112,'Oliver','Mathews','Wuhan','China','1234567790')

insert into OrderTable Values (100,2021-11-07,'1213456',110010,984)
insert into OrderTable Values (101,2020-05-07,'1587982',112,468.25)
insert into OrderTable Values (102,2022-08-18,'8765527',110010,77.77)

insert into Product Values (10,'Shampoo',689.77,'New',0)
insert into Product Values (11,'Soap',25.89,'Bell',1)
insert into Product Values (12,'Olive Oil',787.77,'Best',0)

insert into OrderItem Values (0,101,11,98.77,90)
insert into OrderItem Values (1,100,12,654,8)
insert into OrderItem Values (2,102,10,12.57,77)

--Display all customer details
select * from Customer

--write a query to display Country whose name starts with A or I
select Country from Customer
where Country like 'A%'
or Country like 'I%'

--write a query to display whose name of customer whose third character is i
select FirstName from Customer
where FirstName like '__i%'
