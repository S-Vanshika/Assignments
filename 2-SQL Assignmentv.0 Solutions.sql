--Display the details from Customer table who is from country Germany
select * from Customer
where Country='Germany'

--Display the  fullname of the employee  
select FirstName+' ' + LastName as FullName from Customer

--display the customer details whose name holds second letter as U
select FirstName from Customer
where FirstName like '_u%'

--select order Details where unit price is greater than 10 and less than 20
select * from OrderItem
where UnitPrice > 10 AND UnitPrice < 20

--Display order details which contains shipping date and arrange the order by date
select OrderDate from OrderTable 
order by OrderDate ASC

--print the average quantity ordered for every product
select 
(select ProductName from Product
where Product.Id = OrderItem.ProductId) as Product_Name,
avg(Quantity) as Average_Quantity
from OrderItem group by ProductId

