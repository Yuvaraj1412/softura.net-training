using System;
class Employee
{
public void Detail()
{
Console.WriteLine("Emp ID:");
string EmpID=Console.ReadLine();
Console.WriteLine("Emp Name:");
string name=Console.ReadLine();
Console.WriteLine("Emp Age:");
string age=Console.ReadLine();
Console.WriteLine("Year Of Exp:");
string yoe=Console.ReadLine();
Console.WriteLine(EmpID);
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(yoe);
}
}
class Salary: Employee
{
public void bonus1()
{
int sal1;
sal1=20000+2000;
Console.WriteLine(sal1);
}
public void bonus2()
{
int sal2;
sal2=20000+1000;
Console.WriteLine(sal2);
}
}
class data
{
public static void Main()
{
Salary obj=new Salary();
obj.Detail();

Salary obj2=new Salary();
Console.WriteLine("dept:");
string dep=Console.ReadLine();
Console.WriteLine(dep);
switch(dep)
{
case "sales" : obj2.bonus1();
break;
case"production" : obj2.bonus2();
break;
}
}
}