use AdventureWorks2019
go

--task1--
--using count--
select count(*)
from Person.Person
--using sum--
select sum(subtotal) sumofsubtotal
from Sales.SalesOrderHeader
--using datediff--
select DATEDIFF(year,StartDate,EndDate) as 'years on role' 
from HumanResources.EmployeeDepartmentHistory
--using dateadd---
SELECT DATEADD(month, 0, '2022/04/04') AS DateAdd
--using convert--
select convert(int,96.89)
--using left--
select LEFT('yuvaraj',4) as extractstring
--using len--
select len('yuvaraj')
--using reverse--
select reverse('yuvaraj')

--task2--
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Rupees
from HumanResources.EmployeePayHistory

--task3--
create view data1
as
select [DepartmentID],[Name],[GroupName]
from[HumanResources].[Department]
go

select*from [HumanResources].[Department]

insert data1([Name],[GroupName])
values('Manager','head')

insert [HumanResources].[Department] ([Name],[GroupName])
values('yuvaraj','Dotnet')

select *from data1



--task5--
use AdventureWorks2019
go
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))
--task6--
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
Group By [ProductModelID]

--task7--
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
