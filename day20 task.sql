use AdventureWorks2019
go

--Task 1--
select FirstName,LastName
from Person.Person
where Title is not null

--Task 2--
select FirstName,LastName
from Person.Person
where FirstName like '%a%' and LastName like '%a%'

--Task 3--
select cs.CurrencyCode,Name 
from Sales.Currency,Sales.CountryRegionCurrency cs

--Task5--
create table Task5
(
Sno int identity(1,1),
FirstName varchar(30),
LastName varchar(30),
Gender char(10),
DateOFBirth varchar(20)
)
select * from Task5

insert Task5 values('Yuvaraj','A','M','14-12-2001')
insert Task5 values('Santhosh','Kumar','M','03-08-2001')
insert Task5 values('Surya','D','M','25-07-2000')
insert Task5 values('Pavan','Kumar','M','21-04-2000')
insert Task5 values('Kishore','Kumar','M','12-09-2000')
insert Task5 values('Prakash','A','M','10-03-1999')
insert Task5 values('Yogesh','Kumar','M','03-10-2000')
insert Task5 values('Venkat','A','M','05-01-2001')
insert Task5 values('Vignesh','V','M','14-07-2000')
insert Task5 values('Vishwa','D','M','07-07-2000')
insert Task5 values('Dhoni','MS','M','07-07-1983')
insert Task5 values('Jadeja','R','M','14-03-1990')
insert Task5 values('Bravo','DJ','M','21-09-1985')
insert Task5 values('Virat','K','M','11-05-1990')
insert Task5 values('Vijay','C','M','21-07-1975')
insert Task5 values('Ajith','Kumar','M','01-05-1972')
insert Task5 values('Suriya','S','M','17-08-1979')
insert Task5 values('Rajini','S','M','12-12-1960')
insert Task5 values('Kamal','Hassan','M','18-05-1960')
insert Task5 values('vikram','C','M','13-06-1970')

--Task6--
select dept.Name as BusinessEntityID,AddresstypeID
from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory edept
on edept.departmentID = edept.DepartmentID
join Person.BusinessEntityAddress ba
on ba.BusinessEntityID =edept.BusinessEntityID

--Task7--
select distinct GroupName
from HumanResources.Department

--Task8--
select pro.StandardCost, sum(Listprice)sum1,sum(pro.StandardCost)sum2
from Production.Product pro
join Production.ProductCostHistory phis
on pro.ProductID = phis.ProductID
group by pro.StandardCost

--Task9--
select DATEDIFF(year,StartDate,EndDate) as 'years on role' 
from HumanResources.EmployeeDepartmentHistory

--Task10--
select SalesQuota
from Sales.SalesPersonQuotaHistory
where SalesQuota>5000 and
SalesQuota<100000
group by SalesQuota

--Task11--
select max(taxrate) maximumrate
from Sales.SalesTaxRate

--Task12--
select ehis.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory ehis
on emp.BusinessEntityID = ehis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = ehis.DepartmentID
select Birthdate,GETDATE() as currentdate,DATEDIFF(yy,birthdate,getdate()) as age from HumanResources.Employee

--Task13--
create view Task12
as
select Birthdate,GETDATE() as currentdate,DATEDIFF(yy,birthdate,getdate()) as age from HumanResources.Employee
go
select * from Task12

--Task14--
select * into HR_dept
from HumanResources.Department
select*from HR_dept


select count(*)No_of_rows_hr
from HumanResources.Department,HumanResources.Employee,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory,HumanResources.JobCandidate,HumanResources.Shift

--Task15--
select max(rate) as maxsalary,Name 
from HumanResources.EmployeePayHistory phis
join HumanResources.EmployeeDepartmentHistory dhis
on phis.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
group by Name

--Task16--
select FirstName,LastName,Title,AddressTypeID,Eadd.BusinessEntityID
from Person.BusinessEntityAddress Eadd
left outer join Person.Person pp
on pp.BusinessEntityID = Eadd.BusinessEntityID
where Title is not null

--Task17--
select ProductID,LocationID,Shelf
from Production.ProductInventory 
where ProductID>300 and ProductID<350 and LocationID=50

--Task18--
select pi.LocationID,Shelf,Name
from Production.ProductInventory pi
join Production.Location pl
on pi.LocationID = pl.LocationID

--Task19--
select AddressID,AddressLine1,AddressLine2,StateProvinceCode,st.StateProvinceID,CountryRegionCode
from Person.StateProvince st
join Person.Address padd
on st.StateProvinceID = padd.StateProvinceID

--Task20--
select CurrencyCode,sum(subtotal) sumofsubtotal,TaxAmt
from sales.SalesOrderHeader sh
join Sales.SalesTerritory st
on sh.TerritoryID = st.TerritoryID
join Sales.CountryRegionCurrency crc
on st.CountryRegionCode = crc.CountryRegionCode
group by CurrencyCode,TaxAmt



