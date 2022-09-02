-- Display the employee details whose joined at first 
--select * from Employees order by JoiningDate

-- Display th eemployee details whose joiined at recently
--select * from employees order by joiningDate desc

-- Write a query to get most expense and least expensive Product List (name and unit price).
With cte as (select max(UnitPrice) as maxprice, min(UnitPrice) as minprice from Product)
select ProductName, UnitPrice from Product
where UnitPrice in ((select maxprice from cte), (select minprice from cte))
order by UnitPrice desc

-- Display the list of products that are out of stock
select * from Product
where IsDicontinued = 1;

-- Display complete list of customers, the OrderId and date of any orders they have made
select Customer.*, OrderTable.Id, OrderTable.OrderDate
from Customer join OrderTable
on Customer.Id = OrderTable.CustomerId

-- Write query that determines the customer who has placed the maximum number of orders
With cte as (select CustomerId, Count(*) as c from OrderTable group by CustomerId)
select * from Customer where Id in (
select CustomerId from cte where c = (
select max(c) from cte))

-- Display the customerid whose name has substring 'RA
select Id from Customer 
where FirstName+' '+LastName like '%RA'

-- Display the first letter of all the customer name
select substring(FirstName, 1, 1) as FirstLetter
from Customer order by Id