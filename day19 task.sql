create database Task
go

create table RegFrom1
(
RegID int identity(0,1),
FirstName varchar(20),
LastName varchar(20),
Age int,
Constraint ck_age Check (age>=18),
Gender varchar(10),
PhoneNo varchar(10),
Adress varchar(50),
Email varchar(50),
District varchar(20),
State varchar(30),
Pincode char(10)
Constraint reg_frm1 primary key(RegID)
)
select * from RegFrom1
alter table Regfrom1
add Qualification varchar(20) constraint chk_Qul check(Qualification in ('B.E','B.tech','Bsc.cs','BCA','M.E','M.tech'))
select * from RegFrom1
insert RegFrom1 values('yuvaraj','A',21,'Male','0987654321','no65,gandhi nagar','yuvaraj@gmail.com','KPM','TN','631502','B.E')
insert RegFrom1 values('surya','D',21,'Male','1234567890','no.34,nehru nagar','surya@gmail.com','TRV','TN','600345','B.tech')
insert RegFrom1 values('pavan','T',21,'Male','9933774492','no.56,perumal nagar','pavan@gmail.com','Trupathi','AP','653508','BCA')
