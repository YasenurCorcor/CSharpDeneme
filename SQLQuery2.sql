--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers


Select * from Customers where City ='London'

--case insensitive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID,ProductName

--asc > ascending (artan)
--desc > descending (düşen-azalan)

select * from Products order by UnitPrice desc

select * from Products order by UnitPrice asc

select * from Products where CategoryID=1 order by UnitPrice desc

--Lists how many products there are
select count (*) from Products

--How many products are there with a category number=2 ?
select count (*) from Products where CategoryID=2

--write "Adet"
select count(*) Adet from Products where CategoryID=2

--How many different products do we have in which category ?
select categoryID, count(*) from products group by CategoryID

--List include products's UnitPrice>20 and Stock<10
select categoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 

--DTO Data Transformation Object

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--inner join sadece eşleşen kayıtları gösterir
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

--solda olup sağda olmayanlar=satışı olmayan ürünler
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c inner join Orders o
on c.CustomerID=o.CustomerID

--solda olup da müşretilerde olmayan ürünler
select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID

--hiç sipariş vermemiş müşteriler
--tablonun soluna yazar
select * from Customers c left join Orders o 
on c.CustomerID=O.CustomerID
where o.CustomerID is null

--hiç sipariş vermemiş müşteriler
--tablonun sağında yazar
select * from Orders o right join Customers c
on c.CustomerID=o.CustomerID
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o  
on o.OrderID=od.OrderID











 


