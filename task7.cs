using System;
class arith1
{
public void add(int n1,int n2)
{
int res;
res=n1+n2;
Console.WriteLine("addition:"+res);
}
public void sub(int n1,int n2)
{
int res;
res=n1-n2;
Console.WriteLine("subtraction:"+res);
}
}
class arith2:arith1
{
public void mult(int n1,int n2)
{
int res;
res=n1*n2;
Console.WriteLine("multiplication:"+res);
}
public void div(int n1,int n2)
{
int res;
res=n1/n2;
Console.WriteLine("division:"+res);
}
}
class arith
{
public static void Main()
{
arith2 obj=new arith2();
obj.add(30,20);
obj.sub(30,20);
obj.mult(30,20);
obj.div(30,20);
}
}


