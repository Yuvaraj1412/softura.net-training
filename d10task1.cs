using System;
class Members
{
int n1;
public Members(int age)
{
n1=age;
Console.WriteLine("Age:"+age);
}
}
class Detail:Members
{
string name;
public Detail(string str,int n):base(n)
{
name=str;
Console.WriteLine("Name:"+name);
}
class ID
{
public static void Main()
{
Detail obj=new Detail("yuvaraj",21);
}
}
}


