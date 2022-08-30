--write a query to display the orders placed by customer with phone number 0300074321
select * from OrderTable
where CustomerId = 
(select Id from Customer
where Phone = '0300074321');

--fetching all the products which are available under Category ‘Seafood’.
--select ProductName from Product
--where Category = 'Seafood'

--display the orders placed by customers not in London
select * from OrderTable
where CustomerId in
(select Id from Customer
where City not in ('London'))

--selects all the order which are placed for the product Chai.
select * from OrderTable
where Id in
(select OrderId from OrderItem
where ProductId in
(select Id from Product
where ProductName='Chai'))